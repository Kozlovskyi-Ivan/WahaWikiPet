namespace WahaWikiAPI.Entities
{
    public class Abilities
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public ICollection<Unit> Units { get; set; }
    }
}
