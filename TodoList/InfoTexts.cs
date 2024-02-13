using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class InfoTexts
    {
        TodoList _todoList;

        public InfoTexts(TodoList todoList)
        {
            _todoList = todoList;
        }
        public void AddModeText()
        {
            var addModeOn = true;
            while (addModeOn)
            {
                Console.WriteLine("Type in your thing to do: ");
                var userInput = Console.ReadLine();

                var todo = new Todo(userInput);
                _todoList.AddTodoToList(todo);
                Console.WriteLine("Want to add more? y/n");
                var AddMore = Console.ReadLine();
                if (AddMore == "y") { continue; }
                else if (AddMore == "n") { addModeOn = false; }
                else { Console.WriteLine("Something went wrong. lets start over."); continue; }
            }
        }

        public void ShowTodoListText()
        {
            var listModeOn = true;
            while (listModeOn)
            {
                Console.WriteLine("addmode off");
                Console.WriteLine("Here is your Todo List:");
                _todoList.ShowTodoList();
                Console.WriteLine("Do you want to remove a todo? Type ID number.");
                var input = Console.ReadLine();
                var todoToRemove = Int32.Parse(input);
                _todoList.RemoveTodoFromList(todoToRemove - 1);
                _todoList.ShowTodoList();
                Console.WriteLine("Do you want to remove more?");
                var removeMore = Console.ReadLine();
                if (removeMore == "y") { continue; }
                else if (removeMore == "n") { listModeOn = false; }
                else { Console.WriteLine("Something went wrong. lets start over."); continue; }
            }


        }
    }
}
