namespace DevOps.Portal.Domain.Teamcity
{
    public abstract class TeamCityComponent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
