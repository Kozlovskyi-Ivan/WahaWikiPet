namespace WahaWikiAPI.Entities
{
    public class UnitStat
    {
        public int Id { get; set; }
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public string ModelName { get; set; }
        public int PointPrice { get; set; }
        public int Move { get; set; }
        public int WS { get; set; }
        public int BS { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Wounds { get; set; }
        public int Attacks { get; set; }
        public int Leadership { get; set; }
        public int SavingThrows { get; set; }
        public Unit? Unit { get; set; }
    }
}
