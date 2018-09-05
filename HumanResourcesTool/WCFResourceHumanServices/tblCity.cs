namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblCity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCity()
        {
            tblEmployees = new HashSet<tblEmployee>();
        }

        [Key]
        [DataMember]
        public int Cit_CityId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Cit_Name { get; set; }

        [DataMember]
        public int Pro_ProvinceId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
