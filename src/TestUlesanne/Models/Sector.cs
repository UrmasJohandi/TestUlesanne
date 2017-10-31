namespace TestUlesanne.Models
{
    public class Sector
    {
        public int Id { get; set; }
        public int SectorId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public int OrderNr { get; set; }
        public bool Selected { get; set; }
    }
}
