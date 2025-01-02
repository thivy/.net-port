using Microsoft.AspNetCore.Mvc;
using CardDemo.Models;

namespace CardDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            // Placeholder for getting transaction data
            return new List<Transaction>
            {
                new Transaction { Id = 1, AccountId = 1, Amount = 100, Date = DateTime.Now },
                new Transaction { Id = 2, AccountId = 2, Amount = 200, Date = DateTime.Now }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Transaction> Get(int id)
        {
            // Placeholder for getting a specific transaction by id
            var transaction = new Transaction { Id = id, AccountId = 1, Amount = 100, Date = DateTime.Now };
            return Ok(transaction);
        }

        [HttpPost]
        public ActionResult<Transaction> Post([FromBody] Transaction transaction)
        {
            // Placeholder for creating a new transaction
            transaction.Id = new Random().Next(1, 1000);
            return CreatedAtAction(nameof(Get), new { id = transaction.Id }, transaction);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Transaction transaction)
        {
            // Placeholder for updating an existing transaction
            transaction.Id = id;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Placeholder for deleting a transaction
            return NoContent();
        }
    }
}
