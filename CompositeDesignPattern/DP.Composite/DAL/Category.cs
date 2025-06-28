namespace DP.Composite.DAL
{
    public class Category
    {
        public int UpperCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
