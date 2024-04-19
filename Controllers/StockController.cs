using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Config;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [Route("api/v1/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        
    private readonly ApplicationDbContext applicationDbContext;

    public StockController(ApplicationDbContext dbContext){
        applicationDbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetAllStocks(){
        List<Models.Stocks> stocks = applicationDbContext.Stocks.ToList();
        return Ok(stocks);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id){

        var stocks = applicationDbContext.Stocks.Find(id);
        if(stocks == null){
            return NotFound();
        }
        return Ok(stocks);
    }
    }
}