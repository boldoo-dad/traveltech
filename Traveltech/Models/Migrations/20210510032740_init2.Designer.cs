﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Traveltech.Models.Data;

namespace Traveltech.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210510032740_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "PostsId");

                    b.HasIndex("PostsId");

                    b.ToTable("CategoryPost");
                });

            modelBuilder.Entity("Traveltech.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("HouseNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("ContactId");

                    b.HasIndex("LandId");

                    b.HasIndex("StateId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Traveltech.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Traveltech.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Traveltech.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Traveltech.Models.DateFormat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("DateFormats");
                });

            modelBuilder.Entity("Traveltech.Models.Footer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WebSiteId");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("Traveltech.Models.Header", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WebSiteId");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("Traveltech.Models.HomePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomePages");
                });

            modelBuilder.Entity("Traveltech.Models.Land", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lands");
                });

            modelBuilder.Entity("Traveltech.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Traveltech.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("Traveltech.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FooterId")
                        .HasColumnType("int");

                    b.Property<int?>("HeaderId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.HasIndex("HeaderId");

                    b.HasIndex("PositionId");

                    b.ToTable("Menus");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Menu");
                });

            modelBuilder.Entity("Traveltech.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("ArchiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isAllowedComment")
                        .HasColumnType("bit");

                    b.Property<bool?>("isPublished")
                        .HasColumnType("bit");

                    b.Property<bool?>("isTemplate")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Traveltech.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Traveltech.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("ArchiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Traveltech.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("HomePageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HomePageId");

                    b.HasIndex("PageId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Traveltech.Models.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SumbolId")
                        .HasColumnType("int");

                    b.Property<string>("SymbolId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SumbolId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("Traveltech.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("LandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LandId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Traveltech.Models.Sumbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sumbols");
                });

            modelBuilder.Entity("Traveltech.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Traveltech.Models.TimeFormat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("TimeFormats");
                });

            modelBuilder.Entity("Traveltech.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("WebSiteId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Traveltech.Models.WebSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("DateFormatId")
                        .HasColumnType("int");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FooterId")
                        .HasColumnType("int");

                    b.Property<int?>("HeaderId")
                        .HasColumnType("int");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Membership")
                        .HasColumnType("bit");

                    b.Property<string>("TagLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeFormatId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DateFormatId");

                    b.HasIndex("FooterId");

                    b.HasIndex("HeaderId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("TimeFormatId");

                    b.ToTable("WebSites");
                });

            modelBuilder.Entity("Traveltech.Models.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medias");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Media");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Search", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Searches");
                });

            modelBuilder.Entity("Traveltech.Models.MenuItem", b =>
                {
                    b.HasBaseType("Traveltech.Models.Menu");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.HasIndex("MenuId");

                    b.HasDiscriminator().HasValue("MenuItem");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Audio", b =>
                {
                    b.HasBaseType("Traveltech.Models.Widgets.Media");

                    b.HasDiscriminator().HasValue("Audio");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Video", b =>
                {
                    b.HasBaseType("Traveltech.Models.Widgets.Media");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.HasOne("Traveltech.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveltech.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveltech.Models.Address", b =>
                {
                    b.HasOne("Traveltech.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Traveltech.Models.Widgets.Contact", null)
                        .WithMany("Addresses")
                        .HasForeignKey("ContactId");

                    b.HasOne("Traveltech.Models.Land", "Land")
                        .WithMany()
                        .HasForeignKey("LandId");

                    b.HasOne("Traveltech.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.Navigation("City");

                    b.Navigation("Land");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Traveltech.Models.City", b =>
                {
                    b.HasOne("Traveltech.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Traveltech.Models.Footer", b =>
                {
                    b.HasOne("Traveltech.Models.WebSite", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteId");

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Traveltech.Models.Header", b =>
                {
                    b.HasOne("Traveltech.Models.WebSite", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteId");

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Traveltech.Models.Menu", b =>
                {
                    b.HasOne("Traveltech.Models.Footer", "Footer")
                        .WithMany("Menus")
                        .HasForeignKey("FooterId");

                    b.HasOne("Traveltech.Models.Header", "Header")
                        .WithMany("Menus")
                        .HasForeignKey("HeaderId");

                    b.HasOne("Traveltech.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Footer");

                    b.Navigation("Header");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Traveltech.Models.Position", b =>
                {
                    b.HasOne("Traveltech.Models.Position", null)
                        .WithMany("Positions")
                        .HasForeignKey("PositionId");
                });

            modelBuilder.Entity("Traveltech.Models.Section", b =>
                {
                    b.HasOne("Traveltech.Models.HomePage", "HomePage")
                        .WithMany("Sections")
                        .HasForeignKey("HomePageId");

                    b.HasOne("Traveltech.Models.Page", "Page")
                        .WithMany("Sections")
                        .HasForeignKey("PageId");

                    b.Navigation("HomePage");

                    b.Navigation("Page");
                });

            modelBuilder.Entity("Traveltech.Models.SocialMedia", b =>
                {
                    b.HasOne("Traveltech.Models.Sumbol", "Sumbol")
                        .WithMany()
                        .HasForeignKey("SumbolId");

                    b.Navigation("Sumbol");
                });

            modelBuilder.Entity("Traveltech.Models.State", b =>
                {
                    b.HasOne("Traveltech.Models.Land", "Land")
                        .WithMany("States")
                        .HasForeignKey("LandId");

                    b.Navigation("Land");
                });

            modelBuilder.Entity("Traveltech.Models.User", b =>
                {
                    b.HasOne("Traveltech.Models.Client", "Client")
                        .WithMany("Users")
                        .HasForeignKey("ClientId");

                    b.HasOne("Traveltech.Models.WebSite", null)
                        .WithMany("Users")
                        .HasForeignKey("WebSiteId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Traveltech.Models.WebSite", b =>
                {
                    b.HasOne("Traveltech.Models.Client", "Client")
                        .WithMany("WebSites")
                        .HasForeignKey("ClientId");

                    b.HasOne("Traveltech.Models.DateFormat", "DateFormat")
                        .WithMany("WebSites")
                        .HasForeignKey("DateFormatId");

                    b.HasOne("Traveltech.Models.Footer", "Footer")
                        .WithMany()
                        .HasForeignKey("FooterId");

                    b.HasOne("Traveltech.Models.Header", "Header")
                        .WithMany()
                        .HasForeignKey("HeaderId");

                    b.HasOne("Traveltech.Models.Language", "Language")
                        .WithMany("Websites")
                        .HasForeignKey("LanguageId");

                    b.HasOne("Traveltech.Models.TimeFormat", "TimeFormat")
                        .WithMany()
                        .HasForeignKey("TimeFormatId");

                    b.Navigation("Client");

                    b.Navigation("DateFormat");

                    b.Navigation("Footer");

                    b.Navigation("Header");

                    b.Navigation("Language");

                    b.Navigation("TimeFormat");
                });

            modelBuilder.Entity("Traveltech.Models.MenuItem", b =>
                {
                    b.HasOne("Traveltech.Models.Menu", "Parent")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Traveltech.Models.Client", b =>
                {
                    b.Navigation("Users");

                    b.Navigation("WebSites");
                });

            modelBuilder.Entity("Traveltech.Models.DateFormat", b =>
                {
                    b.Navigation("WebSites");
                });

            modelBuilder.Entity("Traveltech.Models.Footer", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("Traveltech.Models.Header", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("Traveltech.Models.HomePage", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Traveltech.Models.Land", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Traveltech.Models.Language", b =>
                {
                    b.Navigation("Websites");
                });

            modelBuilder.Entity("Traveltech.Models.Menu", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Traveltech.Models.Page", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Traveltech.Models.Position", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("Traveltech.Models.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Traveltech.Models.WebSite", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Traveltech.Models.Widgets.Contact", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}