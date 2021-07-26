using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoItemAPI.Models;
using TodoItemAPI.Services;

namespace TodoItemAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TodoItemsController : ControllerBase
  {

    [HttpGet]
    public ActionResult<List<TodoItem>> GetAll() => TodoItemService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<TodoItem> Get(int id)
    {
      var TodoItem = TodoItemService.Get(id);

      if (TodoItem == null)
        return NotFound();

      return TodoItem;
    }

    [HttpPost]
    public IActionResult Create(TodoItem TodoItem)
    {
      TodoItemService.Add(TodoItem);
      return CreatedAtAction(nameof(Create), new { id = TodoItem.Id }, TodoItem);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, TodoItem TodoItem)
    {
      if (id != TodoItem.Id)
        return BadRequest();

      var existingTodoItem = TodoItemService.Get(id);
      if (existingTodoItem is null)
        return NotFound();

      TodoItemService.Update(TodoItem);

      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var TodoItem = TodoItemService.Get(id);

      if (TodoItem is null)
        return NotFound();

      TodoItemService.Delete(id);

      return NoContent();
    }
  }
}
