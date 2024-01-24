namespace WahaWikiAPI.Entities
{
    public class WeaponAbilities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public ICollection<Weapon> Weapons { get; set; }
        //public List<WeaponAbilitiesRelationships> WeaponAbilitiesRelationships { get; set; }

    }
}
