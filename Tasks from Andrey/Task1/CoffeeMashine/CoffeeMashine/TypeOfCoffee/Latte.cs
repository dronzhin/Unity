using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    internal class Latte : Coffee
    {
        public override double timeMakeCoffee => 5;

        public override int coffeeTaste => 5;
        public override string coffeeTasteString => $"Латте имеет {Methods.CoffeeTaste(coffeeTaste)}, но многие пьют";
    }
}
