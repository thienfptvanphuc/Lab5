using Lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Areas.system.Controllers
{
    [Area("system")]
    [Route("system/cate")]
    public class Cate : Controller
    {
        //public ShopContext db = new ShopContext();  =short code
        private readonly ShopContext db;
        public Cate(ShopContext context) {
            db = context;
        }

        [Route("index")]
        public IActionResult Index()
        { var list = db.Categories.ToList(); return View(list); }

        [Route("add")]
        public IActionResult Add() { return View(); }
        //add theo post
        [Route("add")][HttpPost]
        public IActionResult Add(Category Viewdata)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(Viewdata);
                db.SaveChanges();
                return RedirectToAction("index");
            } return View(Viewdata);
        }

        [Route("edit")]
        public IActionResult Edit(int? id)
        {
            if (id == null) { return RedirectToAction("index"); }
            var list = db.Categories.Find(id);
            if (list == null) { return RedirectToAction("index"); }
            return View(list); }

        //edit theo post
        [Route("edit")] [HttpPost]
        public IActionResult Edit(int? id, Category Viewdata)
        {
            if (id==Viewdata.Id)
            { if (ModelState.IsValid)
                { db.Categories.Update(Viewdata);
                  db.SaveChanges();
                  return RedirectToAction("index");
                }
            return View(Viewdata);
            }
            else { return RedirectToAction("index"); }
        }
        
    

                           [Route("delete")]
                            public IActionResult Delete(int id) 
                            {
                                var list = db.Categories.Find(id);
            
                                if (list!= null) {
                                    db.Categories.Remove(list);
                                    db.SaveChanges();
                                    return RedirectToAction("index");
                                }
                                else {return RedirectToAction("index");}
                            }


    }
}
