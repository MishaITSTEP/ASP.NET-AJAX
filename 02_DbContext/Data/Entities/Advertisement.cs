namespace _02_DbContext.Data.Entities
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string ContactInfo { get; set; }
        public List<string> PictureURLs { get; set; } = new List<string>();
        public int IdMainPictureURL { get; set; }
    }
}
