using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TripPlanner.DataAccess.Models;

namespace TripPlanner.Migrations
{
    [DbContext(typeof(TripPlannerDbContext))]
    [Migration("20160812012212_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripPlanner.DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("char(4)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("char(3)");

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<string>("Suburb")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });
        }
    }
}
