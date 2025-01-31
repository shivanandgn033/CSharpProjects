using System;
using System.Collections.Generic;

class ToDoList
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string input;

        Console.WriteLine("Welcome to the to-do list!");

        do
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Finish");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("New task: ");
                    tasks.Add(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("\nYour tasks:");
                    if (tasks.Count == 0)
                        Console.WriteLine("No tasks found.");
                    else
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                    break;
            }
        } while (input != "3");

        Console.WriteLine("Program ended.");
    }
}