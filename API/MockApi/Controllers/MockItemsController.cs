using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockApi.Models;

namespace MockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockItemsController : ControllerBase
    {
        private readonly MockContext _context;

        public MockItemsController(MockContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MockItemDTO>>> GetMockApiItems()
        {
            return await _context.MockItems
                .Select(item => ItemMockDTO(item))
               .ToListAsync();
        }

        // GET: api/MockItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MockItemDTO>> GetMockApiItem(long id)
        {
            var mockApiItem = await _context.MockItems.FindAsync(id);

            if (mockApiItem == null)
            {
                return NotFound();
            }

            return ItemMockDTO(mockApiItem);
        }

        // PUT: api/MockItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMockApiItem(long id, MockItemDTO mockItemDTO)
        {
            if (id != mockItemDTO.Id)
            {
                return BadRequest();
            }

            var mockItem = await _context.MockItems.FindAsync(id);
            
            if (mockItem == null)
            {
                return NotFound();
            }

            mockItem.Name = mockItemDTO.Name;
            mockItem.IsComplete = mockItemDTO.IsComplete;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MockItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MockItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MockItemDTO>> PostMockApiItem(MockItemDTO mockItemDTO)
        {
            var mockItem = new MockItem
            {
                Name = mockItemDTO.Name,
                IsComplete = mockItemDTO.IsComplete
            };

            _context.MockItems.Add(mockItem);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMockApiItem), new { id = mockItem.Id }, ItemMockDTO(mockItem));

        }

        // DELETE: api/MockItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMockItem(long id)
        {
            var mockApiItem = await _context.MockItems.FindAsync(id);

            if (mockApiItem == null)
            {
                return NotFound();
            }

            _context.MockItems.Remove(mockApiItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MockItemExists(long id)
        {
            return _context.MockItems.Any(e => e.Id == id);
        }
        
       private static MockItemDTO ItemMockDTO(MockItem mockItem) =>
       new MockItemDTO
       {
           Id = mockItem.Id,
           Name = mockItem.Name,
           IsComplete = mockItem.IsComplete
       };
    }
}
