using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Display(Name = "Job Piority")]
        public int Seq { get; set; }

        [Display(Name = "Job Title")]
        public string Title { get; set; }
    }
}
