using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistant> Assistant { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorsDepartment> DoctorsDepartment { get; set; }
        public virtual DbSet<Drug> Drug { get; set; }
        public virtual DbSet<MedicineLists> MedicineLists { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientsDoctor> PatientsDoctor { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=DESKTOP-RP7840A\\SQLEXPRESS; database=Hospital; user id=sa; password=8488859646;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistant>(entity =>
            {
                entity.HasKey(e => e.AssisId)
                    .HasName("PK__Assistan__3EBB14A62175A847");

                entity.Property(e => e.AssisId).ValueGeneratedNever();

                entity.Property(e => e.AssisAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssisFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssisLname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssisQualification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Assistant)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK_DocID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__014881AED380A567");

                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.DocId)
                    .HasName("PK__Doctor__3EF188AD40D46490");

                entity.Property(e => e.DocId).ValueGeneratedNever();

                entity.Property(e => e.DocAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocLname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocQualification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocSpecialist)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_DeptName");
            });

            modelBuilder.Entity<DoctorsDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeptName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.DrugId).ValueGeneratedNever();

                entity.Property(e => e.DrugName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.Drug)
                    .HasForeignKey(d => d.PreId)
                    .HasConstraintName("FK_PreId");
            });

            modelBuilder.Entity<MedicineLists>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DrugName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatId)
                    .HasName("PK__Patient__F0DDA9E539E8783E");

                entity.Property(e => e.PatId).ValueGeneratedNever();

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PatAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatDob).HasColumnType("datetime");

                entity.Property(e => e.PatFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatLname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assis)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AssisId)
                    .HasConstraintName("FK_AssisID");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK_PrePatId");
            });

            modelBuilder.Entity<PatientsDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DocFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasKey(e => e.PreId)
                    .HasName("PK__Prescrip__7024CEC9220B66CA");

                entity.Property(e => e.PreId).ValueGeneratedNever();

                entity.Property(e => e.PreDate).HasColumnType("date");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Prescription)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK_predocid");

                entity.HasOne(d => d.Pat)
                    .WithMany(p => p.Prescription)
                    .HasForeignKey(d => d.PatId)
                    .HasConstraintName("FK_PatientDocId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
