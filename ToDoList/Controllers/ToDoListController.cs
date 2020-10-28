using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ToDoList.Models;
using ToDoList.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly ToDoRepository todoRepository;
        public ToDoListController(IConfiguration configuration)
        {
            todoRepository = new ToDoRepository(configuration);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(ToDo job)
        {
            return RedirectToAction("Index");
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo job)
        {
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
