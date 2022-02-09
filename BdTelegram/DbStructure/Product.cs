namespace BdTelegram.DbStructure
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
        public string Description { get; set; }
        public string LinkDownloading { get; set; }

        public string? Image { get; set; }

        public bool Status { get; set; } = true;
        public virtual Category CategoryId { get; set; }
    }
}
