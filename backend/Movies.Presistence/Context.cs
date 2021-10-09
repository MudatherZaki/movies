using Microsoft.EntityFrameworkCore;
using Movies.Core.Domain;
using Movies.Core.Presistence;
using Movies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Presistence
{
    public class Context : DbContext, IApplicationContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public void BeginTransaction()
        {
            if (Database.CurrentTransaction == null)
                Database.BeginTransaction();
        }

        public void Commit()
        {
            if (Database.CurrentTransaction != null)
                Database.CommitTransaction();
        }

        public void Rollback()
        {
            if (Database.CurrentTransaction != null)
                Database.RollbackTransaction();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

    }
}
