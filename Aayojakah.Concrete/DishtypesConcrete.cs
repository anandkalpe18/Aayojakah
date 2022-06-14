using Aayojakah.Interface;
using Aayojakah.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aayojakah.Concrete
{
    public class DishtypesConcrete : IDishtypes
    {
        private DatabaseContext _context;

        public DishtypesConcrete(DatabaseContext context)
        {
            _context = context;
        }

        public List<Dishtypes> GetDishtypeList()
        {
            try
            {
                return _context.Dishtypes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
