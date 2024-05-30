using Microsoft.EntityFrameworkCore;

namespace WebApiUploadImportExcel.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Planilha> Planilhas { get; set; }
    }


    public class Planilha
    {
        public int Id { get; set; }
        public string? Coluna1 { get; set; }
        public string? Coluna2 { get; set; }
    }
}
