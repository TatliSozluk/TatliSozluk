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

        public void addKonu(Konu konu)
        {
            konuDal.Add(konu);
        }

        public void delete(Konu konu)
        {
            konuDal.Delete(konu);
        }

        public List<Konu> GetAll()
        {
            return konuDal.GetList();
        }

        public Konu getById(int konuId)
        {
           return konuDal.Get(p=> p.konuNo == konuId);
        }

        public void update(Konu konu)
        {
            konuDal.Update(konu);
        }
    }
}
