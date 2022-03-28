using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Capgemini.EFCoreDataFirst.Models
{
    public partial class HRContext : DbContext
    {
        public HRContext()
        {
        }

        public HRContext(DbContextOptions<HRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=arun-pc\\sqlexpress; Database=HR; Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.CEmployeeCode)
                    .HasName("etv_pk");

                entity.ToTable("Employee");

                entity.HasIndex(e => e.CCity, "IX_Employee_cCity");

                entity.HasIndex(e => e.CSocialSecurityNo, "UQ__Employee__6AB6057F7821422B")
                    .IsUnique();

                entity.Property(e => e.CEmployeeCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cEmployeeCode")
                    .IsFixedLength(true);

                entity.Property(e => e.CCandidateCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cCandidateCode")
                    .IsFixedLength(true);

                entity.Property(e => e.CCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cCity")
                    .IsFixedLength(true);

                entity.Property(e => e.CCountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cCountryCode")
                    .IsFixedLength(true);

                entity.Property(e => e.CCurrentPosition)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cCurrentPosition")
                    .IsFixedLength(true);

                entity.Property(e => e.CDepartmentCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cDepartmentCode")
                    .IsFixedLength(true);

                entity.Property(e => e.CDesignation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cDesignation")
                    .IsFixedLength(true);

                entity.Property(e => e.CEmailId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cEmailId")
                    .IsFixedLength(true);

                entity.Property(e => e.CPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.CRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cRegion")
                    .IsFixedLength(true);

                entity.Property(e => e.CSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cSex")
                    .IsFixedLength(true);

                entity.Property(e => e.CSocialSecurityNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cSocialSecurityNo")
                    .IsFixedLength(true);

                entity.Property(e => e.CState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cState")
                    .IsFixedLength(true);

                entity.Property(e => e.CSupervisorCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cSupervisorCode")
                    .IsFixedLength(true);

                entity.Property(e => e.CZip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cZip")
                    .IsFixedLength(true);

                entity.Property(e => e.DBirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dBirthDate");

                entity.Property(e => e.DJoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dJoiningDate");

                entity.Property(e => e.DResignationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dResignationDate");

                entity.Property(e => e.ImPhoto)
                    .HasColumnType("image")
                    .HasColumnName("imPhoto");

                entity.Property(e => e.VAddress)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("vAddress");

                entity.Property(e => e.VFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vFirstName");

                entity.Property(e => e.VLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vLastName");

                entity.Property(e => e.VQualification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vQualification");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.CPositionCode)
                    .HasName("ptv_pk");

                entity.ToTable("Position");

                entity.HasIndex(e => e.VDescription, "IX_PositionDescription");

                entity.Property(e => e.CPositionCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cPositionCode")
                    .IsFixedLength(true);

                entity.Property(e => e.IBudgetedStrength).HasColumnName("iBudgetedStrength");

                entity.Property(e => e.ICurrentStrength).HasColumnName("iCurrentStrength");

                entity.Property(e => e.SiYear).HasColumnName("siYear");

                entity.Property(e => e.VDescription)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("vDescription");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
