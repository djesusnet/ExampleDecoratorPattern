using ExampleDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleDecoratorPattern
{

    //Concrete Decorator
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza)
            :base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            string pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de bacon";
            return pizza;
        }
    }
}
