namespace ProjectName.Components
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Original Text";
        }
    }
}