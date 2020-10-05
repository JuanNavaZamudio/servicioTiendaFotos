﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace service.Migrations
{
    [DbContext(typeof(PostContext))]
    [Migration("20201005035113_mysqltablescreation")]
    partial class mysqltablescreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StorePost", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("full_size")
                        .HasColumnType("text");

                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("float");

                    b.Property<string>("square_size")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}