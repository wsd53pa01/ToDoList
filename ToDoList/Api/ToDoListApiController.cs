using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ToDoList.Models;
using ToDoList.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Api
{
    [Route("api/[controller]")]
    public class ToDoListApiController : ControllerBase
    {
        private readonly ToDoRepository todoRepository;
        public ToDoListApiController(IConfiguration configuration)
        {
            todoRepository = new ToDoRepository(configuration);
        }
        
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ToDo> GetList()
        {
            return todoRepository.FindAll();
        }

        // GET api/<controller>/5
        [HttpGet("detail/{id}")]
        public ToDo Get(int id)
        {
            //var detailJob = list.Where(s => s.Id == id).FirstOrDefault();
            return todoRepository.FindByID(id);
        }

        // POST api/<controller>
        [HttpPost("create-to-do")]
        public IEnumerable<ToDo> Post([FromBody] ToDo job)
        {
            todoRepository.Add(job);
            return todoRepository.FindAll();
        }

        // PUT api/<controller>/5
        [HttpPut("edit-to-do/{id}")]
        public IEnumerable<ToDo> Put([FromBody]ToDo job)
        {
            todoRepository.Update(job);
            return todoRepository.FindAll();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IEnumerable<ToDo> Delete(int id)
        {
            todoRepository.Remove(id);
            return todoRepository.FindAll();
        }
    }
}
