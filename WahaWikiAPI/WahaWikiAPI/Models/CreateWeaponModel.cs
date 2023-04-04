namespace WahaWikiAPI.Models
{
    public class CreateWeaponModel
    {
        public string Name { get; set; }
        public int Range { get; set; }
        public int WeaponTypeId { get; set; }
        public string NumberOfShot { get; set; }
        public string Strength { get; set; }
        public string AP { get; set; }
        public string Damage { get; set; }
        public IEnumerable<int> Abilities { get; set; }
    }
}
