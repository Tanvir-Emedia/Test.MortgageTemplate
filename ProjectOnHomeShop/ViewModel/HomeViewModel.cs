using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOnHomeShop.Models;

namespace ProjectOnHomeShop.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        { ClientInfo clientdata = new ClientInfo();
          LocationInfo placedata = new LocationInfo();
        }

        public ClientInfo clientdata { get; set; }
        public LocationInfo placedata { get; set; }
    }
}