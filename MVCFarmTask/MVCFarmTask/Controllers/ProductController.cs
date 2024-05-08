using Microsoft.AspNetCore.Mvc;
using MVCFarmTask.DAL;
using MVCFarmTask.Models;
using MVCFarmTask.ViewModels;

namespace MVCFarmTask.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public ProductController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
            
        }
        public IActionResult Index()
        {

            //Product product1 = new Product
            //{
            //    FullName = "Kelem",
            //    Image = "product-1.png",
            //    Price = 40

            //};

            //Product product2 = new Product
            //{
            //    FullName = "Xiyar",
            //    Image = "product-2.png",
            //    Price = 50


            //};

            //Product product3 = new Product
            //{
            //    FullName = "Pomidor",
            //    Image = "product-1.png",
            //    Price = 70


            //};

            //Product product4 = new Product
            //{
            //    FullName = "Sogan",
            //    Image = "product-2.png",
            //    Price = 40


            //};

            //List<Product> products = new List<Product>() { product1, product2, product3, product4 };
            //_dbcontext.Products.AddRange(products);
            //_dbcontext.SaveChanges();

            List<Product> products = _dbcontext.Products.ToList();

             HomeVM homeVM = new HomeVM
             {
                 Products = products

             };


            return View(homeVM);
        }
    }
}
