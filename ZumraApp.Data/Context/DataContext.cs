using System.Data.Entity;
using ZumraApp.Data.Model.Models.Articles;

namespace ZumraApp.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base("ZumraApp.ConnectionString")
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
