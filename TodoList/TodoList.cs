
namespace TodoList
{
    internal class TodoList
    {
        public List<Todo> AllTodos { get; set; } = new List<Todo>();

        //add to list
        public void AddTodoToList(Todo todo)
        {
            AllTodos.Add(todo);
        }

        //show list
        public void ShowTodoList()
        {
            foreach (var todo in AllTodos)
            {
                Console.WriteLine(todo.ShowTodo());
            }
        }

        //remove from list 
        public void RemoveTodoFromList(int todoId)
        {
            AllTodos.RemoveAt(todoId);
            
        }
    }
}
