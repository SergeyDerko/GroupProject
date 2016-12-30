using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Domain.Abstract;

namespace Site.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}