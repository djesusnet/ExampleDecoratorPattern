using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    //Concrete Decorator
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza)
            : base(pizza)
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