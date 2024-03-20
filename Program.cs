

void AppStartPack()
{
    Console.WriteLine("Hello!\r\nWhat do you want to do?\r\n[S]ee all TODOs\r\n[A]dd a TODO\r\n[R]emove a TODO\r\n[E]xit\r\n");
}



List<string> ToDoList = new List<string>();


bool SwitchController = false;

do
{
    AppStartPack();
    string UserChoise = Console.ReadLine();

    switch (UserChoise.ToUpper())
    {
        case "S":
            Console.WriteLine("All todos");
            for(int i=0; i<ToDoList.Count();i++) {  Console.WriteLine(i+1+"."   + " "+ ToDoList[i]); }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            break;
        case "A":
            Console.WriteLine("Enter the TODO description:");
            string AddToList= Console.ReadLine();
            while (string.IsNullOrWhiteSpace(AddToList) || ToDoList.Contains(AddToList)){
                Console.WriteLine("Descriptiption must be unique.");
                Console.WriteLine("Enter the TODO description:");
                AddToList = Console.ReadLine();
            }
            ToDoList.Add(AddToList);
            Console.WriteLine($"TODO successfully added: {AddToList}");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            break;
        case "R":
            Console.WriteLine("Select the index of the TODO you want to remove:");
            int DeleteToDo=int.Parse(Console.ReadLine());
            if (ToDoList.Count() == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                break;
            }
            while (DeleteToDo > ToDoList.Count()) {
                Console.WriteLine("The given index is not valid.");
                DeleteToDo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"TODO removed: {ToDoList[DeleteToDo - 1]}");
            ToDoList.Remove(ToDoList[DeleteToDo-1]);
            break;
        case "E":
            Console.WriteLine("Exit");
            SwitchController = true;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;

    }

}
while (!SwitchController);

Console.WriteLine("Çıktı");

Console.ReadLine();