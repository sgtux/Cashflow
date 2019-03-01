﻿// <auto-generated />
using System;
using FinanceApi.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cashflow.Api.Infra.Migrations
{
  [DbContext(typeof(AppDbContext))]
  partial class AppDbContextModelSnapshot : ModelSnapshot
  {
    /// Build model
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
          .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
          .HasAnnotation("Relational:MaxIdentifierLength", 63);

      modelBuilder.Entity("FinanceApi.Infra.Entity.CreditCard", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<string>("Name")
                      .HasMaxLength(256);

            b.Property<int>("UserId");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("CreditCard");
          });

      modelBuilder.Entity("FinanceApi.Infra.Entity.Payment", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<decimal>("Cost");

            b.Property<int?>("CreditCardId");

            b.Property<string>("Description")
                      .HasMaxLength(256);

            b.Property<DateTime>("FirstPayment");

            b.Property<bool>("FixedPayment");

            b.Property<int>("Plots");

            b.Property<int>("PlotsPaid");

            b.Property<bool>("SinglePlot");

            b.Property<int>("Type");

            b.Property<int>("UserId");

            b.HasKey("Id");

            b.HasIndex("CreditCardId");

            b.HasIndex("UserId");

            b.ToTable("Payment");
          });

      modelBuilder.Entity("FinanceApi.Infra.Entity.User", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<DateTime>("CreatedAt");

            b.Property<string>("Email")
                      .HasMaxLength(256);

            b.Property<DateTime>("LastAccess");

            b.Property<string>("Name")
                      .HasMaxLength(256);

            b.Property<string>("Password")
                      .HasMaxLength(256);

            b.Property<DateTime?>("UpdatedAt");

            b.HasKey("Id");

            b.ToTable("User");
          });

      modelBuilder.Entity("FinanceApi.Infra.Entity.CreditCard", b =>
          {
            b.HasOne("FinanceApi.Infra.Entity.User", "User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("FinanceApi.Infra.Entity.Payment", b =>
          {
            b.HasOne("FinanceApi.Infra.Entity.CreditCard", "CreditCard")
                      .WithMany()
                      .HasForeignKey("CreditCardId");

            b.HasOne("FinanceApi.Infra.Entity.User", "User")
                      .WithMany("Payments")
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade);
          });
#pragma warning restore 612, 618
    }
  }
}
