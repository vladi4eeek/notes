using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet для ваших моделей даних, які відображають таблиці в базі даних
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Додайте власні конфігурації моделі, якщо потрібно
        }
    }
}
