﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_DbContext.Data;

#nullable disable

namespace _02_DbContext.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240117154534_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_02_DbContext.Data.Entities.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMainPictureURL")
                        .HasColumnType("int");

                    b.Property<string>("PictureURLs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Advertisements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Electronics",
                            City = "Lviv",
                            ContactInfo = "0972435293",
                            Description = "The iPhone X, introduced by Apple in 2017, is a groundbreaking smartphone that marked a significant shift in design and technology. With a stunning 5.8-inch Super Retina display, the device boasts an edge-to-edge screen that seamlessly blends into its stainless steel frame. The OLED technology delivers vibrant colors and deep blacks, providing an immersive visual experience. The absence of a physical home button is a notable departure, replaced by intuitive gestures and the introduction of Face ID, Apple's facial recognition technology, for secure and seamless authentication.",
                            IdMainPictureURL = 0,
                            PictureURLs = "[\"https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png\"]",
                            Price = 650m,
                            Title = "iPhone X"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Sport",
                            City = "Rivne",
                            ContactInfo = "0504829628",
                            Description = "The PowerBall arm training instrument is a compact and innovative fitness device designed to target and strengthen the muscles in the arms, wrists, and hands. Featuring a gyroscopic mechanism, this handheld exercise tool engages users in dynamic and resistance-based workouts. By simply rotating the device, users activate the gyro, generating centrifugal force that challenges the muscles throughout the entire range of motion. The PowerBall is not only effective for building arm strength but also for improving grip, coordination, and endurance.",
                            IdMainPictureURL = 0,
                            PictureURLs = "[\"https://http2.mlstatic.com/D_NQ_NP_727192-CBT53879999753_022023-V.jpg\"]",
                            Price = 45.5m,
                            Title = "PowerBall"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Fashion",
                            City = "Odessa",
                            ContactInfo = "0984739358",
                            Description = "The Nike T-Shirt is a classic and versatile piece of athletic apparel that seamlessly blends style and functionality. Crafted from a high-quality blend of cotton and polyester, this shirt offers a soft and comfortable feel against the skin, making it ideal for various activities or casual wear. The fabric is designed to wick away moisture, keeping you cool and dry during intense workouts or warm days.",
                            IdMainPictureURL = 0,
                            PictureURLs = "[\"https://www.seekpng.com/png/detail/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png\"]",
                            Price = 189m,
                            Title = "Nike T-Shirt"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Electronics",
                            City = "Kharkiv",
                            ContactInfo = "0633492583",
                            Description = "The Samsung Galaxy S23 is a cutting-edge smartphone that epitomizes innovation and style. Boasting a sleek and ergonomic design, the device features a vibrant and immersive display, showcasing a 6.2-inch Dynamic AMOLED screen with high resolution and HDR support. Powered by a robust processor, likely the latest from Samsung's Exynos or Qualcomm Snapdragon series, the S22 ensures smooth performance and efficient multitasking.",
                            IdMainPictureURL = 0,
                            PictureURLs = "[\"https://sota.kh.ua/image/cache/data/Samsung-2/samsung-s23-s23plus-blk-01-700x700.webp\"]",
                            Price = 1200m,
                            Title = "Samsung S23"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Toys & Hobbies",
                            City = "Lutsk",
                            ContactInfo = "0674920649",
                            Description = "The Air Ball is an innovative and dynamic fitness tool designed to elevate traditional exercise routines. This inflatable exercise ball introduces an element of instability, engaging core muscles and promoting balance during workouts. Crafted from durable and anti-burst PVC material, the Air Ball ensures safety and longevity, making it suitable for various fitness levels and exercises.",
                            IdMainPictureURL = 0,
                            PictureURLs = "[\"https://cdn.shopify.com/s/files/1/0046/1163/7320/products/69ee701e-e806-4c4d-b804-d53dc1f0e11a_grande.jpg\"]",
                            Price = 50m,
                            Title = "Air Ball"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Electronics",
                            City = "Zhytomyr",
                            ContactInfo = "0983406394",
                            Description = "The MacBook Pro 2019 is a powerful and sleek laptop that exemplifies Apple's commitment to performance and design. Equipped with a stunning Retina display, the 2019 model features a 13-inch or 15-inch screen with brilliant color reproduction and sharp resolution. Powered by Intel processors, including quad-core and six-core options, it delivers exceptional speed and multitasking capabilities.",
                            IdMainPictureURL = 0,
                            PictureURLs = "[\"https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp\"]",
                            Price = 1200m,
                            Title = "MacBook Pro 2019"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
