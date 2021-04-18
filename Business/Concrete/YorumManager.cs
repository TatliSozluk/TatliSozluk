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
   public class YorumManager:IYorumService
    {
        IYorumDal yorumDal;

        //Dataccess katmanı ile bağlantı için dependency injection kullanıldı.
        public YorumManager(IYorumDal yorumDal)
        {
            this.yorumDal = yorumDal;
        }

        public void Add(Yorum yorum)
        {
            yorumDal.Add(yorum);
        }

        public void Delete(Yorum yorum)
        {
            yorumDal.Delete(yorum);
        }

        public List<Yorum> GetAll()
        {
            return yorumDal.GetList();
        }

        public Yorum GetById(int yorumId)
        {
            return yorumDal.Get(p=> p.yorumNo==yorumId);
        }

        public void Update(Yorum yorum)
        {
            yorumDal.Update(yorum);
        }
    }
}
