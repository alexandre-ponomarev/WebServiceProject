namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblProvince
    {
        [Key]
        public int Pro_ProvinceId { get; set; }

        [Required]
        [StringLength(100)]
        public string Pro_Name { get; set; }

        public int Cou_Countryid { get; set; }

        public virtual tblCountry tblCountry { get; set; }
    }
}
