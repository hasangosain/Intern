using System;
using System.Collections.Generic;

class TaskQueue
{
    // Queue to store tasks
    private Queue<string> tasks = new Queue<string>();

    // Add a new task to the queue
    public void AddTask(string task)
    {
        tasks.Enqueue(task);
        Console.WriteLine($"Task '{task}' added to queue.");
    }

    // Process (remove) the next task in the queue
    public void ProcessTask()
    {
        if (tasks.Count > 0)
        {
            string currentTask = tasks.Dequeue();
            Console.WriteLine($"Processing task: {currentTask}");
        }
        else
        {
            Console.WriteLine("No tasks in the queue.");
        }
    }

    // Display all tasks in the queue
    public void ShowAllTasks()
    {
        Console.WriteLine("\n Current Tasks in Queue ");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task}");
        }
    }
}

class Program
{
    static void Main()
    {
        TaskQueue queue = new TaskQueue();

        // Adding tasks
        queue.AddTask("Send Email");
        queue.AddTask("Generate Report");
        queue.AddTask("Backup Database");

        // Display all tasks
        queue.ShowAllTasks();

        // Process tasks
        Console.WriteLine();
        queue.ProcessTask();
        queue.ProcessTask();

        // Show remaining tasks
        queue.ShowAllTasks();
    }
}
