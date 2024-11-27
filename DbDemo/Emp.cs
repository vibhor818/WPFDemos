using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class EmpContext:DbContext
    {
        public EmpContext()
        {
            
        }
        //public EmpContext(DbContextOptions<EmpContext> context):base(context)
        //{
            
        //}
        public DbSet<Emp> Emp { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=empdb;trusted_Connection=true");
        }
    }
    //public static class VBDbInitaizer
    //{
    //    public static void Initialize(EmpContext context)
    //    {

    //    }
    //}
}
