namespace WahaWikiAPI.Entities
{
    public class UnitAbilitiesRelationships
    {
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int AbilitiesId { get; set; }
        public Abilities Abilities { get; set; }
    }
}
