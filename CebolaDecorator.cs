using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{

    //Concrete Decorator
    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza)
            : base(pizza)
        {
        }

        public override string BuscarTipoPizza()
        {
            string pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de cebola";
            return pizza;
        }
    }
}
