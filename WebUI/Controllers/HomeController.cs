using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        IKonuService konuService;

        public HomeController(IKonuService konuService)
        {
            this.konuService = konuService;
        }

        public IActionResult Index()
        {
            return View();
        }

        // konuliste fonksiyonu veritabanı ile bağlantı  testi için yazıldı. 
        //Program çalıştırıldığı zaman url olarak = https://localhost:44362/Home/konuliste girerseniz, veritabanından konuları çekiyor.
        public List<Konu> konuliste() 

        {
            return konuService.GetAll().ToList();
        }
    }
}
