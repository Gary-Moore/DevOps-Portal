namespace DevOps.Portal.Infrastructure.Network
{
    public class CustomHeader
    {
        public CustomHeader(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
