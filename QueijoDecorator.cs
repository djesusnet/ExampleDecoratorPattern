using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    //Concrete Decorator
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza)
            : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            string pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de queijo";
            return pizza;
        }
    }
}
