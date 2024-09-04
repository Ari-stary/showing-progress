using System.Reflection.Metadata;

class ToDoList
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {

            showoptions();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        addtask();
                        break;
                    }

                case "2":
                    {
                        viewtask();
                        break;
                    }
                case "3":
                    {
                        deletetask();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Do you want to exit the script? y / n ");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "y" || answer == "yes")
                        {
                            Console.WriteLine("Oki baiii");
                            Environment.Exit(0);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    }


                default:
                    {
                        Console.WriteLine("Invalid choice, try again");
                        break;
                    }

            }
        }
    }

    static void showoptions()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Pick a option");
        Console.WriteLine("");
        Console.WriteLine("1. add task");
        Console.WriteLine("2. view tasks");
        Console.WriteLine("3. delete task");
        Console.WriteLine("4. exit program");
        Console.Write("Enter your choice: ");
    }
    static void addtask()
    {
        Console.Write("Enter discription of your task ");
        string task = Console.ReadLine();
        if (!string.IsNullOrEmpty(task))
        {
            tasks.Add(task);
            Console.WriteLine("Task added");
        }
        else
        {
            Console.WriteLine("Invalid text");
        }
    }
    static void viewtask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No Tasks available");
            return;
        }
        Console.WriteLine("\nYour tasks:");

        for (int i = 0; i < tasks.Count; i++)
           
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
    static void deletetask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available");
            return;
        }
        Console.WriteLine("Please pick the number of the task you want to delete.");
        viewtask();
        if (int.TryParse(Console.ReadLine(), out int tasknumber) && tasknumber > 0 && tasknumber <= tasks.Count)
        {
            tasks.RemoveAt(tasknumber - 1);
            Console.WriteLine("Task has been removed");
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
    }

}