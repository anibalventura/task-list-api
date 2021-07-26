using TodoItemAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace TodoItemAPI.Services
{
  public static class TodoItemService
  {
    static List<TodoItem> TodoItems { get; }
    static int nextId = 3;
    static TodoItemService()
    {
      TodoItems = new List<TodoItem>
            {
                new TodoItem { Id = 1, Name = "Complete me", IsComplete = false },
                new TodoItem { Id = 2, Name = "Swipe me", IsComplete = true }
            };
    }

    public static List<TodoItem> GetAll() => TodoItems;

    public static TodoItem Get(int id) => TodoItems.FirstOrDefault(p => p.Id == id);

    public static void Add(TodoItem TodoItem)
    {
      TodoItem.Id = nextId++;
      TodoItems.Add(TodoItem);
    }

    public static void Delete(int id)
    {
      var TodoItem = Get(id);
      if (TodoItem is null)
        return;

      TodoItems.Remove(TodoItem);
    }

    public static void Update(TodoItem TodoItem)
    {
      var index = TodoItems.FindIndex(p => p.Id == TodoItem.Id);
      if (index == -1)
        return;

      TodoItems[index] = TodoItem;
    }
  }
}