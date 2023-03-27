﻿namespace BlazorECommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        public Task GetProducts();

        //event Action ProductsChanged;

        //List<Product> AdminProducts { get; set; }
        //string Message { get; set; }
        //int CurrentPage { get; set; }
        //int PageCount { get; set; }
        //string LastSearchText { get; set; }
        //Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
        //Task SearchProducts(string searchText, int page);
        //Task<List<string>> GetProductSearchSuggestions(string searchText);
        //Task GetAdminProducts();
        //Task<Product> CreateProduct(Product product);
        //Task<Product> UpdateProduct(Product product);
        //Task DeleteProduct(Product product);
    }
}