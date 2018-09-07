using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFResourceHumanServices
{
    [DataContract]
    public class ClassEmployee
    {
        [DataMember]
        public int employeeId { get; set; }

        [DataMember]
        public string employeeLastName { get; set; }

        [DataMember]
        public string employeeFirstName { get; set; }
    }
}