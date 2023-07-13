using Machine_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Machine_test.Controllers
{
    public class ProductMasterController : Controller
    {
        private readonly TodoContext context;
        public ProductMasterController(TodoContext context)
        {
            this.context = context;

        }
        public ActionResult Index()
        {
            var products = (from p in context.ProductMaster
                            join c in context.CategoryMaster
                        on p.CategoryId equals c.CategoryId
                            select new
                            {
                                Id = p.ProductId,
                                Name = p.ProductName,
                                CatId = p.CategoryId,
                                Price = p.Price,
                                Description = p.Description,
                                CatName = c.CategoryName
                            }).ToList()
                      .Select(x => new ProductMaster()
                      {
                          ProductId = x.Id,
                          ProductName = x.Name,
                          CategoryId = x.CatId,
                          Price = x.Price,
                          Description = x.Description,
                
                          CategoryName = x.CatName
                      });
            return View(products.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            var data = from p in context.CategoryMaster
                       select new
                       {
                           CatID = p.CategoryId,
                           CatName = p.CategoryName
                       };

            SelectList list = new SelectList(data, "CatID", "CatName");
            ViewBag.Roles = list;

            return View(new ProductMaster());
        }

        [HttpPost]
        public ActionResult Create(ProductMaster model)
        {
            if (ModelState.IsValid)
            {
                context.ProductMaster.Add(model);
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
            var cat = context.ProductMaster.SingleOrDefault(e => e.ProductId == id);
            context.ProductMaster.Remove(cat);
            context.SaveChanges(true);
            TempData["Error"] = "Record Deleted sucessfull!";
            return RedirectToAction("Index");
            {
                ProductMaster student = context.ProductMaster.Find(id);
                return View(student);
            }
        }
       

        public ActionResult Edit(int id)
        {
            var data = from p in context.CategoryMaster
                       select new
                       {
                           CatID = p.CategoryId,
                           CatName = p.CategoryName
                       };

            SelectList list = new SelectList(data, "CatID", "CatName");
            ViewBag.Roles = list;

            ProductMaster ProductMaster = context.ProductMaster.Where(x => x.ProductId == id).SingleOrDefault();
            return View(ProductMaster);
        }


        [HttpPost]
        public ActionResult Edit(ProductMaster model)
        {
            ProductMaster student = context.ProductMaster.Where(x => x.ProductId == model.ProductId).SingleOrDefault();
            if (student != null)
            {
                context.Entry(student).CurrentValues.SetValues(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }


    }
}

