﻿// <auto-generated />
using EvotechGS.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EvotechGS.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EvotechGS.Models.DispositivoModel", b =>
                {
                    b.Property<int>("id_dispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_dispositivo"));

                    b.Property<string>("nm_dispositivo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<float>("potencia")
                        .HasColumnType("BINARY_FLOAT");

                    b.HasKey("id_dispositivo");

                    b.ToTable("tb_dispositivo");
                });
#pragma warning restore 612, 618
        }
    }
}