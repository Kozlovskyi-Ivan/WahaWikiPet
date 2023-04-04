namespace WahaWikiAPI.Entities
{
    public class WeaponAbilitiesRelationships
    {
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int WeaponAbilitiesId { get; set; }
        public WeaponAbilities WeaponAbilities { get; set; }
    }
}
