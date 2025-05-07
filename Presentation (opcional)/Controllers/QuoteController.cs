using Microsoft.AspNetCore.Mvc;
using Application.DTOs;
using Application.Interfaces;
using System.Collections.Generic;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _quoteService;

        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        // POST: api/quote/calculate
        [HttpPost("calculate")]
        public ActionResult<decimal> CalculateMonthlyPayment([FromBody] QuoteDto quoteDto)
        {
            if (quoteDto == null)
            {
                return BadRequest("Invalid quote data.");
            }

            var monthlyPayment = _quoteService.CalculateMonthlyPayment(quoteDto);
            return Ok(monthlyPayment);
        }

        // POST: api/quote
        [HttpPost]
        public ActionResult<QuoteDto> CreateQuote([FromBody] QuoteDto quoteDto)
        {
            if (quoteDto == null)
            {
                return BadRequest("Invalid quote data.");
            }

            var createdQuote = _quoteService.CreateQuote(quoteDto);
            return CreatedAtAction(nameof(GetQuotesByClient), new { clientId = createdQuote.ClientId }, createdQuote);
        }

        // GET: api/quote/client/{clientId}
        [HttpGet("client/{clientId}")]
        public ActionResult<IEnumerable<QuoteDto>> GetQuotesByClient(int clientId)
        {
            var quotes = _quoteService.GetQuotesByClient(clientId);
            return Ok(quotes);
        }
    }
}