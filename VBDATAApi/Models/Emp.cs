using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Xml.Linq;

namespace VBDATAApi.Models
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class VBContext:DbContext
    {
        public VBContext(DbContextOptions<VBContext> context):base(context)
        {
            
        }
        public DbSet<Emp> Emps { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>().HasData(
            new Emp
            {
                Id = 1,
                Name = "John",
                Address = "123abc"
            },
            new Emp { 
                Id = 2,
                Name = "Steve",
                Address = "UK"
            }
            );
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
           
    }
}
