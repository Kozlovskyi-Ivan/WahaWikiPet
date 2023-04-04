namespace WahaWikiAPI.Entities
{
    public class Weapon
    {
        public int WeaponId { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }
        public int WeaponTypeId { get; set; }
        public WeaponType WeaponType { get; set; }
        public string NumberOfShot { get; set; }
        public string Strength { get; set; }
        public string AP { get; set; }
        public string Damage { get; set; }
        public ICollection<Unit> Units { get; set; }
        public ICollection<WeaponAbilities> WeaponAbilities { get; set; }
    }
}
