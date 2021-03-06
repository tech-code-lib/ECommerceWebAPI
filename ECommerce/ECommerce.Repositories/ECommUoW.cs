using ECommerce.DAL.Contexts;
using ECommerce.DAL.Tables;
using ECommerce.Repositories.Contract;
using System;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    public class ECommUoW: IDisposable
    {
        private readonly ECommDBContext _dbContext;
        private bool _disposed;

        private IECommRepository<Product> _productRepository;

        public IECommRepository<Product> ProductRepository
        {
            get 
            {
                if (_productRepository == null)
                {
                    _productRepository = new ECommRepository<Product>(_dbContext);
                }
                return _productRepository;
            }
        }

        public ECommUoW(ECommDBContext context)
        {
            _dbContext = context;
        }

        ~ECommUoW()
        {
            Disposing(false);
        }

        public async Task<int> SaveAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected virtual void Disposing(bool disposing)
        {
            if (disposing)
            {
                if (!_disposed)
                {
                    _dbContext.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Disposing(true);
            GC.SuppressFinalize(this);
        }
    }
}
