#nullable disable

namespace BdTelegram
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public virtual Category Category { get; set; }
    }
}
