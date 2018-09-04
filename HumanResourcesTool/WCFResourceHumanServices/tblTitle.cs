namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTitle()
        {
            tblEmployees = new HashSet<tblEmployee>();
        }

        [Key]
        [DataMember]
        public int Tit_TitleId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Tit_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
