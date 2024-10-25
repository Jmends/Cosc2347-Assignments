namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program.");
            List<String> taskList = new List<String>();
            String option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task");
                Console.WriteLine("Enter 2 to remove a task");
                Console.WriteLine("Enter 3 to view list");
                Console.WriteLine("Enter e to exit");

                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Enter a task");
                    String task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task successfully added");
                }
                else if (option == "2")
                {
                    Console.WriteLine("Which task would you like to remove?");
                    for(int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1 ) + ". " + taskList[i]);
                    }
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber - 1);

                    Console.WriteLine("New task List: ");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + taskList[i]);
                    }

                }
                else if(option == "3")
                {
                    Console.WriteLine("Current Tasks: ");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + taskList[i]);
                    }
                }
                else if(option == "e")
                {
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Console.WriteLine("Invalid option, try again");
                }
            }
            Console.WriteLine("Thanks for using this program!");
        }
    }
}
