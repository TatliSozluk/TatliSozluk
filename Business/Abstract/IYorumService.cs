using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYorumService
    {
        public List<Yorum> GetAll();
        public Yorum GetById(int id);
        public void Add(Yorum yorum);
        public void Delete(Yorum yorum);
        public void Update(Yorum yorum);
        List<YorumDto> GetYorumDetails();
    }
}
