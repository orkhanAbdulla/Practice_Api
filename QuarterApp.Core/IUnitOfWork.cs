using QuarterApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Core
{
    public interface IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get;  }
        public IPropertyRepository PropertyRepository { get;  }
        Task CommitAsync();
    }
}
