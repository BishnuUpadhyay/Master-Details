using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Master.Data;
using Master.Models;

namespace Master.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleInvoiceApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SaleInvoiceApiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SaleInvoiceApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleInvoiceDTO>>> GetSaleInvoiceDTO()
        {
          if (_context.SaleInvoiceDTO == null)
          {
              return NotFound();
          }
            return await _context.SaleInvoiceDTO.ToListAsync();
        }

        // GET: api/SaleInvoiceApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleInvoiceDTO>> GetSaleInvoiceDTO(int id)
        {
          if (_context.SaleInvoiceDTO == null)
          {
              return NotFound();
          }
            var saleInvoiceDTO = await _context.SaleInvoiceDTO.FindAsync(id);

            if (saleInvoiceDTO == null)
            {
                return NotFound();
            }

            return saleInvoiceDTO;
        }

        // PUT: api/SaleInvoiceApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleInvoiceDTO(int id, SaleInvoiceDTO saleInvoiceDTO)
        {
            if (id != saleInvoiceDTO.Id)
            {
                return BadRequest();
            }

            _context.Entry(saleInvoiceDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleInvoiceDTOExists(id))
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

        // POST: api/SaleInvoiceApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleInvoiceDTO>> PostSaleInvoiceDTO(SaleInvoiceDTO saleInvoiceDTO)
        {
          if (_context.SaleInvoiceDTO == null)
          {
              return Problem("Entity set 'AppDbContext.SaleInvoiceDTO'  is null.");
          }
            _context.SaleInvoiceDTO.Add(saleInvoiceDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleInvoiceDTO", new { id = saleInvoiceDTO.Id }, saleInvoiceDTO);
        }

        // DELETE: api/SaleInvoiceApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleInvoiceDTO(int id)
        {
            if (_context.SaleInvoiceDTO == null)
            {
                return NotFound();
            }
            var saleInvoiceDTO = await _context.SaleInvoiceDTO.FindAsync(id);
            if (saleInvoiceDTO == null)
            {
                return NotFound();
            }

            _context.SaleInvoiceDTO.Remove(saleInvoiceDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleInvoiceDTOExists(int id)
        {
            return (_context.SaleInvoiceDTO?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
