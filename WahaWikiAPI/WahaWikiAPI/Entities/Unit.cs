namespace WahaWikiAPI.Entities
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        //public UnitFaction? Faction { get; set; }
        public UnitType? UnitType { get; set; }
        //public ICollection<string>? KeyWords { get; set; }
        public ICollection<UnitStat> UnitStatList { get; set; }
        public ICollection<Weapon> Weapons { get; set; }
        public ICollection<Abilities> Abilities { get; set; }
    }
}
