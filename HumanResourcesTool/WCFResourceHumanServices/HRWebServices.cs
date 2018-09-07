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
        bool Login(string pass);

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
        List<tblProvince> GetProvincesByCountry(int CountryId);

        [OperationContract]
        List<tblCity> GetCities();

        [OperationContract]
        List<tblCity> GetCitiesByProvince(int ProvinceId);

        [OperationContract]
        int GetProvinceIdByCityId(int CityId);

        [OperationContract]
        int GetCountryIdByProvinceId(int ProvinceId);

        [OperationContract]
        List<tblEmployee> GetEmployees();

        [OperationContract]
        int GetLastEmployeeId();

        [OperationContract]
        bool insertDepartments(tblDepartment objDepartment);

        [OperationContract]
        bool insertEmployees(tblEmployee objEmployee);


        [OperationContract]
        bool GetVerifyIfEmployeeExist(int EmployeeId);

        [OperationContract]
        tblEmployee GetEmployeeInfo(int EmployeeId);

        [OperationContract]
        bool updateEmployees(tblEmployee objEmployee, int EmployeeId);

        [OperationContract]
        bool deleteEmployees(int EmployeeId);

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
