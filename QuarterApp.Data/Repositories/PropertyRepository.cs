using QuarterApp.Core.Entities;
using QuarterApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Data.Repositories
{
    class PropertyRepository : Repository<Property>,IPropertyRepository
    {
        private readonly AppDbContext _context;

        public PropertyRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
