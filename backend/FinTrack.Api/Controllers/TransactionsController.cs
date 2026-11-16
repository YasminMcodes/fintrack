using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinTrack.Api.Models;
using FinTrack.Api.Data;

namespace FinTrack.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    private readonly AppDbContext _context;
        public TransactionsController(AppDbContext context)
    {
        _context = context;
    }       

    [HttpGet]
    public async Task<ActionResult<List<Transaction>>> GetAll()
    {
        var transactions = await _context.Transactions.ToListAsync();

        return Ok(transactions);
    }

    [HttpPost]
    public async Task<ActionResult<Transaction>> Create(Transaction transaction)
    {
        _context.Transactions.Add(transaction);

        await _context.SaveChangesAsync();

        return Ok(transaction);
    }
}