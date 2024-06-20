using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Просмотреть задачи");
            Console.WriteLine("2. Добавить задачу");
            Console.WriteLine("3. Удалить задачу");
            Console.WriteLine("4. Редактировать задачу");
            Console.WriteLine("5. Выйти");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewTasks();
                    break;
                case 2:
                    AddTask();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    EditTask();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Введите новую задачу: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("Задача добавлена.");
    }

    static void DeleteTask()
    {
        ViewTasks();
        if (tasks.Count > 0)
        {
            Console.Write("Введите номер задачи для удаления: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Задача удалена.");
            }
            else
            {
                Console.WriteLine("Некорректный номер задачи.");
            }
        }
    }

    static void EditTask()
    {
        ViewTasks();
        if (tasks.Count > 0)
        {
            Console.Write("Введите номер задачи для редактирования: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                Console.Write("Введите новый текст задачи: ");
                string newTaskText = Console.ReadLine();
                tasks[taskNumber - 1] = newTaskText;
                Console.WriteLine("Задача отредактирована.");
            }
            else
            {
                Console.WriteLine("Некорректный номер задачи.");
            }
        }
    }
}
