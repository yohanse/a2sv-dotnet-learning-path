enum Catagories {
    Personal,
    Work,
    Errands,
}


class Task {
    public string Name {get; set;}
    public string Description {get; set;}
    public Catagories Catatgory {get; set;}
    public bool IsCompleted {get; set;}

    public override string ToString()
    {
        return $"{Name} {Description} {(int) Catatgory} {IsCompleted}";
    }
}


class TaskManager {
    public List<Task> Tasks;
    public TaskManager(){
        Tasks = new List<Task>();
    }
    public Task AddTask(Task task) {
        Tasks.Add(task);
        return task;
    }

    public void Display(List<Task>  Tasks){
        Console.WriteLine("All Tasks, we have currently.");
        Console.WriteLine("---------------------------------------------");
        foreach(Task task in Tasks){
            Console.WriteLine(task);
        }
    }

    public void Display(){
        Console.WriteLine("All Tasks, we have currently.");
        Console.WriteLine("---------------------------------------------");
        foreach(Task task in Tasks){
            Console.WriteLine(task);
        }
    }

    public void FilterUsingCatagory(Catagories catagory) {
        Display(Tasks.Where(task => task.Catatgory == catagory).ToList());
    }

    public async Task<bool> Writing(string filePath){
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Task task in Tasks)
            {
                // Write each row to the CSV file
                await writer.WriteLineAsync(task.ToString());
            }
        }
        return true;
    }
     
}