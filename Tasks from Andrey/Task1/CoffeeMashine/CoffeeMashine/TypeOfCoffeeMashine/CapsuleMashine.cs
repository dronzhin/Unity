using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    public class CapsuleMashine : CoffeeMashine
    {
        public override double timeMakeCoffee => 0.7;

        public override int coffeeTaste => 5;

        public override void MakeCoffee(Coffee coffee)
        {
            Console.WriteLine(coffee.coffeeTasteString);
            Console.WriteLine($"Капсульная кофемашина варит кофе " +
                $"за {timeMakeCoffee * coffee.timeMakeCoffee} минут и имеет {Methods.CoffeeTaste(coffeeTaste)}");
        }
    }
}
