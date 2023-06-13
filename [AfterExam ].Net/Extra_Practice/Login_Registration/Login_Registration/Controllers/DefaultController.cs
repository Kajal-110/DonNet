using Login_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Registration.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    WebApplicationEntities db = new WebApplicationEntities();
                    db.Products.Add(product);
                    db.SaveChanges();
                    TempData["Message"] = "Product Added Successfully";
                    return View();
                }
                else
                {
                    return View();
                }


            }
            catch (Exception e)
            {
                TempData["Message"] = "Product Added failed...." + e.Message;
                return View();
            }
           
        }

        //public ActionResult GetCategoryList(string SortOrder, string SortBy, int PageNumber = 1)
        //{
        //    WebApplicationEntities db = new WebApplicationEntities();



        //    ViewBag.SortOrder = SortOrder;
        //    ViewBag.SortBy = SortBy;

        //    var CategoryList = db.Products.ToList();

        //    ApplySorting(SortOrder, SortBy, CategoryList);

        //    CategoryList = ApplyPagination(CategoryList, PageNumber);

        //    ViewBag.count = (from Product in db.Products select Count(Id));

        //    CategoryList = CategoryList.Skip(5).Take(5).ToList();


        //    return View(CategoryList);
        //}

        public void ApplySorting(string SortOrder, string SortBy, IList<Product> CategoryList)
        {

            switch (SortBy)
            {
                case "Name":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    CategoryList = CategoryList.OrderBy(x => x.Name).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    CategoryList = CategoryList.OrderByDescending(x => x.Name).ToList();
                                    break;
                                }
                            default:
                                {
                                    CategoryList = CategoryList.OrderBy(x => x.Name).ToList();
                                    break;
                                }
                        }

                        break;
                    }
                case "Color":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    CategoryList = CategoryList.OrderBy(x => x.Color).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    CategoryList = CategoryList.OrderByDescending(x => x.Color).ToList();
                                    break;
                                }
                            default:
                                {
                                    CategoryList = CategoryList.OrderBy(x => x.Color).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        CategoryList = CategoryList.OrderBy(x => x.Name).ToList();
                        break;
                    }
            }

        }
       
        public List<Product> ApplyPagination(List<Product> CategoryList, int PageNumber)
        {
            ViewBag.TotalPages = Math.Ceiling(CategoryList.Count() / 5.0);
            ViewBag.PageNumber = PageNumber;
            CategoryList = CategoryList.Skip((PageNumber - 1) * 5).Take(5).ToList();
            return CategoryList;
        }

        //[HttpPost]
        //public ActionResult GetCategoryList(string searchText)
        //{
        //    WebApplicationEntities db = new WebApplicationEntities();
        //    var CategoryList = db.Products.ToList();

        //    if (searchText != null)
        //    {
        //        //CategoryList = db.Products.Where(x => x.Name.Equals(searchText) || x.Color.Contains(searchText)).ToList();

        //        CategoryList = db.Products.Where(x => x.Name.Equals(searchText)).ToList();
            
        //    }
        //        return View(CategoryList);
           

           
           
        //}
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult GetCategoryList(string searchText, string SortOrder, string SortBy, int PageNumber= 1)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;

            WebApplicationEntities db = new WebApplicationEntities();
            var CategoryList = db.Products.ToList();

            if (searchText != null)
            {
                //CategoryList = db.Products.Where(x => x.Name.Equals(searchText) || x.Color.Contains(searchText)).ToList();

                CategoryList = db.Products.Where(x => x.Name.Equals(searchText)).ToList();
                ApplySorting(SortOrder, SortBy, CategoryList);

                CategoryList = ApplyPagination(CategoryList, PageNumber);
            }
            else
            {
                ApplySorting(SortOrder, SortBy, CategoryList);

                CategoryList = ApplyPagination(CategoryList, PageNumber);
            }

            return View(CategoryList);
        }


        [HttpGet]
        public ActionResult Edit( int Id)
        {
            WebApplicationEntities db = new WebApplicationEntities();
            var editcategory =db.Products.Find(Id);
            
            return View(editcategory);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            WebApplicationEntities db = new WebApplicationEntities();
           

            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("GetCategoryList");
        }

        public ActionResult Delete( int Id)
        {
            WebApplicationEntities db = new WebApplicationEntities();

            var deletecategory = db.Products.Find(Id);
            db.Products.Remove(deletecategory);
            db.SaveChanges();
            return RedirectToAction("GetCategoryList");
        }
            //public ActionResult Create(string name, string desc)
            //{
            //    //Pass Data
            //    //View to controller 
            //    //controller to view
            //    ViewBag.Name = name;
            //    ViewBag.Desc = desc;
            //    return View();
            //}
        }
}