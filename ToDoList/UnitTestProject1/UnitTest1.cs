using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBC;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 何もTODOを入れないと最後に入れたTODOが空っぽ()
        {
            var todoList = new ToDoList();
            todoList.ViewLastTodo().Is( "" );
        }

        [TestMethod]
        public void 何もTODOを入れないと最初に入れたTODOが空っぽ()
        {
            var todoList = new ToDoList();
            todoList.ViewFirstToDo().Is( "" );
        }

        [TestMethod]
        public void 何もTODOを入れないとTODO一覧が空っぽ()
        {
            var todoList = new ToDoList();
            todoList.ViewAllToDo().Is( "" );
        }

        [TestMethod]
        public void ToDoを１つ足して最後のToDoが取得できる()
        {
            var sut = new TDDBC.ToDoList();
            sut.Add(new Todo("最後のTODO"));
            sut.ViewLastTodo().Is("最後のTODO");
        }

        [TestMethod]
        public void ToDoを１つ足して最初のToDoが取得できる()
        {
            var sut = new TDDBC.ToDoList();
            sut.Add(new Todo("最初のTODO"));
            sut.ViewFirstToDo().Is("最初のTODO");
        }

        [TestMethod]
        public void ToDoを１つ足して全部のToDoが取得できる()
        {
            var sut = new TDDBC.ToDoList();
            sut.Add(new Todo("TODO一覧"));
            sut.ViewAllToDo().Is("TODO一覧");
        }


        [TestMethod]
        public void ToDoを2つ足して最後のToDoが取得できる()
        {
            var todoList = new TDDBC.ToDoList();
            todoList.Add(new Todo("最初のTODO"));
            todoList.Add(new Todo("2つめのTODO"));
            todoList.ViewLastTodo().Is("2つめのTODO");
        }


        [TestMethod]
        public void Todoを2つ足して最初のToDoが取得できる()
        {
            var sut = new TDDBC.ToDoList();
            sut.Add(new Todo("最初のTODO"));
            sut.Add(new Todo("2つめのTODO"));
            sut.ViewFirstToDo().Is("最初のTODO");
            
        }

        [TestMethod]
        public void 追加したToDoをすべて見られる()
        {
            var sut = new TDDBC.ToDoList();
            sut.Add(new Todo("最初のTODO"));
            sut.Add(new Todo("2つめのTODO"));
            sut.ViewAllToDo().Is("最初のTODO", "2つめのTODO");
        }

        [TestMethod]
        public void 最初に追加したTODOを削除できる()
        {
            var todoList = new ToDoList();
            todoList.Add( new Todo( "First_TODO" ) );
            todoList.Add( new Todo( "Second_TODO" ) );
            todoList.DeleteFirstToDo();
            todoList.ViewAllToDo().Is( "Second_TODO" );
        }

        [TestMethod]
        public void 最後に追加したTODOを削除できる()
        {
            var todoList = new ToDoList();
            todoList.Add( new Todo( "First_TODO" ) );
            todoList.Add( new Todo( "Second_TODO" ) );
            todoList.DeleteLastToDo();
            todoList.ViewAllToDo().Is( "First_TODO" );
        }

        [TestMethod]
        public void 追加したTODOを全て削除できる()
        {
            var todoList = new ToDoList();
            todoList.Add( new Todo( "First_TODO" ) );
            todoList.Add( new Todo( "Second_TODO" ) );
            todoList.DeleteAllToDo();
            todoList.ViewAllToDo().Is( "" );            
        }

        [TestMethod]
        public void TODOの順序を入れ替えられる()
        {
            var todoList = new ToDoList();
            todoList.Add( new Todo( "First_TODO" ) );
            todoList.Add( new Todo( "Second_TODO" ) );
            todoList.SwapToDo( 1, 2 );
            todoList.ViewAllToDo().Is( "Second_TODO", "First_TODO" );
        }
    }
}
