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
    //buraya koşullar ve gereklilikler yazılacak
    public class BaslikManager : IBaslikService
    {

        IBaslikDal baslikDal;

        public BaslikManager(IBaslikDal baslikDal)
        {
            this.baslikDal = baslikDal;
        }

        public void addKonu(Baslik baslik)
        {
            baslikDal.Add(baslik);
        }

        public void delete(Baslik baslik)
        {
            baslikDal.Delete(baslik);
        }

        public List<Baslik> GetAll()
        {
            return baslikDal.GetList();
        }

        public Baslik getById(int baslikId)
        {
            return baslikDal.Get(p=> p.baslikNo== baslikId);
        }

        public void update(Baslik baslik)
        {
            baslikDal.Update(baslik);
        }
    }
}
