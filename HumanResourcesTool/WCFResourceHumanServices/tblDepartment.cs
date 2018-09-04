namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartment()
        {
            tblEmployees = new HashSet<tblEmployee>();
        }

        [Key]
        [DataMember]
        public int Dep_DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Dep_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
