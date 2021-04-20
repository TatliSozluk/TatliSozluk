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
        IKonuService konuService; IYorumService yorumService; IUyeService uyeService;

        public HomeController(IKonuService konuService, IYorumService yorumService,
            IUyeService uyeService)// Dependency injection
        {
            this.konuService = konuService;
            this.yorumService = yorumService;
            this.uyeService = uyeService;
        }

        public IActionResult Index()
        {
           var yorumlar= yorumService.GetYorumDetails();
            return View(yorumlar);
        }

        public IActionResult KayitOl() // kayıt ol sayfası döner=https://localhost:44362/Home/KayitOl
        {
            return View();
        }

        public IActionResult Login() // giriş sayfası döner sayfası döner=https://localhost:44362/Home/KayitOl
        {
            return View();
        }

        // konuliste fonksiyonu veritabanı ile bağlantı  testi için yazıldı. 
        //Program çalıştırıldığı zaman url olarak = https://localhost:44362/Home/konuliste girerseniz, veritabanından konuları çekiyor.
        public List<Konu> konuliste() 
        {
            return konuService.GetAll();
        }



        public List<Uye> uyeler()
        {
            return uyeService.GetAll();
        }
        
        [HttpPost]
        public void uyeEkle([FromBody]Uye uye)
        {
            uyeService.Add(uye);
        }

    }
}
