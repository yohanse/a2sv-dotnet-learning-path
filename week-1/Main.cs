using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
class Program
{
    static async System.Threading.Tasks.Task Main()
    {
        TaskManager taskManager = new TaskManager
        {
            Tasks = {
                new Task{Name="Coffee", IsCompleted=true, Catatgory=Catagories.Personal, Description="Nothing"},
                new Task{Name="Tea", IsCompleted=false, Catatgory=Catagories.Work, Description="Nothing"},
                new Task{Name="Burger", IsCompleted=true, Catatgory=Catagories.Errands, Description="Nothing"},
                new Task{Name="Pizza", IsCompleted=true, Catatgory=Catagories.Personal, Description="Nothing"},
                }
        };
        string filePath = "tasks.csv";

        // Write data to CSV file asynchronously
        await taskManager.Writing(filePath);

        Console.WriteLine("CSV file written successfully.");
        taskManager.Display();
        Console.WriteLine("--------------------------------------------");
        taskManager.FilterUsingCatagory(Catagories.Personal);
        
    }
}