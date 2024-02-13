
namespace TodoList
{
    internal class Todo
    {
        private string TodoText { get; set; }
        private bool IsCompleted { get; set; }

        public Todo(string todoText)
        {
            TodoText = todoText;
            IsCompleted = false;
        }


        public string ShowTodo()
        {
            return $"{TodoText} - Completed: {IsCompleted}";

        }


    }
}
