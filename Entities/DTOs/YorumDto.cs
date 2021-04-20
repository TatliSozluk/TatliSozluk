using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class YorumDto: IDto //Bu class yorum detayları için. Yani üye,yorum,başlık tablolarının join'i için 
    {
        public int YorumId { get; set; }
        public string Yorum { get; set; }
        public string UyeNick { get; set; }
        public string BaslikAd { get; set; }
        public  string YorumTarihi { get; set; }
    }
}
