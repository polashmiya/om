using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OM.Models
{
    public partial class OfficeManagementContext : DbContext
    {
        public OfficeManagementContext()
        {
        }

        public OfficeManagementContext(DbContextOptions<OfficeManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloodGroup> BloodGroups { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Religion> Religions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=POLASH-558442;Database=OfficeManagement;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.ToTable("bloodGroup");

                entity.HasIndex(e => e.BloodGroupName, "UQ__bloodGro__24092C97DB3F364C")
                    .IsUnique();

                entity.Property(e => e.BloodGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("bloodGroupId");

                entity.Property(e => e.BloodGroupName)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("bloodGroupName");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("departmentName");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("designation");

                entity.Property(e => e.DesignationId)
                    .ValueGeneratedNever()
                    .HasColumnName("designationId");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("designationName");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BloodGroupId).HasColumnName("bloodGroupId");

                entity.Property(e => e.BloodGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bloodGroupName");

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmationDate");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfBirth");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departmentName");

                entity.Property(e => e.DesignationId).HasColumnName("designationId");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designationName");

                entity.Property(e => e.Emaill)
                    .HasMaxLength(50)
                    .HasColumnName("emaill");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("employeeTypeId");

                entity.Property(e => e.EmployeeTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeTypeName");

                entity.Property(e => e.GenderId).HasColumnName("genderId");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genderName");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsMasterUser).HasColumnName("isMasterUser");

                entity.Property(e => e.IsUser).HasColumnName("isUser");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("joiningDate");

                entity.Property(e => e.LineManagerId).HasColumnName("lineManagerId");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("mobileNo");

                entity.Property(e => e.Nid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nid");

                entity.Property(e => e.OfficeId).HasColumnName("officeId");

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("officeName");

                entity.Property(e => e.OfficialContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("officialContact");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("permanentAddress");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("presentAddress");

                entity.Property(e => e.ReligionId).HasColumnName("religionId");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("religionName");

                entity.Property(e => e.SupervisorId).HasColumnName("supervisorId");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.HasIndex(e => e.GenderName, "UQ__gender__14B63E73EE55F938")
                    .IsUnique();

                entity.Property(e => e.GenderId)
                    .ValueGeneratedNever()
                    .HasColumnName("genderId");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genderName");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("manager");

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("managerName");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("office");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("projects");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("projectName");

                entity.Property(e => e.TeamMemberId).HasColumnName("teamMemberId");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("religion");

                entity.HasIndex(e => e.ReligionName, "UQ__religion__AD37F20CBF9D4FAE")
                    .IsUnique();

                entity.Property(e => e.ReligionId)
                    .ValueGeneratedNever()
                    .HasColumnName("religionId");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("religionName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
