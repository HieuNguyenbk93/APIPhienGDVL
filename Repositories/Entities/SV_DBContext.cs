using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model;

namespace Repositories.Entities
{
    public partial class SV_DBContext : DbContext
    {
        public SV_DBContext()
        {
        }

        public SV_DBContext(DbContextOptions<SV_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PgdXacNhanNld> PgdXacNhanNld { get; set; }

        public virtual DbSet<PgdXacNhanDN> PgdXacNhanDN { get; set; }
        public virtual DbSet<HisDnDangKy> HisDnDangKy { get; set; }
        public virtual DbSet<HisDnDuocMoi> HisDnDuocMoi { get; set; }
        public virtual DbSet<HIS_PhienGiaoDich> HIS_PhienGiaoDich { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=14.177.236.88,1434;Database=QLNV_VLHN;Persist Security Info=True;User ID=vlhn;Password=12345678@a;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PgdXacNhanNld>(entity =>
            {
                entity.ToTable("PGD_XacNhanNLD");
            });
            modelBuilder.Entity<PgdXacNhanDN>(entity =>
            {
                entity.ToTable("PGD_XacNhanDN");
            });
            modelBuilder.Entity<HisDnDuocMoi>(entity =>
            {
                entity.ToTable("HIS_DnDuocMoi");
            });
            modelBuilder.Entity<HisDnDangKy>(entity =>
            {
                entity.ToTable("HIS_DnDangKy");
            });
            modelBuilder.Entity<HIS_PhienGiaoDich>(entity =>
            {
                entity.ToTable("HIS_PhienGiaoDich");
            });
        }
    }
}
