using System;

namespace DecoratorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> component = new ConcreteComponent();
            Console.WriteLine(component.GetText());

            IComponent<string> plainDecorator = new PlainDecorator(component);
            Console.WriteLine(plainDecorator.GetText());

            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(plainDecorator);
            Console.WriteLine(upperCaseDecorator.GetText());

            IComponent<string> colorDecorator = new ColorDecorator(upperCaseDecorator);
            Console.WriteLine(colorDecorator.GetText());
        }
    }
}
