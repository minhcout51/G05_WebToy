using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using WebToy.Models;
using MongoDB.Driver;
using MongoDB.Bson;
namespace WebToy.Controllers
{
    public class AdminController : Controller
    {
       
        public IActionResult Index() {
            
            return View();
         
        }
      // đang bị lỗi
        public IActionResult GetAllProducts(Product p)
        {
            if (ModelState.IsValid)
            {
                string constr = ConfigurationManager.AppSettings["connectionString"];
                var Client = new MongoClient(constr);
                var DB = Client.GetDatabase("G05_WebToy");
                var collection = DB.GetCollection<Product>("ThongTinSanPham");
                collection.InsertOneAsync(p);
                return RedirectToAction("plist");
            }
            return View();
        }
        public IActionResult AddProduct()
        {

            return View();
        }
    }
}
