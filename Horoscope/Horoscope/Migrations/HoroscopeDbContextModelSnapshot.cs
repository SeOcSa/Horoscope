using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Horoscope;

namespace Horoscope.Migrations
{
    [DbContext(typeof(HoroscopeDbContext))]
    partial class HoroscopeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Horoscope.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Matricol");

                    b.Property<string>("Nume");

                    b.Property<float>("media");

                    b.HasKey("Id");

                    b.ToTable("StudentInfos");
                });
        }
    }
}
