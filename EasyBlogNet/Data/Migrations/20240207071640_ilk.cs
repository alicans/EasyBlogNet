using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBlogNet.Data.Migrations
{
    /// <inheritdoc />
    public partial class ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Technology" },
                    { 2, "Lifestyle" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, 1, "<p>The future of technology is incredibly exciting, promising to bring new innovations that will revolutionize the way we live, work, and interact. From artificial intelligence and quantum computing to augmented reality and beyond, the possibilities are endless.</p><p>As we navigate this ever-evolving landscape, it's clear that technology will continue to play a pivotal role in shaping our future. The potential for positive change is immense, making this an exhilarating time to be alive and witness the advancements firsthand.</p>", "Exploring upcoming trends in technology.", "1.jpg", "The Future of Tech" },
                    { 2, 1, "<p>In today's fast-paced world, staying up-to-date with the latest technology gadgets can be a challenge. From the newest smartphones and smartwatches to drones and virtual reality headsets, the array of options is vast.</p><p>This review aims to shed light on some of the most groundbreaking gadgets currently on the market. By exploring their features, benefits, and potential drawbacks, we hope to provide valuable insights that will help you make informed decisions.</p>", "Reviews on the latest tech gadgets.", "2.jpg", "Tech Gadgets Review" },
                    { 3, 2, "<p>Maintaining a healthy lifestyle is crucial for overall well-being. It encompasses a variety of aspects, including balanced nutrition, regular exercise, adequate sleep, and stress management. Adopting these practices can lead to significant improvements in health and happiness.</p><p>In this article, we'll explore practical tips and strategies for living a healthier life. Whether you're looking to overhaul your diet, incorporate more physical activity into your routine, or find effective ways to relax and de-stress, we've got you covered.</p>", "Tips for a healthy lifestyle.", "3.jpg", "Healthy Living Tips" },
                    { 4, 2, "<p>Transforming your living space into a personalized oasis doesn't have to break the bank. With a little creativity and some DIY spirit, you can create beautiful, unique decorations that reflect your style and personality.</p><p>In this guide, we'll share some innovative DIY home decor ideas that are both easy and affordable. From upcycled furniture to handmade wall art, these projects will inspire you to get creative and make your home truly your own.</p>", "Creative DIY ideas for home decoration.", "4.jpg", "DIY Home Decor Ideas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
