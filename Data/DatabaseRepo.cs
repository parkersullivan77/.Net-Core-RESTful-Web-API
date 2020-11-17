using System;
using System.Collections.Generic;
using System.Linq;
using PizzaProblems.Modles;

namespace PizzaProblems.Data{


    public class DatabasesRepo : IPizzaRepo
    {
        private PizzaContext _context;

        public DatabasesRepo(PizzaContext context)
        {
            _context = context;
        }

        public void CreatePizza(Pizza p)
        {
            if(p == null){
                throw new ArgumentNullException(nameof(p));
            }
            _context.Pizzas.Add(p);
        }

        public void deletePizza(Pizza p){
           if (p ==null)
        {
            throw new NotImplementedException();
        }
            _context.Pizzas.Remove(p);
        }

        public Pizza GetPizzaById(int id)
        {
           return _context.Pizzas.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Pizza> GetPizzaTypes()
        {
            return _context.Pizzas.ToList();
        }

        public bool saveChanges()
        {
          return ( _context.SaveChanges() >= 0 );
        }

        public void updatePizza(Pizza p)
        {
            
        }
    }
}