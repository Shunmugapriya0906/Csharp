using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task task1 = Task.Run(() => WorkMethod(2));
        Task task2 = Task.Run(() => WorkMethod(1));
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All tasks have completed");
    }
    static void WorkMethod(int taskNo)
    {        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Task {taskNo} is Running!!  Iteration {i}");
            Task.Delay(2000).Wait(); 
        }
    }
}
