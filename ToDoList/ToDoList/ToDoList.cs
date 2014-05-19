using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBC
{
    public static class ListUtil
    {
        public static void Swap<T>(List<T> list, int index1, int index2 )
        {
            T tmp = list[index2];
            list[index2] = list[index1];
            list[index1] = tmp;
        }
    }

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

        public void Add( Todo todo )
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

        public void DeleteFirstToDo()
        {
            if ( !this.hasNoToDo() )
            {
                this._list.Remove( this._list.FirstOrDefault() );
            }
        }

        public void DeleteLastToDo()
        {
            if ( !this.hasNoToDo() )
            {
                this._list.Remove( this._list.LastOrDefault() );
            }
        }

        public void DeleteAllToDo()
        {
            if ( !this.hasNoToDo() )
            {
                this._list.Clear();
            }
        }

        public void SwapToDo( int todoIndex1, int todoIndex2 )
        {
            ListUtil.Swap( this._list, todoIndex1 - 1, todoIndex2 - 1 );
        }
    }
}
