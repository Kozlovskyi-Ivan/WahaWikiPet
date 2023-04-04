namespace WahaWikiAPI.Entities
{
    public class UnitWeaponRelationships
    {
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
