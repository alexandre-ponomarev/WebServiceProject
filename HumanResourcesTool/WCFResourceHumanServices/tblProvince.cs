namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblProvince
    {
        [Key]
        [DataMember]
        public int Pro_ProvinceId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Pro_Name { get; set; }

        [DataMember]
        public int Cou_Countryid { get; set; }

        [DataMember]
        public tblCountry tblCountry { get; set; }
    }
}
