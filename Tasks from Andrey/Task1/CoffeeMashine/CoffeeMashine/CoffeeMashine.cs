using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    public abstract class CoffeeMashine : Coffee
    {
        public abstract void MakeCoffee(Coffee coffee);
        public abstract bool CheckUseFewAdditives { get;}
        public abstract void MakeCoffeeWithAdditives(Coffee coffee, string[] additivesArray);
    } 
}
