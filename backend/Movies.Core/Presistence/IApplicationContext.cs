using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Presistence
{
    public interface IApplicationContext
    {
        void BeginTransaction();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void Commit();
        void Rollback();
    }
}
