using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoffeeMashine
{
    public abstract class Coffee
    {
        public abstract double timeMakeCoffee { get; }
        public abstract int coffeeTaste { get; }
        public virtual string coffeeTasteString { get; }

    }
}
