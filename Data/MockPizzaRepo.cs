using System.Collections.Generic;
using PizzaProblems.Modles;

namespace PizzaProblems.Data{
    public class MockPizzaRepo : IPizzaRepo
    {
        public void CreatePizza(Pizza p)
        {
            throw new System.NotImplementedException();
        }

        public void deletePizza(Pizza p)
        {
            throw new System.NotImplementedException();
        }

        public Pizza GetPizzaById(int id)
        {
            return new Pizza{name = "chickenbutt",dough_type = "crusty",isCalzone = false,ingredients = "chicken,butts"};
        }

        public IEnumerable<Pizza> GetPizzaTypes()
        {
            var pizzas = new List<Pizza>{
            new Pizza{name = "chicken",dough_type = "crusty",isCalzone = false,ingredients ="chicken"},
            new Pizza{name = "butter",dough_type = "noice",isCalzone = false,ingredients ="sauce"},
            };
            return pizzas;
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void updatePizza(Pizza p)
        {
            throw new System.NotImplementedException();
        }
    }
}
