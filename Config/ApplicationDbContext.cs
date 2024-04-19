using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Config
{
    public class ApplicationDbContext : DbContext
    {
        
       public ApplicationDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
       {

       }

       public DbSet<Stocks> Stocks {get; set;}

       public DbSet<Comments> Comments {get; set;}
    }
}