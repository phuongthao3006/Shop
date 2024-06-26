﻿// <auto-generated />
using System;
using EShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EShop.Migrations
{
    [DbContext(typeof(EShopDBContext))]
    partial class EShopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EShop.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Banner", (string)null);
                });

            modelBuilder.Entity("EShop.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("EShop.Models.CartItem", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("Cart_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Cart_item", (string)null);
                });

            modelBuilder.Entity("EShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("EShop.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("Created_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("Order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_id");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("EShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("Created_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("EShop.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("Order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Order_item", (string)null);
                });

            modelBuilder.Entity("EShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("Category_id");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Created_date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("EShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("EShop.Models.Cart", b =>
                {
                    b.HasOne("EShop.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Cart_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EShop.Models.CartItem", b =>
                {
                    b.HasOne("EShop.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Cart_item_Cart");

                    b.HasOne("EShop.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Cart_item_Product");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EShop.Models.Feedback", b =>
                {
                    b.HasOne("EShop.Models.Order", "Order")
                        .WithMany("Feedbacks")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_Order");

                    b.HasOne("EShop.Models.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_Product");

                    b.HasOne("EShop.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_User");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EShop.Models.Order", b =>
                {
                    b.HasOne("EShop.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EShop.Models.OrderItem", b =>
                {
                    b.HasOne("EShop.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_item_Order");

                    b.HasOne("EShop.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_item_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EShop.Models.Product", b =>
                {
                    b.HasOne("EShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Product_Category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EShop.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("EShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EShop.Models.Order", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EShop.Models.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Feedbacks");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EShop.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
