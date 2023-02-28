using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    internal class ToDoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;
        private string _task;

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string Task
        {
            get { return _task; }
            set { _task = value; }
        }
        
    }
}
