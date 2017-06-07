using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectOnHomeShop.Models;
using ProjectOnHomeShop.ViewModel;

namespace ProjectOnHomeShop.Controllers
{
    public class HomeController : Controller
    {
        HomeShopEntities _db = new HomeShopEntities();
        // GET: Home
       [HttpGet]
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult ClientInfo(HomeViewModel model)
        {
            ClientInfo clientinformation = new ClientInfo
            {
                Title = model.clientdata.Title,
                FirstName = model.clientdata.FirstName,
                LastName = model.clientdata.LastName,
                Email = model.clientdata.Email,
                PhoneNo = model.clientdata.PhoneNo,
                Country = model.clientdata.Country,
                PostCode = model.clientdata.PostCode
            };
            _db.ClientInfoes.Add(clientinformation);
            _db.SaveChanges();
            
            return RedirectToAction("Index", "client");
        }
        [HttpPost]
        public ActionResult LocationInfo(HomeViewModel model)

        {
            LocationInfo locationinformation = new LocationInfo
            { AddressLine1 = model.placedata.AddressLine1,
                AddressLine2 = model.placedata.AddressLine2,
                AddressLine3 = model.placedata.AddressLine3,
                City = model.placedata.City,
                Town = model.placedata.Town,
                PostCode = model.placedata.PostCode
            
            };
            _db.LocationInfoes.Add(locationinformation);
            _db.SaveChanges();

            return View("Index");
        }
    }
}