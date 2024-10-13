﻿// <auto-generated />
using System;
using Livraria.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Livraria.Infraestructure.Migrations
{
    [DbContext(typeof(DbEditContext))]
    partial class DbEditContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Livraria.Core.Entity.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autor", (string)null);
                });

            modelBuilder.Entity("Livraria.Core.Entity.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<DateTime>("DataAvalicao")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("INT");

                    b.Property<int>("IdLivro")
                        .HasColumnType("INT");

                    b.Property<int>("Nota")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdLivro");

                    b.ToTable("Avaliacao", (string)null);
                });

            modelBuilder.Entity("Livraria.Core.Entity.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.HasKey("Id");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Livraria.Core.Entity.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("DATETIME");

                    b.Property<int>("IdAutor")
                        .HasColumnType("INT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("DECIMAL");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdAutor");

                    b.ToTable("Livros", (string)null);
                });

            modelBuilder.Entity("Livraria.Core.Entity.LivroEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdLivro")
                        .HasColumnType("INT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLivro")
                        .IsUnique();

                    b.ToTable("LivrosEstoque", (string)null);
                });

            modelBuilder.Entity("Livraria.Core.Entity.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("INT");

                    b.Property<int>("IdLivro")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdLivro");

                    b.ToTable("Pedido", (string)null);
                });

            modelBuilder.Entity("Livraria.Core.Entity.Avaliacao", b =>
                {
                    b.HasOne("Livraria.Core.Entity.Cliente", "Cliente")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.Core.Entity.Livro", "Livro")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("IdLivro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Livraria.Core.Entity.Livro", b =>
                {
                    b.HasOne("Livraria.Core.Entity.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("IdAutor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Livraria.Core.Entity.LivroEstoque", b =>
                {
                    b.HasOne("Livraria.Core.Entity.Livro", "Livro")
                        .WithOne("LivroEstoque")
                        .HasForeignKey("Livraria.Core.Entity.LivroEstoque", "IdLivro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Livraria.Core.Entity.Pedido", b =>
                {
                    b.HasOne("Livraria.Core.Entity.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.Core.Entity.Livro", "Livro")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdLivro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Livraria.Core.Entity.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("Livraria.Core.Entity.Cliente", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Livraria.Core.Entity.Livro", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("LivroEstoque")
                        .IsRequired();

                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
