using BookLibraryDTO.Model;
using BookLibraryDTO.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDTO.DAO
{
    public class MyDbContext:DbContext
    {public DbSet<BookEntity> Book { get; set; }
        public DbSet<AuthorEntity> Author { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = ConstantUtility.connectionStringYTRA;

            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
