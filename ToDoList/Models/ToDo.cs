using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public int Seq { get; set; }
        public string Title { get; set; }

        public ToDo()
        {
            Id = 0;
            Seq = 0;
            Title = string.Empty;
        }

        public ToDo(int _id, int _seq, string _title)
        {
            Id = _id;
            Seq = _seq;
            Title = _title;
        }
    }
}
