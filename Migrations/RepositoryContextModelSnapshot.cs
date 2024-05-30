﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalBlogApp.Models;

#nullable disable

namespace PersonalBlogApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("PersonalBlogApp.Models.Writing", b =>
                {
                    b.Property<int>("WritingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WritingDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WritingName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("WritingId");

                    b.ToTable("Writings");

                    b.HasData(
                        new
                        {
                            WritingId = 1,
                            WritingDescription = "denemeiçyazı1",
                            WritingName = "Deneme"
                        },
                        new
                        {
                            WritingId = 2,
                            WritingDescription = "denemeiçyazı2",
                            WritingName = "Deneme2"
                        },
                        new
                        {
                            WritingId = 3,
                            WritingDescription = "denemeiçyazı3",
                            WritingName = "Deneme3"
                        },
                        new
                        {
                            WritingId = 4,
                            WritingDescription = "denemeiçyazı4",
                            WritingName = "Deneme4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
