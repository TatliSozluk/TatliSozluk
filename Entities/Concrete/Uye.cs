using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Uye : IEntity
    {
        [Key]
        public int uyeNo { get; set; }
        public string uyeNick { get; set; }
        public string uyeMail { get; set; }
        public DateTime uyeDogTar { get; set; }
        public DateTime uyeKatTar { get; set; }
        public char uyeCins { get; set; }
        public string uyeSifre { get; set; }
    }
}
