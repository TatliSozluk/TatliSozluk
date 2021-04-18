using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UyeManager : IUyeService
    {
        IUyeDal uyeDal;

        public UyeManager(IUyeDal uyeDal)
        {
            this.uyeDal = uyeDal;
        }

        public void Add(Uye uye)
        {
            uyeDal.Add(uye);
        }

        public void Delete(Uye uye)
        {
            uyeDal.Delete(uye);
        }

        public List<Uye> GetAll() // bu fonksiyona sorgu filtre yazılmaz ise bütün üyeleri getirir. filtre yazılırsa filtreye göre getirir.
        {
            return uyeDal.GetList();
        }

        public Uye GetById(int uyeId)
        {
           return uyeDal.Get(p=> p.uyeNo==uyeId);
        }

        public void Update(Uye uye)
        {
            uyeDal.Update(uye);
        }
    }
}
