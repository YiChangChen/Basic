﻿// <auto-generated />
using System;
using Basic.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Basic.Migrations
{
    [DbContext(typeof(BasicContext))]
    partial class BasicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Basic.Infrastructure.Entities.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FeatureGroupId")
                        .HasColumnType("int");

                    b.Property<string>("FeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyDT")
                        .HasColumnType("datetime2");

                    b.HasKey("FeatureId");

                    b.HasIndex("FeatureGroupId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.FeatureGroup", b =>
                {
                    b.Property<int>("FeatureGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyDT")
                        .HasColumnType("datetime2");

                    b.HasKey("FeatureGroupId");

                    b.ToTable("FeatureGroups");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FeatureId")
                        .HasColumnType("int");

                    b.Property<string>("LinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyDT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentIdMenuId")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("FeatureId");

                    b.HasIndex("ParentIdMenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.RoleFeature", b =>
                {
                    b.Property<int>("RoleFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FeatureId")
                        .HasColumnType("int");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyDT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RoleFeatureId");

                    b.HasIndex("FeatureId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleFeatures");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.SystemLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Request")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemLogs");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.Feature", b =>
                {
                    b.HasOne("Basic.Infrastructure.Entities.FeatureGroup", "FeatureGroup")
                        .WithMany()
                        .HasForeignKey("FeatureGroupId");

                    b.Navigation("FeatureGroup");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.Menu", b =>
                {
                    b.HasOne("Basic.Infrastructure.Entities.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId");

                    b.HasOne("Basic.Infrastructure.Entities.Menu", "ParentId")
                        .WithMany()
                        .HasForeignKey("ParentIdMenuId");

                    b.Navigation("Feature");

                    b.Navigation("ParentId");
                });

            modelBuilder.Entity("Basic.Infrastructure.Entities.RoleFeature", b =>
                {
                    b.HasOne("Basic.Infrastructure.Entities.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId");

                    b.HasOne("Basic.Infrastructure.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Feature");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
