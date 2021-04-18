using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Konu : IEntity
    {
        [Key]
        public int konuNo { get; set; }
        public string konuAd { get; set; }
    }
}
