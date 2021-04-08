using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Baslik : IEntity
    {
        public int uyeNo { get; set; }
        public int konuNo { get; set; }
        public int baslikNo { get; set; }
        public string baslikAd { get; set; }
        public DateTime baslikTar { get; set; }

    }
}
