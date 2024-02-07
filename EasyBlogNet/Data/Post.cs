namespace EasyBlogNet.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Content { get; set; } = string.Empty;

        public string? Image { get; set; } 

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
