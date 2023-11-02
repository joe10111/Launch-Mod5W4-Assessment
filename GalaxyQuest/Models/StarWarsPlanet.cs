namespace GalaxyQuest.Models
{
    public class StarWarsPlanet
    {
        public string Name { get; set; }

         // Population is a long since it might be big number
        public long Population { get; set; }

        public StarWarsPlanet(string name, long population)
        {
            Name = name;
            Population = population;
        }
    }
}
