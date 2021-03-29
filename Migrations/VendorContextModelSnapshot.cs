﻿// <auto-generated />
using J2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace J2.Migrations
{
    [DbContext(typeof(VendorContext))]
    partial class VendorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("J2.Models.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("LinkID");

                    b.Property<int>("VendorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("systemName")
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .HasColumnType("TEXT");

                    b.HasKey("LinkID");

                    b.HasIndex("VendorID");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("J2.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("VendorID");

                    b.Property<string>("logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("mainUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("supportEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("supportPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("supportUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("vendorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VendorID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("J2.Models.Link", b =>
                {
                    b.HasOne("J2.Models.Vendor", "Vendor")
                        .WithMany("links")
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("J2.Models.Vendor", b =>
                {
                    b.Navigation("links");
                });
#pragma warning restore 612, 618
        }
    }
}