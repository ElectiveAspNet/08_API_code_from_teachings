using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi.Model.Entities;
using WepApi.Models;

namespace WepApi.Controllers
{
    [Produces("application/json")]

    [Route("api/Todos")]
    public class TodosController : Controller
    {

        WepApiContext _db;

        public TodosController(WepApiContext db)
        {
            _db = db;
        }

        List<TodoItem> _todos = new List<TodoItem>();

        [HttpGet]
        public IActionResult Get()
        {
            // _todos.Add(new TodoItem {TodoItemId=1, Task = "Middag med Helle", IsCompleted = false });    
            return new OkObjectResult(_db.TodoItem);
        }
        [HttpPost]
        public IActionResult Post(TodoItem todoItem)
        {
            _db.Add(todoItem);
            _db.SaveChanges();
            return new CreatedAtRouteResult("GetTodoItem", new { id = todoItem.TodoItemId }, todoItem);
        }



        // HTTP Protokol
        // GET
        // POST

        // PUT

        // DELETE

    }
}