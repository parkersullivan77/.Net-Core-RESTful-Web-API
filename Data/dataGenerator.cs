using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzaProblems.Modles;

namespace PizzaProblems.Data{
public class dataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PizzaContext(
            serviceProvider.GetRequiredService<DbContextOptions<PizzaContext>>()))
        {
            // Look for any board games.
            if (context.Pizzas.Any())
            {
                return;   // Data was already seeded
            }

            context.Pizzas.AddRange(
                new Pizza
                {
                    name = "Californian",
                    dough_type = "thick",
                    ingredients = "Chicken,Bacon,Cream Cheese,BBQ Sauce",
                    isCalzone = false
                    
                },
                new Pizza
                {
                    name = "Marg",
                    dough_type = "thin",
                    ingredients = "Cheese,Tomata,Basil",
                    isCalzone = false
                },
                new Pizza
                {
                    name = "Greek",
                    dough_type = "",
                    ingredients = "Fetta,olives,pepperchini",
                    isCalzone = true
                },
                new  Pizza
                {
                    name = "Shushi Pizza",
                    dough_type = "Thin",
                    ingredients = "Tuna,Spicy Ranch,Unagi",
                    isCalzone = false
                },
                new Pizza
                {
                    name = "Hawaiian",
                    dough_type = "thick",
                    ingredients = "Pineapple,Ham,Cheese",
                    isCalzone = false
                },
                new Pizza
                {
                    name = "Vegan",
                    dough_type = "thick",
                    ingredients = "Mushroom, Tomato,Garlic",
                    isCalzone = false
                });

            context.SaveChanges();
        }
    }
}
}