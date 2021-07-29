using TaskListAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace TaskListAPI.Services
{
  public static class TaskService
  {
    static List<Task> Task { get; }
    static int nextId = 3;
    static TaskService()
    {
      Task = new List<Task>
            {
                new Task { Id = 1, Name = "Complete me", IsComplete = false },
                new Task { Id = 2, Name = "Swipe me", IsComplete = true }
            };
    }

    public static List<Task> GetAll() => Task;

    public static Task Get(int id) => Task.FirstOrDefault(p => p.Id == id);

    public static void Add(Task TodoItem)
    {
      TodoItem.Id = nextId++;
      Task.Add(TodoItem);
    }

    public static void Delete(int id)
    {
      var TodoItem = Get(id);
      if (TodoItem is null)
        return;

      Task.Remove(TodoItem);
    }

    public static void Update(Task TodoItem)
    {
      var index = Task.FindIndex(p => p.Id == TodoItem.Id);
      if (index == -1)
        return;

      Task[index] = TodoItem;
    }
  }
}