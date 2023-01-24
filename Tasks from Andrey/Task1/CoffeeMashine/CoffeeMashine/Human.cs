using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    public class Human
    {
        public void MakeCoffee(CoffeeMashine coffeeMashine, Coffee coffee)
        {
            coffeeMashine.MakeCoffee(coffee);
        }
        public void MakeCoffeeWithAdditives(CoffeeMashine coffeeMashine, Coffee coffee, string[] coffeeAdditives)
        {
            coffeeMashine.MakeCoffeeWithAdditives(coffee, coffeeAdditives);
        }
    }
}
