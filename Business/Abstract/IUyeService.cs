using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IUyeService
    {
      public  List<Uye> GetAll();
      public  Uye GetById(int uyeId); // üye id ile uyeyi getirme.
       public void Add(Uye uye);
        public void Delete(Uye uye);
        public void Update(Uye uye);
    }
}
