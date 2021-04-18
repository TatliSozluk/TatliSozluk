using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Baslik : IEntity   //Veritabanındaki Baslik Tablosuna karşılık gelen class
    {
        [Key]
        public int baslikNo { get; set; }
        public int uyeNo { get; set; }
        public int konuNo { get; set; }
        public string baslikTar { get; set; }
        public string baslikAd { get; set; }
        

    }
}
