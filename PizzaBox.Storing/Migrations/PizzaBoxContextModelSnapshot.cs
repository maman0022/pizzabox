﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    partial class PizzaBoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ACrust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ACrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CrustEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("SizeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CrustEntityId");

                    b.HasIndex("SizeEntityId");

                    b.ToTable("Pizzas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("APizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ASize", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("EntityId");

                    b.ToTable("Sizes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ASize");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ATopping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("APizzaEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("EntityId");

                    b.HasIndex("APizzaEntityId");

                    b.ToTable("Toppings");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ATopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CustomerEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PizzaEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CustomerEntityId");

                    b.HasIndex("PizzaEntityId");

                    b.HasIndex("StoreEntityId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.Pan", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("Pan");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            Name = "Pan",
                            Price = 5.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.Stuffed", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("Stuffed");

                    b.HasData(
                        new
                        {
                            EntityId = 3L,
                            Name = "Stuffed",
                            Price = 6.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.Thin", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("Thin");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Thin",
                            Price = 4.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.CustomPizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("CustomPizza");

                    b.HasData(
                        new
                        {
                            EntityId = 3L,
                            Name = "Custom Pizza"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.MeatPizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("MeatPizza");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Meat Pizza"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.VeggiePizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("VeggiePizza");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            Name = "Veggie Pizza"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sizes.Large", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASize");

                    b.HasDiscriminator().HasValue("Large");

                    b.HasData(
                        new
                        {
                            EntityId = 3L,
                            Name = "Large",
                            Price = 7.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sizes.Medium", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASize");

                    b.HasDiscriminator().HasValue("Medium");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            Name = "Medium",
                            Price = 6.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sizes.Small", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASize");

                    b.HasDiscriminator().HasValue("Small");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Small",
                            Price = 5.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Stores.ChicagoStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("ChicagoStore");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "1234 Main Street"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Stores.NewYorkStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("NewYorkStore");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            Name = "801 128th Street"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Mushrooms", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Mushrooms");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            Name = "Mushrooms",
                            Price = 2.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Onions", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Onions");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Onions",
                            Price = 2.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Pepperoni", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Pepperoni");

                    b.HasData(
                        new
                        {
                            EntityId = 3L,
                            Name = "Pepperoni",
                            Price = 3.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Sausage", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Sausage");

                    b.HasData(
                        new
                        {
                            EntityId = 4L,
                            Name = "Sausage",
                            Price = 3.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.ACrust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.ASize", "Size")
                        .WithMany()
                        .HasForeignKey("SizeEntityId");

                    b.Navigation("Crust");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ATopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.APizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("APizzaEntityId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.APizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.AStore", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId");

                    b.Navigation("Customer");

                    b.Navigation("Pizza");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}