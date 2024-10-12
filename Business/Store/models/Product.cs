namespace Bussines.Store.models {
    public class Product {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public int Warranty { get; set; }
        public int UtilityPorcentage { get; set; }
        public bool State { get; set; }   
    }

    public class ProductBody {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public int Warranty { get; set; }
        public int UtilityPorcentage { get; set; }
        public bool State { get; set; } 

        public static implicit operator Product(ProductBody rb) {
            if (rb == null) return null;
            return new Product {
                Id = 0,
                CategoryId = rb.CategoryId,
                Image = rb.Image,
                Description = rb.Description,
                Model = rb.Model,
                Brand = rb.Brand,
                SalePrice = rb.SalePrice,
                Stock = rb.Stock,
                Warranty = rb.Warranty,
                UtilityPorcentage = rb.UtilityPorcentage,
                State = true,
            };
        }
    }
}