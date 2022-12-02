using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PROG6212_POE_Web_Application.Models
{
    public partial class PROG6212_POE_PART_TWOContext : DbContext
    {
        public PROG6212_POE_PART_TWOContext()
        {
        }

        public PROG6212_POE_PART_TWOContext(DbContextOptions<PROG6212_POE_PART_TWOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblModule> TblModules { get; set; }
        public virtual DbSet<TblRemainingStudyHour> TblRemainingStudyHours { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:robertobooysen.database.windows.net,1433;Initial Catalog=PROG6212_POE_PART_TWO;Persist Security Info=False;User ID=robertomain;Password=Roberto18;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblModule>(entity =>
            {
                entity.HasKey(e => e.ModulesId)
                    .HasName("PK__tblModul__E6C746ADFE9A38FE");

                entity.ToTable("tblModules");

                entity.Property(e => e.ModulesId).HasColumnName("ModulesID");

                entity.Property(e => e.ModuleCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRemainingStudyHour>(entity =>
            {
                entity.HasKey(e => e.RemainingModulesHoursId)
                    .HasName("PK__tblRemai__B48579D925C41E28");

                entity.ToTable("tblRemainingStudyHours");

                entity.Property(e => e.RemainingModulesHoursId).HasColumnName("RemainingModulesHoursID");

                entity.Property(e => e.DayOfStudy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__tblUsers__536C85E5D49C9E15");

                entity.ToTable("tblUsers");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
