using Machine_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Machine_test.Controllers
{
    public class CategoryMasterController : Controller
    {
        private readonly TodoContext context;
        public CategoryMasterController(TodoContext context)
        {
            this.context = context;

        }
        public ActionResult Index()
        {
            var result = context.CategoryMaster.ToList();

            return View(result);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryMaster model)
        {
            if (ModelState.IsValid)
            {
                var cat = new CategoryMaster()
                {
                    CategoryId = model.CategoryId,
                    CategoryName = model.CategoryName,
                    Description = model.Description,
                };
                context.CategoryMaster.Add(cat);
                context.SaveChanges();
                TempData["Error"] = "Record saved sucessfull!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = "Empty field cannot submit";
                return View(model);
            }
        }
        public ActionResult Delete(int? id)
        {
            var cat = context.CategoryMaster.SingleOrDefault(e => e.CategoryId == id);
            context.CategoryMaster.Remove(cat);
            context.SaveChanges(true);
            TempData["Error"] = "Record Deleted sucessfull!";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var cat = context.CategoryMaster.SingleOrDefault(e => e.CategoryId == id);
            var result = new CategoryMaster()
            {
                CategoryId = cat.CategoryId,
                CategoryName = cat.CategoryName,
                Description = cat.Description,
            };
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(CategoryMaster model) 
        {
            var data = context.CategoryMaster.FirstOrDefault(x => x.CategoryId == model.CategoryId);

            // Checking if any such record exist
            if (data != null)
            {
                data.CategoryName = model.CategoryName;
                data.Description = model.Description;
             
                context.SaveChanges(true);
                TempData["Error"] = "Record Edited sucessfull!";
                return RedirectToAction("Index");

         
            }
            else
            {
                TempData["Error"] = "Record Updation failed ";
                return View(); 
            }
                
        }


    }
}

    