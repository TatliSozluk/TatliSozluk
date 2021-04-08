using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace Business.Concrete
{
   public class KonuManager : IKonuService
    {
        IKonuDal konuDal;
       
        public KonuManager(IKonuDal konuDal)
        {
            this.konuDal = konuDal;
        }

        public List<Konu> GetAll()
        {
            return konuDal.GetList().ToList();
        }
    }
}
