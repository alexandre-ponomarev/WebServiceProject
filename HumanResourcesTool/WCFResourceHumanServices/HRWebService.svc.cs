using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFResourceHumanServices
{
    public class HRWebService : HRWebServices
    {
        

        List<tblCity> HRWebServices.GetCities()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblCity> runnersObjects = dbcontext.tblCities.ToList();



                return runnersObjects;
            }
        }
    }
}
