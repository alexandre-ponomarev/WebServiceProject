namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCountry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCountry()
        {
            tblProvinces = new HashSet<tblProvince>();
        }

        [Key]
        public int Cuo_CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Cuo_Name { get; set; }

        public virtual tblCountry tblCountries1 { get; set; }

        public virtual tblCountry tblCountry1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProvince> tblProvinces { get; set; }
    }
}
