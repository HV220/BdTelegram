namespace BdTelegram.DbStructure
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int? ParentId { get; set; }
       // public virtual List<Product> Product { get; set; }
    }
}
