using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToDoを１つ足してそのToDoが取得できる()
        {
            var sut = new ToDoList.ToDoList();
            sut.Add(new Todo("最初のTODO"));
            sut.ViewLastTodo().Is("最初のTODO");
        }

        [TestMethod]
        public void ToDoを2つ足して最後のToDoが取得できる()
        {
            var todoList = new ToDoList.ToDoList();
            todoList.Add(new Todo("最初のTODO"));
            todoList.Add(new Todo("2つめのTODO"));
            todoList.ViewLastTodo().Is("2つめのTODO");
        }


        [TestMethod]
        public void Todoを2つ足して最初のToDoが取得できる()
        {
            var sut = new ToDoList.ToDoList();
            sut.Add(new Todo("最初のTODO"));
            sut.Add(new Todo("2つめのTODO"));
            sut.ViewFirstToDo().Is("最初のTODO");
            
        }

        [TestMethod]
        public void 追加したToDoをすべて見られる()
        {
            var sut = new ToDoList.ToDoList();
            sut.Add(new Todo("最初のTODO"));
            sut.Add(new Todo("2つめのTODO"));
            sut.ViewAllToDo().Is("最初のTODO", "2つめのTODO");
        }
    }
}
