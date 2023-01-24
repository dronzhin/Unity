using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    public class CarobCoffeeMachine : CoffeeMashine
    {
        public override double timeMakeCoffee => 1.2;

        public override int coffeeTaste => 9;

        public override bool CheckUseFewAdditives => true;
        public override void MakeCoffee(Coffee coffee)
        {
            Console.WriteLine(coffee.coffeeTasteString);
            Console.WriteLine($"Рожковая кофемашина варит кофе " +
                $"за {timeMakeCoffee * coffee.timeMakeCoffee} минут и имеет {Methods.CoffeeTaste(coffeeTaste)}");
        }

        public override void MakeCoffeeWithAdditives(Coffee coffee, string[] additivesArray)
        {
            Console.WriteLine($"Добрый день, Вы выбрали кофе: \n{coffee.coffeeTasteString} \nC добавками:" +
                $"\n {string.Join(" ", additivesArray)}" +
                $"\nМы вам сварим кофе на Рожковой кофемашине" +
                $"\nза {timeMakeCoffee * coffee.timeMakeCoffee} минут" +
                $"\nКофе на этой машине имеет {Methods.CoffeeTaste(coffeeTaste)}");
        }
    }
}
