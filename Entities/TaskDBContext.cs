using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Entities
{
    public class TaskDBContext : DbContext
    {

        public DbSet<clsTag> Tags { get; set; }
        public DbSet<clsTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<clsTag>().ToTable("Tags");
            modelBuilder.Entity<clsTask>().ToTable("Tasks");


            string dbJson = System.IO.File.ReadAllText("tag.json");
            List<clsTag>? tags = JsonSerializer.Deserialize<List<clsTag>>(dbJson);

            foreach (clsTag tag in tags)
            {
                modelBuilder.Entity<clsTag>().HasData(tag);
            }

            string dbJson2 = System.IO.File.ReadAllText("task.json");
            List<clsTask>? tags2 = JsonSerializer.Deserialize<List<clsTask>>(dbJson2);

            foreach (clsTask tag in tags2)
            {
                modelBuilder.Entity<clsTask>().HasData(tag);
            }

        }
    }
}
