using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoBackend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext todoContext;
        public TodoController(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        // GET: api/<TodoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return this.todoContext.Todos.Select(x=>x.Title).ToList(); // LINQ GET


            // Below - SP GET, can be used for insert / update
            string sql = "EXEC [dbo].[FetchItems] 999";
            var output = this.todoContext.TodoReadModels.FromSqlRaw<TodoReadModel>(sql).ToList();


            return output.Select(x=>x.Title).ToList();
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public async Task<int> Get(int id)
        {
            Todo todo = new Todo(Guid.NewGuid(), "Test2", false);
            await this.todoContext.Todos.AddAsync(todo); // LINQ ADD
            var tmp = await this.todoContext.SaveChangesAsync(); // DB ADD
            return tmp;
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
