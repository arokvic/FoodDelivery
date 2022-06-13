﻿// <auto-generated />
using System;
using FoodDeliveryAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDeliveryAPI.Migrations
{
    [DbContext(typeof(DeliveryContext))]
    [Migration("20220612213138_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodDeliveryAPI.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryTime")
                        .HasColumnType("int");

                    b.Property<string>("OrderAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pending")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCartId")
                        .HasColumnType("int");

                    b.Property<string>("Verified")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.HasIndex("UserCartId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.CartItem", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("FoodDeliveryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Order", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.OrderItem", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Order", null)
                        .WithMany("products")
                        .HasForeignKey("OrderId");

                    b.HasOne("FoodDeliveryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.User", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Cart", "UserCart")
                        .WithMany()
                        .HasForeignKey("UserCartId");

                    b.Navigation("UserCart");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Order", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
