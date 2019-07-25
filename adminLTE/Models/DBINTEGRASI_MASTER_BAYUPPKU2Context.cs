﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace adminLTE.Models
{
    public partial class DBINTEGRASI_MASTER_BAYUPPKU2Context : DbContext
    {
        public DBINTEGRASI_MASTER_BAYUPPKU2Context()
        {
        }

        public DBINTEGRASI_MASTER_BAYUPPKU2Context(DbContextOptions<DBINTEGRASI_MASTER_BAYUPPKU2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AnggotaOrmawa> AnggotaOrmawa { get; set; }
        public virtual DbSet<BiodataOrang> BiodataOrang { get; set; }
        public virtual DbSet<DaftarDokumenOrmawa> DaftarDokumenOrmawa { get; set; }
        public virtual DbSet<DokumenOrmawa> DokumenOrmawa { get; set; }
        public virtual DbSet<JabatanOrmawa> JabatanOrmawa { get; set; }
        public virtual DbSet<JenisKegiatanOrmawa> JenisKegiatanOrmawa { get; set; }
        public virtual DbSet<JenisOrganisasi> JenisOrganisasi { get; set; }
        public virtual DbSet<KalenderKegiatanOrmawa> KalenderKegiatanOrmawa { get; set; }
        public virtual DbSet<KegiatanOrmawa> KegiatanOrmawa { get; set; }
        public virtual DbSet<Mahasiswa> Mahasiswa { get; set; }
        public virtual DbSet<MahasiswaDiploma> MahasiswaDiploma { get; set; }
        public virtual DbSet<MahasiswaDoktor> MahasiswaDoktor { get; set; }
        public virtual DbSet<MahasiswaMagister> MahasiswaMagister { get; set; }
        public virtual DbSet<MahasiswaSarjana> MahasiswaSarjana { get; set; }
        public virtual DbSet<Orang> Orang { get; set; }
        public virtual DbSet<OrganisasiOrmawa> OrganisasiOrmawa { get; set; }
        public virtual DbSet<PengajuanProposalKegiatan> PengajuanProposalKegiatan { get; set; }
        public virtual DbSet<StatusPengajuan> StatusPengajuan { get; set; }
        public virtual DbSet<StrukturalOrmawa> StrukturalOrmawa { get; set; }
        public virtual DbSet<TahapanPengajuan> TahapanPengajuan { get; set; }
        public virtual DbSet<TipeKegiatanOrmawa> TipeKegiatanOrmawa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.17.0.136;Database=DBINTEGRASI_MASTER_BAYUPPKU2;uid=sys-ormawa;pwd=PKLormawa1p8;ConnectRetryCount=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AnggotaOrmawa>(entity =>
            {
                entity.ToTable("AnggotaOrmawa", "OrmMst");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MahasiswaId).HasColumnName("MahasiswaID");

                entity.Property(e => e.OrganisasiOrmawaId).HasColumnName("OrganisasiOrmawaID");

                entity.Property(e => e.TanggalBergabung).HasColumnType("date");

                entity.HasOne(d => d.Mahasiswa)
                    .WithMany(p => p.AnggotaOrmawa)
                    .HasForeignKey(d => d.MahasiswaId)
                    .HasConstraintName("FK_AnggotaOrmawa_Mahasiswa");

                entity.HasOne(d => d.OrganisasiOrmawa)
                    .WithMany(p => p.AnggotaOrmawa)
                    .HasForeignKey(d => d.OrganisasiOrmawaId)
                    .HasConstraintName("FK_AnggotaOrmawa_OrganisasiOrmawa");
            });

            modelBuilder.Entity<BiodataOrang>(entity =>
            {
                entity.ToTable("BiodataOrang", "IPBMst");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

                entity.Property(e => e.AsalNegaraId).HasColumnName("AsalNegaraID");

                entity.Property(e => e.GolonganDarahId).HasColumnName("GolonganDarahID");

                entity.Property(e => e.PekerjaanId).HasColumnName("PekerjaanID");

                entity.Property(e => e.PengubahId).HasColumnName("PengubahID");

                entity.Property(e => e.PertamaMerokok)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusKawinId).HasColumnName("StatusKawinID");

                entity.Property(e => e.SukuBangsaId).HasColumnName("SukuBangsaID");

                entity.Property(e => e.WargaNegaraId).HasColumnName("WargaNegaraID");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.BiodataOrang)
                    .HasForeignKey<BiodataOrang>(d => d.Id)
                    .HasConstraintName("FK_Biodata_Orang");
            });

            modelBuilder.Entity<DaftarDokumenOrmawa>(entity =>
            {
                entity.ToTable("DaftarDokumenOrmawa", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DokumenOrmawaId).HasColumnName("DokumenOrmawaID");

                entity.Property(e => e.PengajuanProposalKegiatanId).HasColumnName("PengajuanProposalKegiatanID");

                entity.HasOne(d => d.DokumenOrmawa)
                    .WithMany(p => p.DaftarDokumenOrmawa)
                    .HasForeignKey(d => d.DokumenOrmawaId)
                    .HasConstraintName("FK_DaftarDokumenOrmawa_DokumenOrmawa");

                entity.HasOne(d => d.PengajuanProposalKegiatan)
                    .WithMany(p => p.DaftarDokumenOrmawa)
                    .HasForeignKey(d => d.PengajuanProposalKegiatanId)
                    .HasConstraintName("FK_DaftarDokumenOrmawa_PengajuanProposalKegiatan");
            });

            modelBuilder.Entity<DokumenOrmawa>(entity =>
            {
                entity.ToTable("DokumenOrmawa", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JenisDokumenId).HasColumnName("JenisDokumenID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Urldokumen)
                    .HasColumnName("URLDokumen")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<JabatanOrmawa>(entity =>
            {
                entity.ToTable("JabatanOrmawa", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JenisKegiatanOrmawa>(entity =>
            {
                entity.ToTable("JenisKegiatanOrmawa", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JenisOrganisasi>(entity =>
            {
                entity.ToTable("JenisOrganisasi", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KalenderKegiatanOrmawa>(entity =>
            {
                entity.ToTable("KalenderKegiatanOrmawa", "OrmHis");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KegiatanOrmawaId).HasColumnName("KegiatanOrmawaID");

                entity.Property(e => e.Tmt)
                    .HasColumnName("TMT")
                    .HasColumnType("date");

                entity.Property(e => e.Tst)
                    .HasColumnName("TST")
                    .HasColumnType("date");

                entity.HasOne(d => d.KegiatanOrmawa)
                    .WithMany(p => p.KalenderKegiatanOrmawa)
                    .HasForeignKey(d => d.KegiatanOrmawaId)
                    .HasConstraintName("FK_KalenderKegiatanOrmawa_KegiatanOrmawa");
            });

            modelBuilder.Entity<KegiatanOrmawa>(entity =>
            {
                entity.ToTable("KegiatanOrmawa", "OrmTrx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrganisasiOrmawaId).HasColumnName("OrganisasiOrmawaID");

                entity.Property(e => e.PengajuanProposalKegiatanId).HasColumnName("PengajuanProposalKegiatanID");

                entity.HasOne(d => d.OrganisasiOrmawa)
                    .WithMany(p => p.KegiatanOrmawa)
                    .HasForeignKey(d => d.OrganisasiOrmawaId)
                    .HasConstraintName("FK_KegiatanOrmawa_OrganisasiOrmawa");

                entity.HasOne(d => d.PengajuanProposalKegiatan)
                    .WithMany(p => p.KegiatanOrmawa)
                    .HasForeignKey(d => d.PengajuanProposalKegiatanId)
                    .HasConstraintName("FK_KegiatanOrmawa_PengajuanProposalKegiatan");
            });

            modelBuilder.Entity<Mahasiswa>(entity =>
            {
                entity.ToTable("Mahasiswa", "AkdMst");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nimkey)
                    .HasColumnName("nimkey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrangId).HasColumnName("OrangID");

                entity.Property(e => e.StrataId).HasColumnName("StrataID");

                entity.HasOne(d => d.Orang)
                    .WithMany(p => p.Mahasiswa)
                    .HasForeignKey(d => d.OrangId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Mahasiswa_Orang");
            });

            modelBuilder.Entity<MahasiswaDiploma>(entity =>
            {
                entity.ToTable("MahasiswaDiploma", "AkdMst");

                entity.HasIndex(e => e.MahasiswaId)
                    .HasName("UQ_MahasiswaDiploma")
                    .IsUnique();

                entity.HasIndex(e => e.Nim);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bpmp).HasColumnName("BPMP");

                entity.Property(e => e.JalurMasukId).HasColumnName("JalurMasukID");

                entity.Property(e => e.MahasiswaId).HasColumnName("MahasiswaID");

                entity.Property(e => e.Nim)
                    .IsRequired()
                    .HasColumnName("NIM")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PembimbingAkademik)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PindahanPt)
                    .HasColumnName("PindahanPT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramKeahlianId).HasColumnName("ProgramKeahlianID");

                entity.Property(e => e.StatusAkademikId).HasColumnName("StatusAkademikID");

                entity.Property(e => e.TahunAkademikId).HasColumnName("TahunAkademikID");

                entity.Property(e => e.TahunSemesterMasukId).HasColumnName("TahunSemesterMasukID");

                entity.Property(e => e.TanggalMasuk).HasColumnType("date");

                entity.HasOne(d => d.Mahasiswa)
                    .WithOne(p => p.MahasiswaDiploma)
                    .HasForeignKey<MahasiswaDiploma>(d => d.MahasiswaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MahasiswaDiploma_Mahasiswa");
            });

            modelBuilder.Entity<MahasiswaDoktor>(entity =>
            {
                entity.ToTable("MahasiswaDoktor", "AkdMst");

                entity.HasIndex(e => e.MahasiswaId)
                    .HasName("UQ_MahasiswaDoktor")
                    .IsUnique();

                entity.HasIndex(e => e.Nim);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GelarBelakang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GelarDepan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JalurMasukId).HasColumnName("JalurMasukID");

                entity.Property(e => e.MahasiswaId).HasColumnName("MahasiswaID");

                entity.Property(e => e.MayorId).HasColumnName("MayorID");

                entity.Property(e => e.Nim)
                    .IsRequired()
                    .HasColumnName("NIM")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAkademikId).HasColumnName("StatusAkademikID");

                entity.Property(e => e.TahunAkademikId).HasColumnName("TahunAkademikID");

                entity.Property(e => e.TahunSemesterMasukId).HasColumnName("TahunSemesterMasukID");

                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

                entity.HasOne(d => d.Mahasiswa)
                    .WithOne(p => p.MahasiswaDoktor)
                    .HasForeignKey<MahasiswaDoktor>(d => d.MahasiswaId)
                    .HasConstraintName("FK_MahasiswaDoktor_Mahasiswa");
            });

            modelBuilder.Entity<MahasiswaMagister>(entity =>
            {
                entity.ToTable("MahasiswaMagister", "AkdMst");

                entity.HasIndex(e => e.MahasiswaId)
                    .HasName("UQ_MahasiswaMagister")
                    .IsUnique();

                entity.HasIndex(e => e.Nim);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GelarBelakang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GelarDepan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JalurMasukId).HasColumnName("JalurMasukID");

                entity.Property(e => e.MahasiswaId).HasColumnName("MahasiswaID");

                entity.Property(e => e.MayorId).HasColumnName("MayorID");

                entity.Property(e => e.Nim)
                    .IsRequired()
                    .HasColumnName("NIM")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Sponsor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAkademikId).HasColumnName("StatusAkademikID");

                entity.Property(e => e.TahunAkademikId).HasColumnName("TahunAkademikID");

                entity.Property(e => e.TahunSemesterMasukId).HasColumnName("TahunSemesterMasukID");

                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

                entity.HasOne(d => d.Mahasiswa)
                    .WithOne(p => p.MahasiswaMagister)
                    .HasForeignKey<MahasiswaMagister>(d => d.MahasiswaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MahasiswaMagister_Mahasiswa");
            });

            modelBuilder.Entity<MahasiswaSarjana>(entity =>
            {
                entity.ToTable("MahasiswaSarjana", "AkdMst");

                entity.HasIndex(e => e.MahasiswaId)
                    .HasName("IX_MahasiswaSarjana")
                    .IsUnique();

                entity.HasIndex(e => e.Nim);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsTpb).HasColumnName("isTPB");

                entity.Property(e => e.JalurMasukId).HasColumnName("JalurMasukID");

                entity.Property(e => e.MahasiswaId).HasColumnName("MahasiswaID");

                entity.Property(e => e.MayorId).HasColumnName("MayorID");

                entity.Property(e => e.MinorId).HasColumnName("MinorID");

                entity.Property(e => e.Nim)
                    .IsRequired()
                    .HasColumnName("NIM")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAkademikId).HasColumnName("StatusAkademikID");

                entity.Property(e => e.TahunAkademikId).HasColumnName("TahunAkademikID");

                entity.Property(e => e.TahunAkademikTpbid).HasColumnName("TahunAkademikTPBID");

                entity.Property(e => e.TahunSemesterMasukId).HasColumnName("TahunSemesterMasukID");

                entity.Property(e => e.TanggalMasuk).HasColumnType("date");

                entity.HasOne(d => d.Mahasiswa)
                    .WithOne(p => p.MahasiswaSarjana)
                    .HasForeignKey<MahasiswaSarjana>(d => d.MahasiswaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MahasiswaSarjana_Mahasiswa");
            });

            modelBuilder.Entity<Orang>(entity =>
            {
                entity.ToTable("Orang", "IPBMst");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anakvkey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JenisKelaminId).HasColumnName("JenisKelaminID");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nimppdhkey)
                    .HasColumnName("NIMPPDHKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nims0key)
                    .HasColumnName("NIMS0Key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nims1key)
                    .HasColumnName("NIMS1key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nims2key)
                    .HasColumnName("NIMS2Key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nims3key)
                    .HasColumnName("NIMS3Key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrangTuaVkey)
                    .HasColumnName("OrangTuaVKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasanganKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pgwaikey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.S2lama)
                    .HasColumnName("S2Lama")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.S3lama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalLahir).HasColumnType("date");

                entity.Property(e => e.TempatLahir)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempatLahirId).HasColumnName("TempatLahirID");
            });

            modelBuilder.Entity<OrganisasiOrmawa>(entity =>
            {
                entity.ToTable("OrganisasiOrmawa", "OrmMst");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JenisOrganisasiId).HasColumnName("JenisOrganisasiID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamaEn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomorSk)
                    .HasColumnName("NomorSK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tmt)
                    .HasColumnName("TMT")
                    .HasColumnType("date");

                entity.Property(e => e.Tst)
                    .HasColumnName("TST")
                    .HasColumnType("date");

                entity.HasOne(d => d.JenisOrganisasi)
                    .WithMany(p => p.OrganisasiOrmawa)
                    .HasForeignKey(d => d.JenisOrganisasiId)
                    .HasConstraintName("FK_OrganisasiOrmawa_JenisOrganisasi");
            });

            modelBuilder.Entity<PengajuanProposalKegiatan>(entity =>
            {
                entity.ToTable("PengajuanProposalKegiatan", "OrmTrx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnggotaOrmawaId).HasColumnName("AnggotaOrmawaID");

                entity.Property(e => e.JenisKegiatanOrmawaId).HasColumnName("JenisKegiatanOrmawaID");

                entity.Property(e => e.Kegiatan).IsUnicode(false);

                entity.Property(e => e.PenanggungJawabId).HasColumnName("PenanggungJawabID");

                entity.Property(e => e.TimeApproved).HasColumnType("datetime");

                entity.Property(e => e.TipeKegiatanOrmawaId).HasColumnName("TipeKegiatanOrmawaID");

                entity.HasOne(d => d.AnggotaOrmawa)
                    .WithMany(p => p.PengajuanProposalKegiatan)
                    .HasForeignKey(d => d.AnggotaOrmawaId)
                    .HasConstraintName("FK_PengajuanProposalKegiatan_AnggotaOrmawa");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.PengajuanProposalKegiatanApprovedByNavigation)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_PengajuanProposalKegiatan_Orang");

                entity.HasOne(d => d.JenisKegiatanOrmawa)
                    .WithMany(p => p.PengajuanProposalKegiatan)
                    .HasForeignKey(d => d.JenisKegiatanOrmawaId)
                    .HasConstraintName("FK_PengajuanProposalKegiatan_JenisKegiatanOrmawa");

                entity.HasOne(d => d.PenanggungJawab)
                    .WithMany(p => p.PengajuanProposalKegiatanPenanggungJawab)
                    .HasForeignKey(d => d.PenanggungJawabId)
                    .HasConstraintName("FK_PengajuanProposalKegiatan_Orang1");

                entity.HasOne(d => d.TipeKegiatanOrmawa)
                    .WithMany(p => p.PengajuanProposalKegiatan)
                    .HasForeignKey(d => d.TipeKegiatanOrmawaId)
                    .HasConstraintName("FK_PengajuanProposalKegiatan_TipeKegiatanOrmawa");
            });

            modelBuilder.Entity<StatusPengajuan>(entity =>
            {
                entity.ToTable("StatusPengajuan", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StrukturalOrmawa>(entity =>
            {
                entity.ToTable("StrukturalOrmawa", "OrmMst");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnggotaOrmawaId).HasColumnName("AnggotaOrmawaID");

                entity.Property(e => e.JabatanOrmawaId).HasColumnName("JabatanOrmawaID");

                entity.Property(e => e.OrganisasiOrmawaId).HasColumnName("OrganisasiOrmawaID");

                entity.Property(e => e.Tmt)
                    .HasColumnName("TMT")
                    .HasColumnType("date");

                entity.Property(e => e.Tst)
                    .HasColumnName("TST")
                    .HasColumnType("date");

                entity.HasOne(d => d.AnggotaOrmawa)
                    .WithMany(p => p.StrukturalOrmawa)
                    .HasForeignKey(d => d.AnggotaOrmawaId)
                    .HasConstraintName("FK_StrukturalOrmawa_AnggotaOrmawa");

                entity.HasOne(d => d.JabatanOrmawa)
                    .WithMany(p => p.StrukturalOrmawa)
                    .HasForeignKey(d => d.JabatanOrmawaId)
                    .HasConstraintName("FK_StrukturalOrmawa_JabatanOrmawa");

                entity.HasOne(d => d.OrganisasiOrmawa)
                    .WithMany(p => p.StrukturalOrmawa)
                    .HasForeignKey(d => d.OrganisasiOrmawaId)
                    .HasConstraintName("FK_StrukturalOrmawa_OrganisasiOrmawa");
            });

            modelBuilder.Entity<TahapanPengajuan>(entity =>
            {
                entity.ToTable("TahapanPengajuan", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keterangan).HasColumnType("text");

                entity.Property(e => e.PengajuanProposalKegiatanId).HasColumnName("PengajuanProposalKegiatanID");

                entity.Property(e => e.StatusPengajuanId).HasColumnName("StatusPengajuanID");

                entity.HasOne(d => d.PengajuanProposalKegiatan)
                    .WithMany(p => p.TahapanPengajuan)
                    .HasForeignKey(d => d.PengajuanProposalKegiatanId)
                    .HasConstraintName("FK_TahapanPengajuan_PengajuanProposalKegiatan");

                entity.HasOne(d => d.StatusPengajuan)
                    .WithMany(p => p.TahapanPengajuan)
                    .HasForeignKey(d => d.StatusPengajuanId)
                    .HasConstraintName("FK_TahapanPengajuan_StatusPengajuan");
            });

            modelBuilder.Entity<TipeKegiatanOrmawa>(entity =>
            {
                entity.ToTable("TipeKegiatanOrmawa", "OrmRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
