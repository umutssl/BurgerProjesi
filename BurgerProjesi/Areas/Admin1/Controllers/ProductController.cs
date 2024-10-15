﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerProjesi.Context;
using BurgerProjesi.Entities;

namespace BurgerProjesi.Areas.Admin1.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Admin1/Product
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem>values=(from x in context.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text=x.CategoryName,
                                            Value=x.CategoryID.ToString(),
                                        }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public ActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            var value=context.Products.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value = context.Products.Find(product.ProductID);
            value.ProductName = product.ProductName;
            value.ImageUrl = product.ImageUrl;
            value.Description = product.Description;
            value.Price = product.Price;
            value.CategoryID = product.CategoryID;
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }

    }
}