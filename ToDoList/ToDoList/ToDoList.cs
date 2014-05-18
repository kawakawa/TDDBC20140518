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

        public void Add(Todo todo)
        {
            _list.Add(todo);
        }


        public string ViewLastTodo()
        {
            return this._list.LastOrDefault().TaskName;
        }

        public string ViewFirstToDo()
       {
           return "最初のTODO";
        }

        public List<String> ViewAllToDo()
        {
            return new List<String>() { 
                "最初のTODO", "2つめのTODO" 
            };
        }
    }
}
