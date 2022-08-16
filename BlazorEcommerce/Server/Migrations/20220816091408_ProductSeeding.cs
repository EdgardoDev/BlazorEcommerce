using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "With more than 20% of affiliate marketers each making over $50,000 a year, and well over half of those in the six figure bracket, the upside potential for a nice annual income looks quite promising for anyone who is looking for a new source of revenue.", "https://www.ebookjunkie.com/sites/default/files/ebook_images/affiliate_marketing_plan_profit_bundle.jpg", 9.99m, "Affiliate Marketing Plan" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "With more than 205 billion emails being sent and received every day if your business isn't taking advantage of this powerful and massive marketing channel, then you are missing out on a highly effective way to reach your target audience.", "https://www.ebookjunkie.com/sites/default/files/ebook_images/email_marketing_success2.jpg", 5.99m, "Email Marketing Success" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Being a solopreneur means being an entrepreneur that runs everything themselves. There are countless advantages to this kind of business model, and thanks to the web, it's now more feasible for more people than ever before.", "https://www.ebookjunkie.com/sites/default/files/ebook_images/productive_solopreneur_0.jpg", 7.99m, "The Productive Solopreneur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
