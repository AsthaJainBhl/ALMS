using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ALMS.API.Models
{
    public partial class Sprint2ALMSContext : DbContext
    {
        public Sprint2ALMSContext()
        {
        }

        public Sprint2ALMSContext(DbContextOptions<Sprint2ALMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MsCreditDetail> MsCreditDetails { get; set; }
        public virtual DbSet<MsEmployeeDetail> MsEmployeeDetails { get; set; }
        public virtual DbSet<MsProjectDetail> MsProjectDetails { get; set; }
        public virtual DbSet<MsUserRegistration> MsUserRegistrations { get; set; }
        public virtual DbSet<TrAttendanceDetail> TrAttendanceDetails { get; set; }
        public virtual DbSet<TrLeaveRequestDetail> TrLeaveRequestDetails { get; set; }
        public virtual DbSet<TrProjectAllocation> TrProjectAllocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= DESKTOP-JAQ8DC9\\SQLSERVER;Database= Sprint2ALMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MsCreditDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MS_CreditDetails");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__MS_Credit__Emplo__15502E78");
            });

            modelBuilder.Entity<MsEmployeeDetail>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__MS_Emplo__7AD04FF13BBDB99E");

                entity.ToTable("MS_EmployeeDetails");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeAge)
                    .HasComputedColumnSql("(floor(datediff(day,[EmployeeDOB],getdate())/(365)))", false);

                entity.Property(e => e.EmployeeDesignation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDob)
                    .HasColumnType("date")
                    .HasColumnName("EmployeeDOB");

                entity.Property(e => e.EmployeeEmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeEmailID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsProjectDetail>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__MS_Proje__761ABED01505C261");

                entity.ToTable("MS_ProjectDetails");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectEndDate).HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStartDate).HasColumnType("date");

                entity.Property(e => e.ProjectTechnology)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsUserRegistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MS_UserRegistration");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__MS_UserRe__Emplo__117F9D94");
            });

            modelBuilder.Entity<TrAttendanceDetail>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK__TR_Atten__8B69263C59E5449F");

                entity.ToTable("TR_AttendanceDetails");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.AttedanceDate).HasColumnType("date");

                entity.Property(e => e.AttendanceStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InTime).HasColumnType("time(0)");

                entity.Property(e => e.OutTime).HasColumnType("time(0)");

                entity.Property(e => e.ProjectId).HasColumnName("Project_ID");

                entity.Property(e => e.StatusUpdateDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TrAttendanceDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__TR_Attend__Emplo__1BFD2C07");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TrAttendanceDetails)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__TR_Attend__Proje__1B0907CE");
            });

            modelBuilder.Entity<TrLeaveRequestDetail>(entity =>
            {
                entity.HasKey(e => e.LeaveRequestId)
                    .HasName("PK__TR_Leave__6094218EC228107F");

                entity.ToTable("TR_LeaveRequestDetails");

                entity.Property(e => e.LeaveRequestId).HasColumnName("LeaveRequestID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveRequestFrom).HasColumnType("date");

                entity.Property(e => e.LeaveRequestTo).HasColumnType("date");

                entity.Property(e => e.LeaveStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TrLeaveRequestDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__TR_LeaveR__Emplo__1FCDBCEB");
            });

            modelBuilder.Entity<TrProjectAllocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TR_ProjectAllocation");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__TR_Projec__Emplo__182C9B23");

                entity.HasOne(d => d.Project)
                    .WithMany()
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__TR_Projec__Proje__173876EA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
