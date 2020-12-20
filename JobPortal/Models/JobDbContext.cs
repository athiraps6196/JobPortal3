using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class JobDbContext:DbContext
    {
        public DbSet<Candidates> Candidates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=JobPortal;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"workstation id=jobportall.mssql.somee.com;packet size=4096;user id=athira6196_SQLLogin_1;pwd=xp6h6ih17s;data source=jobportall.mssql.somee.com;persist security info=False;initial catalog=jobportall");
        }
    }
}
