
namespace RTT.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<ClientDetails>().HasData(
                new ClientDetails
                {
                    Id = 1,
                    Name = "A Client",
                    Gender = "M",
                    Status = 1,
                },
                new ClientDetails
                {
                    Id = 2,
                    Name = "B Client",
                    Gender = "F",
                    Status = 0,
                },
                 new ClientDetails
                 {
                     Id = 3,
                     Name = "C Client",
                     Gender = "M",
                     Status = 1,
                 },
                new ClientDetails
                {
                    Id = 4,
                    Name = "D Client",
                    Gender = "F",
                    Status = 0,
                },
                new ClientDetails
                {
                    Id = 5,
                    Name = "E Client",
                    Gender = "M",
                    Status = 1,
                },
                new ClientDetails
                {
                    Id = 6,
                    Name = "F Client",
                    Gender = "F",
                    Status = 0,
                },
                 new ClientDetails
                 {
                     Id = 7,
                     Name = "G Client",
                     Gender = "M",
                     Status = 1,
                 },
                new ClientDetails
                {
                    Id = 8,
                    Name = "H Client",
                    Gender = "F",
                    Status = 0,
                }
            );
        }
        public DbSet<ClientDetails> clientDetails { get; set; }

        public DbSet<ClientContact> clientContacts { get; set; }

        public DbSet<ClientAddress> clientAddresses { get; set; }
    }
}

