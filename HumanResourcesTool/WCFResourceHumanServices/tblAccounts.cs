namespace WCFResourceHumanServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblAccounts
    {
        

        [Key]
        [DataMember]
        public int Acc_Id { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Acc_Nick { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Acc_Pass { get; set; }
    }
}
