using CrmEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmDataAccess.Concrete
{
    public class CrmDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER=DESKTOP-EPQ611O\\SQLEXPRESS;DATABASE=AsyncCrm; INTEGRATED SECURITY= TRUE");
        }  
        public DbSet<TblCari> Cari { get; set; } = null!;
        public DbSet<TblCariYetkili> CariYetkili { get; set; } = null!;
        public DbSet<TblDestek> Destek { get; set; } = null!;
        public DbSet<TblDestekDetay> DestekDetay { get; set; } = null!;
        public DbSet<TblDestekDetayHizmet> DestekDetayHizmet { get; set; } = null!;
        public DbSet<TblDestekDokuman> DestekDokuman { get; set; } = null!;
        public DbSet<TblDurum> Durum { get; set; } = null!;
        public DbSet<TblHizmetAnlasmalari> HizmetAnlasmlari { get; set; } = null!;
        public DbSet<TblHizmetler> Hizmetler { get; set; } = null!;
        public DbSet<TblIlce> Ilce { get; set; } = null!;
        public DbSet<TblKategori> Kategori { get; set; } = null!;
        public DbSet<TblPersonel> Personel { get; set; } = null!;
        public DbSet<TblSehir> Sehir { get; set; } = null!;
        public DbSet<TblSmtpMail> SmtpMail { get; set; } = null!;

    }
}
