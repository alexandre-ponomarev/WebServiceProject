namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmployee
    {
        [Key]
        public int Emp_EmployeeId { get; set; }

        public int Tit_TitleId { get; set; }

        [Required]
        [StringLength(100)]
        public string Emp_FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string Emp_LastName { get; set; }

        [StringLength(100)]
        public string Emp_SurName { get; set; }

        [StringLength(100)]
        public string Emp_OtherName { get; set; }

        [StringLength(100)]
        public string Emp_KnownAs { get; set; }

        [Required]
        [StringLength(1)]
        public string Emp_Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string Emp_Address { get; set; }

        public DateTime Emp_BirthOfDate { get; set; }

        public DateTime Emp_StartDate { get; set; }

        public DateTime Emp_TerminationDate { get; set; }

        public int Cit_CityId { get; set; }

        [Required]
        [StringLength(10)]
        public string Emp_PostalCode { get; set; }

        public int Pos_PositionId { get; set; }

        [StringLength(100)]
        public string Emp_Email { get; set; }

        [StringLength(30)]
        public string Emp_Phone { get; set; }

        [StringLength(30)]
        public string Emp_CellPhone { get; set; }

        public decimal? Emp_AnualSalary { get; set; }

        public decimal? Emp_HourlyRate { get; set; }

        public int Dep_DepartmentId { get; set; }

        [Column(TypeName = "image")]
        public byte[] Emp_Photo { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }

        public virtual tblPosition tblPosition { get; set; }

        public virtual tblTitle tblTitle { get; set; }
    }
}
