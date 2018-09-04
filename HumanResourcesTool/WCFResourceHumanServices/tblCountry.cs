namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblCountry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCountry()
        {
            tblProvinces = new HashSet<tblProvince>();
        }

        [Key]
        [DataMember]
        public int Cuo_CountryId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Cuo_Name { get; set; }

        [DataMember]
        public tblCountry tblCountries1 { get; set; }

        [DataMember]
        public tblCountry tblCountry1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public ICollection<tblProvince> tblProvinces { get; set; }
    }
}
