using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    //Base Decorator
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this._pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
            var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
    }
}
