﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrganizationService.Host.EntityFrameworkCore;

namespace OrganizationService.Host.Migrations
{
    [DbContext(typeof(OrganizationServiceServiceMigrationDbContext))]
    [Migration("20190425073712_INIT")]
    partial class INIT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrganizationService.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid?>("ParentId");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<int>("Sort");

                    b.HasKey("Id");

                    b.ToTable("AbpOrganizations");
                });

            modelBuilder.Entity("OrganizationService.UserOrganization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("OrganizationId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("AbpUserOrganizations");
                });

            modelBuilder.Entity("OrganizationService.UserOrganization", b =>
                {
                    b.HasOne("OrganizationService.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
