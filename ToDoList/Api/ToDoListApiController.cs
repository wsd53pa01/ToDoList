using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Api
{
    [Route("api/[controller]")]
    public class ToDoListApiController : ControllerBase
    {
        public static List<ToDo> list = new List<ToDo>{
            new ToDo() {Id= 1, Seq= 2, Title="CTI" },
            new ToDo() {Id= 2, Seq= 1, Title="rpa" },
            new ToDo() {Id= 3, Seq= 3, Title="申請" },
            new ToDo() {Id= 4, Seq= 0, Title="預算錯誤" }
        };

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ToDo> GetList()
        {
            return list;
        }

        // GET api/<controller>/5
        [HttpGet("detail/{id}")]
        public ToDo Get(int id)
        {
            var detailJob = list.Where(s => s.Id == id).FirstOrDefault();
            return detailJob;
        }

        // POST api/<controller>
        [HttpPost("create-to-do")]
        public IEnumerable<ToDo> Post([FromBody] ToDo newJob)
        {
            list.Add(newJob);
            return list;
        }

        // PUT api/<controller>/5
        [HttpPut("edit-to-do/{id}")]
        public IEnumerable<ToDo> Put([FromBody]ToDo newJob)
        {
            var editJob = list.Where(s => s.Id == newJob.Id).FirstOrDefault();
            editJob.Seq = newJob.Seq;
            editJob.Title = newJob.Title;
            return list;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IEnumerable<ToDo> Delete(int id)
        {
            var deletejob = list.Where(s => s.Id == id).FirstOrDefault();
            //list.Remove(deletejob);
            deletejob.Seq = 0;

            return list;
        }
    }
}
