using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Horoscope;

namespace Horoscope.Migrations
{
    [DbContext(typeof(HoroscopeDbContext))]
    [Migration("20170522174111_initmigration")]
    partial class initmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
