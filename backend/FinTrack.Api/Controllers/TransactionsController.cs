using Microsoft.AspNetCore.Mvc;
using FinTrack.Api.Models;

namespace FinTrack.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    private static readonly List<Transaction> Transactions = new();

    [HttpGet]
    public ActionResult<List<Transaction>> GetAll()
    {
        return Ok(Transactions);
    }

    [HttpPost]
    public ActionResult<Transaction> Create(Transaction transaction)
    {
        transaction.Id = Transactions.Count + 1;
        Transactions.Add(transaction);

        return Ok(transaction);
    }
}