namespace EasyBlogNet.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Post> Posts { get; set; }
    }
}
