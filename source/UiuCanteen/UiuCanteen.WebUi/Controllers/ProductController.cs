using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UiuCanteen.Domain.Abstract;
using UiuCanteen.WebUi.Models;

namespace UiuCanteen.WebUi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int pageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;

        }
          public ViewResult List(string category ,int page = 1)
        {
              ProductsListViewModel model = new ProductsListViewModel
              {
                  Products = repository.Products
                                 //.Where(p => category == null || p.Category == category)
                                 .Where(p=> category == null || p.Category == category)
                                 .OrderBy(p => p.ProductId)
                                 .Skip((page - 1) * pageSize)
                                 .Take(pageSize),
                  PagingInfo = new PagingInfo
                  {
                      CurrentPage = page,
                      ItemsPerPage = pageSize,
                      TotalItems = category == null ?
                                    repository.Products.Count() :
                                    repository.Products.Where(p=>p.Category == category).Count()
                  },
                  
                 // CurrentCategory = category
                 CurrentCategory = category


              };
            return View(model);
        }
        
    }
}