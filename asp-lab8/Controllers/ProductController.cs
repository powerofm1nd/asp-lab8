using asp_lab8.Model;
using Microsoft.AspNetCore.Mvc;

namespace asp_lab8.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    private List<ProductModel> GetProducts()
    {
        var products = new List<ProductModel>();
        products.Add(new ProductModel { Id = 1, Name = "Apple", Price = 10, CreatedDate = DateTime.Now });
        products.Add(new ProductModel { Id = 2, Name = "Banana", Price = 5, CreatedDate = DateTime.Now });
        products.Add(new ProductModel { Id = 3, Name = "Orange", Price = 7, CreatedDate = DateTime.Now });
        products.Add(new ProductModel { Id = 4, Name = "Grapes", Price = 12, CreatedDate = DateTime.Now });
        products.Add(new ProductModel { Id = 5, Name = "Pineapple", Price = 15, CreatedDate = DateTime.Now });
        products.Add(new ProductModel { Id = 6, Name = "Mango", Price = 8, CreatedDate = DateTime.Now });
        products.Add(new ProductModel { Id = 7, Name = "Strawberry", Price = 20, CreatedDate = DateTime.Now });

        return products;
    }
    
    public IActionResult ProductsAsList()
    {
        var products = GetProducts();
        return View(products);
    }
    
    public IActionResult ProductsAsTable()
    {
        var products = GetProducts();
        return View(products);
    }
}