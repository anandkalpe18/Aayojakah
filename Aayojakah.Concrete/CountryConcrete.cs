using Aayojakah.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aayojakah.Model;

namespace Aayojakah.Concrete
{
    public class CountryConcrete : ICountry
    {
        private DatabaseContext _context;

        public CountryConcrete(DatabaseContext context)
        {
            _context = context;
        }

        public List<Country> ListofCountry()
        {
            return _context.Country.ToList();
        }
    }
}
