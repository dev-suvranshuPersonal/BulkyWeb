using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CatagoryController : Controller
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public CatagoryController(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
        public IActionResult Index()
        {
            var data1 = _applicationDBContext.Category.ToList();
            return View(data1);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
