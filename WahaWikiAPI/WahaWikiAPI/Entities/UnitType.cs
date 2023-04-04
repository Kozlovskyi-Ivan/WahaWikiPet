namespace WahaWikiAPI.Entities
{
    public class UnitType
    {
        public int Id { get; set; }
        public string UnitTypeName { get; set; }
        public ICollection<Unit> UnitList { get; set; }

    }
}
