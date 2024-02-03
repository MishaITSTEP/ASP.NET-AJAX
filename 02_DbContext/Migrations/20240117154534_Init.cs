using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _02_DbContext.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureURLs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMainPictureURL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "Category", "City", "ContactInfo", "Description", "IdMainPictureURL", "PictureURLs", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Electronics", "Lviv", "0972435293", "The iPhone X, introduced by Apple in 2017, is a groundbreaking smartphone that marked a significant shift in design and technology. With a stunning 5.8-inch Super Retina display, the device boasts an edge-to-edge screen that seamlessly blends into its stainless steel frame. The OLED technology delivers vibrant colors and deep blacks, providing an immersive visual experience. The absence of a physical home button is a notable departure, replaced by intuitive gestures and the introduction of Face ID, Apple's facial recognition technology, for secure and seamless authentication.", 0, "[\"https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png\"]", 650m, "iPhone X" },
                    { 2, "Sport", "Rivne", "0504829628", "The PowerBall arm training instrument is a compact and innovative fitness device designed to target and strengthen the muscles in the arms, wrists, and hands. Featuring a gyroscopic mechanism, this handheld exercise tool engages users in dynamic and resistance-based workouts. By simply rotating the device, users activate the gyro, generating centrifugal force that challenges the muscles throughout the entire range of motion. The PowerBall is not only effective for building arm strength but also for improving grip, coordination, and endurance.", 0, "[\"https://http2.mlstatic.com/D_NQ_NP_727192-CBT53879999753_022023-V.jpg\"]", 45.5m, "PowerBall" },
                    { 3, "Fashion", "Odessa", "0984739358", "The Nike T-Shirt is a classic and versatile piece of athletic apparel that seamlessly blends style and functionality. Crafted from a high-quality blend of cotton and polyester, this shirt offers a soft and comfortable feel against the skin, making it ideal for various activities or casual wear. The fabric is designed to wick away moisture, keeping you cool and dry during intense workouts or warm days.", 0, "[\"https://www.seekpng.com/png/detail/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png\"]", 189m, "Nike T-Shirt" },
                    { 4, "Electronics", "Kharkiv", "0633492583", "The Samsung Galaxy S23 is a cutting-edge smartphone that epitomizes innovation and style. Boasting a sleek and ergonomic design, the device features a vibrant and immersive display, showcasing a 6.2-inch Dynamic AMOLED screen with high resolution and HDR support. Powered by a robust processor, likely the latest from Samsung's Exynos or Qualcomm Snapdragon series, the S22 ensures smooth performance and efficient multitasking.", 0, "[\"https://sota.kh.ua/image/cache/data/Samsung-2/samsung-s23-s23plus-blk-01-700x700.webp\"]", 1200m, "Samsung S23" },
                    { 5, "Toys & Hobbies", "Lutsk", "0674920649", "The Air Ball is an innovative and dynamic fitness tool designed to elevate traditional exercise routines. This inflatable exercise ball introduces an element of instability, engaging core muscles and promoting balance during workouts. Crafted from durable and anti-burst PVC material, the Air Ball ensures safety and longevity, making it suitable for various fitness levels and exercises.", 0, "[\"https://cdn.shopify.com/s/files/1/0046/1163/7320/products/69ee701e-e806-4c4d-b804-d53dc1f0e11a_grande.jpg\"]", 50m, "Air Ball" },
                    { 6, "Electronics", "Zhytomyr", "0983406394", "The MacBook Pro 2019 is a powerful and sleek laptop that exemplifies Apple's commitment to performance and design. Equipped with a stunning Retina display, the 2019 model features a 13-inch or 15-inch screen with brilliant color reproduction and sharp resolution. Powered by Intel processors, including quad-core and six-core options, it delivers exceptional speed and multitasking capabilities.", 0, "[\"https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp\"]", 1200m, "MacBook Pro 2019" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");
        }
    }
}
