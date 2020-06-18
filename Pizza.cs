using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza =  "Esta é uma Pizza normal";
            return pizza;
        }
    }
}
