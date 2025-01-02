using Microsoft.AspNetCore.Mvc;
using CardDemo.Models;

namespace CardDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ILogger<CardController> _logger;

        public CardController(ILogger<CardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Card> Get()
        {
            // Placeholder for getting card data
            return new List<Card>
            {
                new Card { Id = 1, Number = "1234-5678-9012-3456", ExpiryDate = "12/23" },
                new Card { Id = 2, Number = "9876-5432-1098-7654", ExpiryDate = "11/24" }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Card> Get(int id)
        {
            // Placeholder for getting a specific card by id
            var card = new Card { Id = id, Number = "1234-5678-9012-3456", ExpiryDate = "12/23" };
            return Ok(card);
        }

        [HttpPost]
        public ActionResult<Card> Post([FromBody] Card card)
        {
            // Placeholder for creating a new card
            card.Id = new Random().Next(1, 1000);
            return CreatedAtAction(nameof(Get), new { id = card.Id }, card);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Card card)
        {
            // Placeholder for updating an existing card
            card.Id = id;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Placeholder for deleting a card
            return NoContent();
        }
    }
}
