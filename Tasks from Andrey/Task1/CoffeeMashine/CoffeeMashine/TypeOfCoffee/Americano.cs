using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    internal class Americano : Coffee
    {
        public override double timeMakeCoffee => 7;

        public override int coffeeTaste => 7;

        public override string coffeeTasteString => $"Американо имеет {Methods.CoffeeTaste(coffeeTaste)}, но на любителя";
    }
}
