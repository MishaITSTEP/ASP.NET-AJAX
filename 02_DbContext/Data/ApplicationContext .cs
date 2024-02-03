using _02_DbContext.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Principal;

namespace _02_DbContext.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Advertisement>().HasData(new[]
           {
                new Advertisement() { Id = 1, Title = "iPhone X", Category = "Electronics", City = "Lviv", Price = 650, ContactInfo = "0972435293", IdMainPictureURL = 0, PictureURLs = new(){ "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png" },
                Description = "The iPhone X, introduced by Apple in 2017, is a groundbreaking smartphone that marked a significant shift in design and technology. With a stunning 5.8-inch Super Retina display, the device boasts an edge-to-edge screen that seamlessly blends into its stainless steel frame. The OLED technology delivers vibrant colors and deep blacks, providing an immersive visual experience. The absence of a physical home button is a notable departure, replaced by intuitive gestures and the introduction of Face ID, Apple's facial recognition technology, for secure and seamless authentication."},
                new Advertisement() { Id = 2, Title = "PowerBall", Category = "Sport", City = "Rivne", Price = 45.5M, ContactInfo = "0504829628", IdMainPictureURL = 0, PictureURLs = new () {"https://http2.mlstatic.com/D_NQ_NP_727192-CBT53879999753_022023-V.jpg" },
                Description = "The PowerBall arm training instrument is a compact and innovative fitness device designed to target and strengthen the muscles in the arms, wrists, and hands. Featuring a gyroscopic mechanism, this handheld exercise tool engages users in dynamic and resistance-based workouts. By simply rotating the device, users activate the gyro, generating centrifugal force that challenges the muscles throughout the entire range of motion. The PowerBall is not only effective for building arm strength but also for improving grip, coordination, and endurance."},
                new Advertisement() { Id = 3, Title = "Nike T-Shirt", Category = "Fashion", City = "Odessa", Price = 189, ContactInfo = "0984739358", IdMainPictureURL = 0, PictureURLs = new(){ "https://www.seekpng.com/png/detail/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png" },
                Description = "The Nike T-Shirt is a classic and versatile piece of athletic apparel that seamlessly blends style and functionality. Crafted from a high-quality blend of cotton and polyester, this shirt offers a soft and comfortable feel against the skin, making it ideal for various activities or casual wear. The fabric is designed to wick away moisture, keeping you cool and dry during intense workouts or warm days."},
                new Advertisement() { Id = 4, Title = "Samsung S23", Category = "Electronics", City = "Kharkiv", Price = 1200, ContactInfo = "0633492583", IdMainPictureURL = 0, PictureURLs = new() { "https://sota.kh.ua/image/cache/data/Samsung-2/samsung-s23-s23plus-blk-01-700x700.webp" },
                Description = "The Samsung Galaxy S23 is a cutting-edge smartphone that epitomizes innovation and style. Boasting a sleek and ergonomic design, the device features a vibrant and immersive display, showcasing a 6.2-inch Dynamic AMOLED screen with high resolution and HDR support. Powered by a robust processor, likely the latest from Samsung's Exynos or Qualcomm Snapdragon series, the S22 ensures smooth performance and efficient multitasking."},
                new Advertisement() { Id = 5, Title = "Air Ball", Category = "Toys & Hobbies", City = "Lutsk", Price = 50, ContactInfo = "0674920649", IdMainPictureURL = 0, PictureURLs = new() { "https://cdn.shopify.com/s/files/1/0046/1163/7320/products/69ee701e-e806-4c4d-b804-d53dc1f0e11a_grande.jpg" },
                Description = "The Air Ball is an innovative and dynamic fitness tool designed to elevate traditional exercise routines. This inflatable exercise ball introduces an element of instability, engaging core muscles and promoting balance during workouts. Crafted from durable and anti-burst PVC material, the Air Ball ensures safety and longevity, making it suitable for various fitness levels and exercises."},
                new Advertisement() { Id = 6, Title = "MacBook Pro 2019", Category = "Electronics", City = "Zhytomyr", ContactInfo = "0983406394", Price = 1200, IdMainPictureURL = 0, PictureURLs = new() { "https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp" }, 
                Description = "The MacBook Pro 2019 is a powerful and sleek laptop that exemplifies Apple's commitment to performance and design. Equipped with a stunning Retina display, the 2019 model features a 13-inch or 15-inch screen with brilliant color reproduction and sharp resolution. Powered by Intel processors, including quad-core and six-core options, it delivers exceptional speed and multitasking capabilities."}
            });
        }
        public DbSet<Advertisement> Advertisements { get; set; }
    }
}
