using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFResourceHumanServices
{
    [ServiceContract]
    public interface HRWebServices
    {


        [OperationContract]
        List<tblPosition> GetPositions();

        [OperationContract]
        List<tblDepartment> GetDepartments();

        [OperationContract]
        List<tblTitle> GetTitles();

        [OperationContract]
        List<tblCountry> GetCountries();

        [OperationContract]
        List<tblProvince> GetProvinces();

        [OperationContract]
        List<tblCity> GetCities();

        [OperationContract]
        List<tblEmployee> GetEmployees();

        [OperationContract]
        int GetLastEmployeeId();

        [OperationContract]
        bool insertDepartments(tblDepartment objDepartment);

        [OperationContract]
        bool insertEmployees(tblEmployee objEmployee);

    }


    //Use a data contract as illustrated in the sample below to add composite types to service operations.


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

}
