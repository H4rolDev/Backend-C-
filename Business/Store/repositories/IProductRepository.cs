using Bussines.Store.services;

namespace Bussines.Store.repositories {
    public interface IProductRepository {
        public ICategoryService category();
        public IProductService product();
    }
}