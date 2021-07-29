using TaskListAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace TaskListAPI.Services
{
  public static class TaskService
  {
    static List<Task> Task { get; }
    static int nextId = 4;
    static TaskService()
    {
      Task = new List<Task>
            {
                new Task { Id = 1, Name = "Complete me!", IsComplete = false },
                new Task { Id = 2, Name = "Swipe me to the right ->", IsComplete = true },
                new Task { Id = 3, Name = "Swipe me to the left <-", IsComplete = false },
            };
    }

    public static List<Task> GetAll() => Task;

    public static Task Get(int Id) => Task.FirstOrDefault(p => p.Id == Id);

    public static void Add(Task NewTask)
    {
      NewTask.Id = nextId++;
      Task.Add(NewTask);
    }

    public static void Delete(int Id)
    {
      var DeletedTask = Get(Id);
      if (DeletedTask is null)
        return;

      Task.Remove(DeletedTask);
    }

    public static void Update(Task NewTask)
    {
      var index = Task.FindIndex(p => p.Id == NewTask.Id);
      if (index == -1)
        return;

      Task[index] = NewTask;
    }
  }
}