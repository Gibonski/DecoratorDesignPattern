namespace DecoratorDesign
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "My decorator design pattern!";
        }
    }
}
