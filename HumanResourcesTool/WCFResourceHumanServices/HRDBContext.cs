namespace WCFResourceHumanServices
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HRDBContext : DbContext
    {
        public HRDBContext()
            : base("MyDB")
        {
        }

        public virtual DbSet<tblCity> tblCities { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblPosition> tblPositions { get; set; }
        public virtual DbSet<tblProvince> tblProvinces { get; set; }
        public virtual DbSet<tblTitle> tblTitles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCountry>()
                .HasOptional(e => e.tblCountries1)
                .WithRequired(e => e.tblCountry1);

            modelBuilder.Entity<tblCountry>()
                .HasMany(e => e.tblProvinces)
                .WithRequired(e => e.tblCountry)
                .HasForeignKey(e => e.Cou_Countryid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDepartment>()
                .HasMany(e => e.tblEmployees)
                .WithRequired(e => e.tblDepartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.Emp_AnualSalary)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.Emp_HourlyRate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblPosition>()
                .HasMany(e => e.tblEmployees)
                .WithRequired(e => e.tblPosition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTitle>()
                .HasMany(e => e.tblEmployees)
                .WithRequired(e => e.tblTitle)
                .WillCascadeOnDelete(false);
        }
    }
}
