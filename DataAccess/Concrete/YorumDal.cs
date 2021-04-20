using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class YorumDal : EfEntityRepositoryBase<Yorum, TatliSozlukContext>, IYorumDal
    {
        public List<YorumDto> GetYorumDetails()
        {
            using (TatliSozlukContext context = new TatliSozlukContext())
            {
                var result = from y in context.Yorum
                             join u in context.Uye on y.uyeNo equals u.uyeNo
                             join b in context.Baslik on y.baslikNo equals b.baslikNo                          
                             select new YorumDto
                             {
                                 YorumId=y.yorumNo, Yorum=y.yorum, UyeNick=u.uyeNick ,
                                 BaslikAd=b.baslikAd, YorumTarihi=y.yorumTar
                             };
                return result.ToList();
            }
        }
    }
}
