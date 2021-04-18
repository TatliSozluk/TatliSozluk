using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IBaslikService
    {
        public List<Baslik> GetAll();
        public Baslik getById(int baslikId);
        public void addKonu(Baslik baslik);
        public void update(Baslik baslik);
        public void delete(Baslik baslik);
    }
}
