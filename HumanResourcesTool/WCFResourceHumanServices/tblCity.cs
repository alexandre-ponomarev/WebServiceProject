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
        [Key]
        [DataMember]
        public int Cit_CityId { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Cit_Name { get; set; }

        [DataMember]
        public int Pro_ProvinceId { get; set; }
    }
}
