using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyBlogNet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Lifestyle" }
            );

            builder.Entity<Post>().HasData
            (
                new Post
                {
                    Id = 1,
                    Title = "The Future of Tech",
                    Description = "Exploring upcoming trends in technology.",
                    Content = "<p>The future of technology is incredibly exciting, promising to bring new innovations that will revolutionize the way we live, work, and interact. From artificial intelligence and quantum computing to augmented reality and beyond, the possibilities are endless.</p><p>As we navigate this ever-evolving landscape, it's clear that technology will continue to play a pivotal role in shaping our future. The potential for positive change is immense, making this an exhilarating time to be alive and witness the advancements firsthand.</p>",
                    Image = "1.jpg", 
                    CategoryId = 1
                },
                new Post
                {
                    Id = 2,
                    Title = "Tech Gadgets Review",
                    Description = "Reviews on the latest tech gadgets.",
                    Content = "<p>In today's fast-paced world, staying up-to-date with the latest technology gadgets can be a challenge. From the newest smartphones and smartwatches to drones and virtual reality headsets, the array of options is vast.</p><p>This review aims to shed light on some of the most groundbreaking gadgets currently on the market. By exploring their features, benefits, and potential drawbacks, we hope to provide valuable insights that will help you make informed decisions.</p>",
                    Image = "2.jpg", 
                    CategoryId = 1
                },
                new Post
                {
                    Id = 3,
                    Title = "Healthy Living Tips",
                    Description = "Tips for a healthy lifestyle.",
                    Content = "<p>Maintaining a healthy lifestyle is crucial for overall well-being. It encompasses a variety of aspects, including balanced nutrition, regular exercise, adequate sleep, and stress management. Adopting these practices can lead to significant improvements in health and happiness.</p><p>In this article, we'll explore practical tips and strategies for living a healthier life. Whether you're looking to overhaul your diet, incorporate more physical activity into your routine, or find effective ways to relax and de-stress, we've got you covered.</p>",
                    Image = "3.jpg", 
                    CategoryId = 2
                },
                new Post
                {
                    Id = 4,
                    Title = "DIY Home Decor Ideas",
                    Description = "Creative DIY ideas for home decoration.",
                    Content = "<p>Transforming your living space into a personalized oasis doesn't have to break the bank. With a little creativity and some DIY spirit, you can create beautiful, unique decorations that reflect your style and personality.</p><p>In this guide, we'll share some innovative DIY home decor ideas that are both easy and affordable. From upcycled furniture to handmade wall art, these projects will inspire you to get creative and make your home truly your own.</p>",
                    Image = "4.jpg",
                    CategoryId = 2
                }
            );
        }
    }
}
