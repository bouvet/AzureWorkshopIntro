using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AzureIntroWorkshop.Database
{
    public class WorkshopDbContext : DbContext
    {
        public WorkshopDbContext(DbContextOptions options) : base(options)
        {
            var conn = (SqlConnection)Database.GetDbConnection();
            conn.AccessToken = new AzureServiceTokenProvider().GetAccessTokenAsync("https://database.windows.net/").Result;
        }
        public virtual DbSet<Workshop> Workshops { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
    }
}
