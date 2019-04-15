﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesLista.Models;

namespace PageBook.Migrations.Lista
{
    [DbContext(typeof(ListaContext))]
    partial class ListaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("RazorPagesLista.Models.LISTA", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DeadLine");

                    b.Property<string>("Info");

                    b.Property<string>("Item");

                    b.HasKey("ID");

                    b.ToTable("LISTA");
                });
#pragma warning restore 612, 618
        }
    }
}
