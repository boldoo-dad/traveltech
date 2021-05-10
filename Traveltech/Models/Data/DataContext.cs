using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveltech.Models.Widgets;

namespace Traveltech.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DateFormat> DateFormats { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Sumbol> Sumbols { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TimeFormat> TimeFormats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WebSite> WebSites { get; set; }
        public DbSet<Week> Weeks { get; set; }




        public DbSet<Audio> Audios { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Search> Searches { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
