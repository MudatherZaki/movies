using Movies.Core.Presistence;
using Movies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Presistence.Repositories
{
    class MoviesRepository: Repository<Movie>
    {
        public MoviesRepository(Context applicationContext): base(applicationContext)
        {

        }
    }
}
