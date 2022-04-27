using QuarterApp.Core;
using QuarterApp.Core.Repositories;
using QuarterApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ICategoryRepository _categoryRepository;
        private IPropertyRepository _propertyRepository;


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public IPropertyRepository PropertyRepository => _propertyRepository = _propertyRepository ?? new PropertyRepository(_context);

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
