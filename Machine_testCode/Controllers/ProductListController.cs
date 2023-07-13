using Machine_test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Machine_test.Controllers
{
    public class ProductList : Controller

    {
        private readonly TodoContext entities;

        public ProductList(TodoContext context)
        {
            entities = context;
        }

        public ActionResult Index()
        {
            return View(this.GetCustomers(1));
        }
   
            
        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetCustomers(currentPageIndex));
        }

        private ProductListsModel GetCustomers(int currentPage)
        {
            int maxRows = 10;
             
                ProductListsModel productList = new ProductListsModel();


            productList.ProductData = (from Prod in entities.ProductMaster join Cat in entities.CategoryMaster on Prod.CategoryId equals Cat.CategoryId
                                          select  new Products { ProductId=Prod.ProductId, ProductName=Prod.ProductName, CategoryId=Cat.CategoryId, CategoryName=Cat.CategoryName })
                        .OrderBy(Prod => Prod.ProductId)
                        .Skip((currentPage - 1) * maxRows)
                        .Take(maxRows).ToList();

            double pageCount = (double)((decimal)entities.ProductMaster.Count() / Convert.ToDecimal(maxRows));
                productList.PageCount = (int)Math.Ceiling(pageCount);

            productList.CurrentPageIndex = currentPage;
            
                return productList;

            
            }
        }
    }


