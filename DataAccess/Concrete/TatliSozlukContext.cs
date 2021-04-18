using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   public class TatliSozlukContext : DbContext  // bu class veritabanı ile proje class'larını bağlar
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //bağlanılacak veritabanını belirtme
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TatliSozluk2;Trusted_Connection=true");
        }

        //Veritabanı tablolarına karşılık gelen class'ların ilişkilendirilmesi
        public DbSet<Uye> Uye { get; set; }
        public DbSet<Konu> Konu { get; set; }
        public DbSet<Baslik> Baslik { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
    }
}
