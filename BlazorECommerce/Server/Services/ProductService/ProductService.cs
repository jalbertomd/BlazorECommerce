using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Server.Services.ProductService
{
    public class ProductService: IProductService
    {
        private readonly DataContext _context;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductService(DataContext context/*, IHttpContextAccessor httpContextAccessor*/)
        {
            _context = context;
            //_httpContextAccessor = httpContextAccessor;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;

            //var response = new ServiceResponse<Product>();
            //Product product = null;

            //if (_httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            //{
            //    product = await _context.Products
            //        .Include(p => p.Variants.Where(v => !v.Deleted))
            //        .ThenInclude(v => v.ProductType)
            //        .Include(p => p.Images)
            //        .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted);
            //}
            //else
            //{
            //    product = await _context.Products
            //        .Include(p => p.Variants.Where(v => v.Visible && !v.Deleted))
            //        .ThenInclude(v => v.ProductType)
            //        .Include(p => p.Images)
            //        .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted && p.Visible);
            //}

            //if (product == null)
            //{
            //    response.Success = false;
            //    response.Message = "Sorry, but this product does not exist.";
            //}
            //else
            //{
            //    response.Data = product;
            //}

            //return response;


        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            //Product product = null;

            //if (_httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            //{
            //    product = await _context.Products
            //        .Include(p => p.Variants.Where(v => !v.Deleted))
            //        .ThenInclude(v => v.ProductType)
            //        .Include(p => p.Images)
            //        .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted);
            //}
            //else
            //{
            //    product = await _context.Products
            //        .Include(p => p.Variants.Where(v => v.Visible && !v.Deleted))
            //        .ThenInclude(v => v.ProductType)
            //        .Include(p => p.Images)
            //        .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted && p.Visible);
            //}

            var product = await _context.Products.FindAsync(productId);

            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }
    }
}
