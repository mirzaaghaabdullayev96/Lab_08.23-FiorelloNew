
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace MVC_Pronia_Template.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}