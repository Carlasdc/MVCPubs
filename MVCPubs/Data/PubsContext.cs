using Microsoft.EntityFrameworkCore;
using MVCPubs.Models;
using System.Security.Policy;

namespace MVCPubs.Data
{
    public class PubsContext: DbContext
    {
        public PubsContext(DbContextOptions<PubsContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<TheDiscount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<PubInfo> PubInfos { get; set; }
        public DbSet<ThePublisher> Publishers { get; set; }
        public DbSet<Roysched> Royscheds { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Titleauthor> Titleauthors { get; set; }
        public DbSet<TheTitle> Titles { get; set; }
        public DbSet<Titleview> Titleviews { get; set; }
    }
}
