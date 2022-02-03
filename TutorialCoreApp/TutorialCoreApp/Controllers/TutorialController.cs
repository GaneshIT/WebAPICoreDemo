using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialCoreApp.Models;

//http web methods/verbs: HTTPPOST,HTTPGET,HTTPPUT,HTTPPATCH,HTTPDELETE 
namespace TutorialCoreApp.Controllers
{
    public class TutorialController : Controller
    {
        TutorialDbContext _tutorialDbContext;
        public TutorialController(TutorialDbContext tutorialDbContext)
        {
            _tutorialDbContext = tutorialDbContext;
        }
        public IActionResult Index()
        {
            var tutorialInfo = _tutorialDbContext.tutorial.ToList();//select * from tutorial
            return View(tutorialInfo); // return index.cshtml
        }
        public IActionResult InsertTutorial()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult InsertTutorial(Tutorial tutorial)
        {
            _tutorialDbContext.tutorial.Add(tutorial);//insert into tutorial values(tutorial.id,tutorial.name)
            _tutorialDbContext.SaveChanges();
            ViewBag.message = "Tutorial details saved successfully!";
            return View();

            ////update
            //_tutorialDbContext.Entry(tutorial).State = EntityState.Modified;
            //_tutorialDbContext.SaveChanges();

            ////delete
            //_tutorialDbContext.Entry(tutorial).State = EntityState.Deleted;
            //_tutorialDbContext.SaveChanges();

            ////find the row
            //var tutorialrecord = _tutorialDbContext.tutorial.Find(134);
        }
        public IActionResult UpdateTutorial()
        {
            return View();
        }
        public IActionResult DeleteTutorial()
        {
            return View();
        }

    }
}

//EntityFrameworkCore
//1. Code first approach model
//2.  Database first approach model

//ORM - Object Relational Mapping.
