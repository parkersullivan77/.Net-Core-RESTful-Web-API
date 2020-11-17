using System.Collections.Generic;
using PizzaProblems.Modles;

namespace PizzaProblems.Data{
    public interface IPizzaRepo{
        IEnumerable<Pizza> GetPizzaTypes();
        Pizza GetPizzaById(int id);
        void CreatePizza(Pizza p);
        void updatePizza(Pizza p);
        void deletePizza(Pizza p);
        bool saveChanges();
    }
}