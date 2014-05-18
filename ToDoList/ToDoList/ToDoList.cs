using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBC
{
    public class ToDoList
    {

        private List<Todo> _list = new List<Todo>();

        private bool hasNoToDo()
        {
            if (this._list.Count ==0)
            {
                return true;
            }

            return false;
        }



        public void Add(Todo todo)
        {
            _list.Add(todo);
        }


        public string ViewLastTodo()
        {
            if ( this.hasNoToDo() )
            {
                return "";
            }
            return this._list.LastOrDefault().TaskName;
        }

        public string ViewFirstToDo()
        {
            if (this.hasNoToDo())
            {
                return "";
            }
            return this._list.FirstOrDefault().TaskName;
        }

        public List<String> ViewAllToDo()
        {
            if (this.hasNoToDo())
            {
                return new List<String>()
                {
                    ""
                };
            }
            return this._list.Select(n => n.TaskName).ToList();
        }
    }
}
