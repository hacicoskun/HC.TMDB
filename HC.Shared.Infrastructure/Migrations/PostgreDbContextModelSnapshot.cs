﻿// <auto-generated />
using System;
using HC.Shared.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HC.Shared.Infrastructure.Migrations
{
    [DbContext(typeof(PostgreDbContext))]
    partial class PostgreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HC.Shared.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<bool>("adult")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("movie_id")
                        .HasColumnType("integer");

                    b.Property<string>("note")
                        .HasColumnType("text");

                    b.Property<string>("original_language")
                        .HasColumnType("text");

                    b.Property<string>("original_title")
                        .HasColumnType("text");

                    b.Property<string>("overview")
                        .HasColumnType("text");

                    b.Property<int>("page")
                        .HasColumnType("integer");

                    b.Property<double>("popularity")
                        .HasColumnType("double precision");

                    b.Property<string>("poster_path")
                        .HasColumnType("text");

                    b.Property<string>("release_date")
                        .HasColumnType("text");

                    b.Property<int>("score")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<bool>("video")
                        .HasColumnType("boolean");

                    b.Property<double>("vote_average")
                        .HasColumnType("double precision");

                    b.Property<int>("vote_count")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("HC.Shared.Domain.Entities.MovieComments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("movie_id")
                        .HasColumnType("integer");

                    b.Property<string>("note")
                        .HasColumnType("text");

                    b.Property<int>("score")
                        .HasColumnType("integer");

                    b.Property<string>("user_id")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("MovieComments");
                });
#pragma warning restore 612, 618
        }
    }
}
