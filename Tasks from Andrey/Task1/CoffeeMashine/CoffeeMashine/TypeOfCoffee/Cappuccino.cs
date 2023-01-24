using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    internal class Cappuccino : Coffee
    {
        public override double timeMakeCoffee => 6;

        public override int coffeeTaste => 9;
        public override string coffeeTasteString => $"Капучино имеет {Methods.CoffeeTaste(coffeeTaste)}, и его любят все";
        
    }
}
