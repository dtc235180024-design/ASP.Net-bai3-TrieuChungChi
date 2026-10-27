namespace bai3.Models
{
    public class Category
    {
        public int Id {  get; set; }
        public string Name { get; set; } = String.Empty;

        public List<Product>? Products { get; set; }
    }
}
