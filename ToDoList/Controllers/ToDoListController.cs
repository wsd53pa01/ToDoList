using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        public static List<ToDo> list = new List<ToDo>{
            new ToDo(1, 2, "CTI"),
            new ToDo(2, 1, "rpa"),
            new ToDo(3, 3, "申請")
        };
        public static List<ToDo> deletedList = new List<ToDo>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.List = list.OrderBy(s => s.Seq).ToList();
            ViewBag.DeletedList = deletedList.OrderBy(s => s.Seq).ToList();
            return View();
        }
        

        public IActionResult Edit(int _id)
        {
            var job = list.Where(s => s.Id == _id).FirstOrDefault();
            return View(job);
        }

        [HttpPost]
        public IActionResult Edit(ToDo job)
        {
            var editJob = list.Where(s => s.Id == job.Id).FirstOrDefault();
            editJob.Seq = job.Seq;
            editJob.Title = job.Title;

            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo job)
        {
            list.Add(job);

            return RedirectToAction("Index");
        }


        public IActionResult Delete(ToDo job)
        {
            var deletejob = list.Where(s => s.Id == job.Id).FirstOrDefault();
            list.Remove(deletejob);

            deletedList.Add(deletejob);

            return RedirectToAction("Index");
        }


        public IActionResult Details(int _id)
        {
            ToDo job = list.Where(s => s.Id == _id).FirstOrDefault();
            return View(job);
        }
    }
}
