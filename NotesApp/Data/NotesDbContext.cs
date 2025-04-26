using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Data
{
    public class NotesDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options)
        {
        }

        public NotesDbContext() // за старото поведение без опции
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // Много важно: само ако няма вече подадени настройки!
            {
                optionsBuilder.UseMySql(
                    "server=localhost;database=notesdb;user=root;password=2658;",
                    new MySqlServerVersion(new Version(8, 0, 41))
                );
            }
        }
    }
}
