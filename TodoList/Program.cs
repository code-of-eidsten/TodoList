//HVA SKAL PROGRAMMET GJØRE?
// - Liste opp aktive todos
// - Legge til Todo
// - Stryke ut eller fjerne gjorte todos
// - Dele opp infotekst i flere funksjoner -- kanskje en egen class for infotext funksjonene? Eller blir det bare knot kanskje

//HVILKE KLASSER TRENGS?
// Todo, Todolist 



using TodoList;

var TodoList = new TodoList.TodoList();
var info = new InfoTexts(TodoList);
info.AddModeText();
info.ShowTodoListText();
