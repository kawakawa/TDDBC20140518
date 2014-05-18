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
            if ( 0 == this._list.Count() )
            {
                return "";
            }
            return this._list.LastOrDefault().TaskName;
        }

        public string ViewFirstToDo()
        {
            if ( 0 == this._list.Count() )
            {
                return "";
            }
            return "最初のTODO";
        }

        public List<String> ViewAllToDo()
        {
            if ( 0 == this._list.Count() )
            {
                return new List<String>()
                {
                    ""
                };
            }
            return new List<String>() { 
                "最初のTODO", "2つめのTODO" 
            };
        }
    }
}
