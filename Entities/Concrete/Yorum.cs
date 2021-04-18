using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Yorum :IEntity
    {
        [Key]
        public int yorumNo { get; set; }
        public int uyeNo { get; set; }
        public int baslikNo { get; set; }
        public string yorum { get; set; }
        public string yorumTar { get; set; }
        
    }
}
