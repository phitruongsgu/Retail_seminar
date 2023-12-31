﻿// <auto-generated />
using System;
using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220413104843_Retail_db")]
    partial class Retail_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SharedLibrary.DeliveryOrder", b =>
                {
                    b.Property<string>("delivery_order_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("actual_quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("delivery_order_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("expected_quantity")
                        .HasColumnType("int");

                    b.Property<bool>("order_status")
                        .HasColumnType("bit");

                    b.HasKey("delivery_order_id");

                    b.ToTable("DeliveryOrders");
                });

            modelBuilder.Entity("SharedLibrary.DeliveryOrderDetail", b =>
                {
                    b.Property<string>("product_instance_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("delivery_order_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("is_checked")
                        .HasColumnType("bit");

                    b.HasKey("product_instance_id", "delivery_order_id");

                    b.ToTable("DeliveryOrderDetail");
                });

            modelBuilder.Entity("SharedLibrary.ProductInstance", b =>
                {
                    b.Property<string>("product_intance_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("product_line_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("product_intance_id", "product_line_id");

                    b.ToTable("ProductInstance");
                });

            modelBuilder.Entity("SharedLibrary.ProductLine", b =>
                {
                    b.Property<string>("product_line_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stock")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("product_line_id");

                    b.ToTable("ProductLine");
                });
#pragma warning restore 612, 618
        }
    }
}
