namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblEmployee
    {
        [Key]
        [DataMember]
        public int Emp_EmployeeId { get; set; }

        [DataMember]
        public int Tit_TitleId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Emp_FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Emp_LastName { get; set; }

        [Required]
        [StringLength(1)]
        [DataMember]
        public string Emp_Gender { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Emp_Address { get; set; }

        [DataMember]
        public DateTime Emp_BirthOfDate { get; set; }

        [DataMember]
        public DateTime Emp_StartDate { get; set; }

        [DataMember]
        public DateTime Emp_TerminationDate { get; set; }

        [DataMember]
        public int Cit_CityId { get; set; }

        [Required]
        [StringLength(10)]
        [DataMember]
        public string Emp_PostalCode { get; set; }

        [DataMember]
        public int Pos_PositionId { get; set; }

        [StringLength(100)]
        [DataMember]
        public string Emp_Email { get; set; }

        [StringLength(30)]
        [DataMember]
        public string Emp_Phone { get; set; }

        [StringLength(30)]
        [DataMember]
        public string Emp_CellPhone { get; set; }

        [DataMember]
        public decimal? Emp_AnualSalary { get; set; }

        [DataMember]
        public decimal? Emp_HourlyRate { get; set; }

        [DataMember]
        public int Dep_DepartmentId { get; set; }

        [Column(TypeName = "image")]
        [DataMember]
        public byte[] Emp_Photo { get; set; }

        
        public tblDepartment tblDepartment { get; set; }

        
        public tblPosition tblPosition { get; set; }

        [DataMember]
        public tblTitle tblTitle { get; set; }
    }
}
