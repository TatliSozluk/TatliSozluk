using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKonuService
    {
        public List<Konu> GetAll();
        public Konu getById(int konuId);
        public void addKonu(Konu konu);
        public void update(Konu konu);
        public void delete(Konu konu);

    }
}
