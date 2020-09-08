using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class DummyServices : IDummyServices
    {
        SampleDbContext _context;
        public DummyServices(SampleDbContext context)
        {
            _context = context;
        }
        public string method()
        {
            return ("Dependency works");
        }

        public IEnumerable<Users> GetUsers()
        {
            return _context.Set<Users>().AsNoTracking().ToList();

        }
    }
}
