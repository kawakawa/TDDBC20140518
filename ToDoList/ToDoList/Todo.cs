using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Todo
    {

        private string _taskName;

        public Todo(string taskName)
        {
            this._taskName = taskName;
        }

        public string TaskName
        {
            get
            {
                return this._taskName;
            }
        }
    }
}
