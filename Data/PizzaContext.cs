using Microsoft.EntityFrameworkCore;
using PizzaProblems.Modles;

namespace PizzaProblems.Data{
    
    public class PizzaContext : DbContext{
        
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
            
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}