using WahaWikiAPI.Entities;

namespace WahaWikiAPI.Models
{
    public class CreateUnitModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int UnitTypeId { get; set; }
        public ICollection<UnitStat> UnitStatList { get; set; }
        public ICollection<int> UnitWeaponId { get; set; }
        public ICollection<int> UnitAbilitiesId { get; set; }
    }
}
