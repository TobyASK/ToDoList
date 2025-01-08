
using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    public class TaskManager
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine("Tâche ajoutée!");
        }

        public void RemoveTask(int taskNumber)
        {
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Tâche supprimée!");
            }
            else
            {
                Console.WriteLine("Numéro de tâche invalide.");
            }
        }

        public void DisplayTasks()
        {
            Console.WriteLine("\n=== Vos Tâches ===");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Aucune tâche disponible.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }
}
