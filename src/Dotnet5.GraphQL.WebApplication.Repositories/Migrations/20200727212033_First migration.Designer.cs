﻿// <auto-generated />
using System;
using Dotnet5.GraphQL.WebApplication.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dotnet5.GraphQL.WebApplication.Repositories.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20200727212033_First migration")]
    partial class Firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CS_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20372.13");

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("IntroduceAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b4d3cde-f490-4420-8ca9-80d1026e5b93"),
                            Description = "Aut aperiam sint cupiditate suscipit doloremque velit ab.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 16, 10, 10, 1, 496, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "molestias",
                            PhotoFileName = "collaboration.img",
                            Price = 0.559778675943896841887785444m,
                            ProductTypeId = new Guid("06bb4b7f-9e8b-4376-bb6b-a794f7cfcd1c"),
                            Rating = -408755436,
                            Stock = -747845058
                        },
                        new
                        {
                            Id = new Guid("de037ed8-ab6f-4ac8-bf0d-db691d81edbb"),
                            Description = "Quia aut commodi blanditiis harum omnis et in dignissimos qui.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 11, 5, 12, 53, 66, DateTimeKind.Unspecified).AddTicks(5479), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "consequuntur",
                            PhotoFileName = "home_deposit_copy.pfm",
                            Price = 0.7653658067932682214549310765m,
                            ProductTypeId = new Guid("739f36aa-a68d-4403-880e-decb2043d028"),
                            Rating = 1150695667,
                            Stock = -1610454430
                        },
                        new
                        {
                            Id = new Guid("d5933fac-b6e4-499b-9d43-883f7cceaaee"),
                            Description = "Velit dolorem corporis.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 4, 11, 20, 55, 330, DateTimeKind.Unspecified).AddTicks(9586), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "nobis",
                            PhotoFileName = "rapids_calculate_practical.m14",
                            Price = 0.8591262005794074655010761927m,
                            ProductTypeId = new Guid("739f36aa-a68d-4403-880e-decb2043d028"),
                            Rating = -785711901,
                            Stock = -818658148
                        },
                        new
                        {
                            Id = new Guid("7d4b1d9f-dc56-464c-9350-a5f47d4f020d"),
                            Description = "Commodi sit id dolorem accusamus aperiam qui illum beatae.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 13, 10, 15, 31, 665, DateTimeKind.Unspecified).AddTicks(5931), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "amet",
                            PhotoFileName = "personal_loan_account_incredible_rubber_bacon_metal.xer",
                            Price = 0.1762598164836307889609111607m,
                            ProductTypeId = new Guid("06bb4b7f-9e8b-4376-bb6b-a794f7cfcd1c"),
                            Rating = 357652983,
                            Stock = -836434968
                        },
                        new
                        {
                            Id = new Guid("a0c38446-a65c-474e-861a-61e8ba609dcf"),
                            Description = "Fugiat voluptatem perspiciatis.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 14, 5, 28, 2, 958, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "occaecati",
                            PhotoFileName = "islands_parks_handmade.mods",
                            Price = 0.0007336392685616688979054662m,
                            ProductTypeId = new Guid("06bb4b7f-9e8b-4376-bb6b-a794f7cfcd1c"),
                            Rating = -35964742,
                            Stock = 1140036655
                        },
                        new
                        {
                            Id = new Guid("bed79659-9343-4626-a092-9d38531e7906"),
                            Description = "Molestias ut autem sed delectus sit blanditiis temporibus.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 24, 19, 49, 8, 712, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "omnis",
                            PhotoFileName = "home_loan_account_fresh.zaz",
                            Price = 0.8965646536099783821875351411m,
                            ProductTypeId = new Guid("739f36aa-a68d-4403-880e-decb2043d028"),
                            Rating = 296633292,
                            Stock = -1439540794
                        },
                        new
                        {
                            Id = new Guid("a2bbc65c-2e42-4d02-809b-e466f4ed52b3"),
                            Description = "Aut esse architecto ea saepe inventore perferendis.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 2, 19, 21, 12, 430, DateTimeKind.Unspecified).AddTicks(7779), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "modi",
                            PhotoFileName = "investment_account_personal_loan_account_instruction_set.gram",
                            Price = 0.435011263194153713064890736m,
                            ProductTypeId = new Guid("06bb4b7f-9e8b-4376-bb6b-a794f7cfcd1c"),
                            Rating = 1120963780,
                            Stock = -230307100
                        },
                        new
                        {
                            Id = new Guid("bec7ca9b-d4df-4baf-9733-5c83b24ffe1b"),
                            Description = "Et et voluptatem vel et cum voluptas cumque et minus.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 6, 21, 15, 34, 647, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "aspernatur",
                            PhotoFileName = "instruction_set.x3db",
                            Price = 0.668648240505590161632829141m,
                            ProductTypeId = new Guid("739f36aa-a68d-4403-880e-decb2043d028"),
                            Rating = -774862265,
                            Stock = 1123145941
                        },
                        new
                        {
                            Id = new Guid("2f36f2b0-ae94-4077-ac87-cb76270768c3"),
                            Description = "Aut consequatur voluptas qui.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 5, 1, 24, 6, 807, DateTimeKind.Unspecified).AddTicks(7892), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "autem",
                            PhotoFileName = "navigate_pennsylvania_website.3ds",
                            Price = 0.1834971273247461196075446211m,
                            ProductTypeId = new Guid("dd9205e8-a3cd-45b8-8c3d-230640f646cd"),
                            Rating = 366097674,
                            Stock = -1545964952
                        },
                        new
                        {
                            Id = new Guid("d4ca001c-8f84-4693-9469-ee72f27eae2a"),
                            Description = "Illo omnis eligendi consequuntur vero officiis enim.",
                            IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 20, 14, 39, 19, 801, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, -3, 0, 0, 0)),
                            Name = "eveniet",
                            PhotoFileName = "sas_administrator_shoal.teacher",
                            Price = 0.7117798803194497755033325904m,
                            ProductTypeId = new Guid("06bb4b7f-9e8b-4376-bb6b-a794f7cfcd1c"),
                            Rating = 214128880,
                            Stock = 334966245
                        });
                });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Discriminator")
                        .IsUnique();

                    b.ToTable("ProductTypes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductType");
                });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeOne", b =>
                {
                    b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                    b.HasDiscriminator().HasValue("TypeOne");

                    b.HasData(
                        new
                        {
                            Id = new Guid("06bb4b7f-9e8b-4376-bb6b-a794f7cfcd1c")
                        });
                });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeThree", b =>
                {
                    b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                    b.HasDiscriminator().HasValue("TypeThree");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd9205e8-a3cd-45b8-8c3d-230640f646cd")
                        });
                });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeTwo", b =>
                {
                    b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                    b.HasDiscriminator().HasValue("TypeTwo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("739f36aa-a68d-4403-880e-decb2043d028")
                        });
                });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Product", b =>
                {
                    b.HasOne("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
