using Microsoft.AspNetCore.Mvc;
using CardDemo.Models;

namespace CardDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            // Placeholder for getting account data
            return new List<Account>
            {
                new Account { Id = 1, Name = "John Doe", Balance = 1000 },
                new Account { Id = 2, Name = "Jane Smith", Balance = 2000 }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Account> Get(int id)
        {
            // Placeholder for getting a specific account by id
            var account = new Account { Id = id, Name = "John Doe", Balance = 1000 };
            return Ok(account);
        }

        [HttpPost]
        public ActionResult<Account> Post([FromBody] Account account)
        {
            // Placeholder for creating a new account
            account.Id = new Random().Next(1, 1000);
            return CreatedAtAction(nameof(Get), new { id = account.Id }, account);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Account account)
        {
            // Placeholder for updating an existing account
            account.Id = id;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Placeholder for deleting an account
            return NoContent();
        }
    }
}
