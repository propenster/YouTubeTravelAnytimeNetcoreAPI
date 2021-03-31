﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAnytimePublicAPI.DAL;

namespace TravelAnytimePublicAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.Hotel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("closes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("lat")
                        .HasColumnType("float");

                    b.Property<double>("lng")
                        .HasColumnType("float");

                    b.Property<string>("mobile_reserve_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postal_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("reserve_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restaurant_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.HotelReview", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Restaurantid")
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hotel_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("Restaurantid");

                    b.HasIndex("hotel_id");

                    b.ToTable("HotelReviews");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.Restaurant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("closes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("lat")
                        .HasColumnType("float");

                    b.Property<double>("lng")
                        .HasColumnType("float");

                    b.Property<string>("mobile_reserve_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postal_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("reserve_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restaurant_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.RestaurantReview", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("restaurant_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("restaurant_id");

                    b.ToTable("RestaurantReviews");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.HotelReview", b =>
                {
                    b.HasOne("TravelAnytimePublicAPI.Models.Restaurant", null)
                        .WithMany("reviews")
                        .HasForeignKey("Restaurantid");

                    b.HasOne("TravelAnytimePublicAPI.Models.Hotel", "hotel")
                        .WithMany("reviews")
                        .HasForeignKey("hotel_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hotel");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.RestaurantReview", b =>
                {
                    b.HasOne("TravelAnytimePublicAPI.Models.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("restaurant_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.Hotel", b =>
                {
                    b.Navigation("reviews");
                });

            modelBuilder.Entity("TravelAnytimePublicAPI.Models.Restaurant", b =>
                {
                    b.Navigation("reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
