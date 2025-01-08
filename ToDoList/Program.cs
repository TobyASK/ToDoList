
using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.WriteLine("\n=== To-Do List ===");
                Console.WriteLine("1. Ajouter une tâche");
                Console.WriteLine("2. Supprimer une tâche");
                Console.WriteLine("3. Afficher les tâches");
                Console.WriteLine("4. Quitter");
                Console.Write("Choisissez une option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Entrez la tâche à ajouter: ");
                        string task = Console.ReadLine();
                        taskManager.AddTask(task);
                        break;

                    case "2":
                        Console.Write("Entrez le numéro de la tâche à supprimer: ");
                        int taskNumber;
                        if (int.TryParse(Console.ReadLine(), out taskNumber))
                        {
                            taskManager.RemoveTask(taskNumber);
                        }
                        else
                        {
                            Console.WriteLine("Numéro de tâche invalide.");
                        }
                        break;

                    case "3":
                        taskManager.DisplayTasks();
                        break;

                    case "4":
                        Console.WriteLine("Au revoir!");
                        return;

                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }
            }
        }
    }
}
