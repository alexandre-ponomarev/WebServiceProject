using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;

namespace WCFResourceHumanServices
{
    public class HRWebService : HRWebServices
    {

        List<tblEmployee> HRWebServices.GetEmployees()
        {
            using (var dbcontext = new HRDBContext())
            {


                List<tblEmployee> runnersObjects = dbcontext.tblEmployees.Include(p => p.tblTitle).ToList();




                return runnersObjects;
            }
        }

        List<tblPosition> HRWebServices.GetPositions()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblPosition> runnersObjects = dbcontext.tblPositions.ToList();



                return runnersObjects;
            }
        }

        List<tblDepartment> HRWebServices.GetDepartments()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblDepartment> runnersObjects = dbcontext.tblDepartments.ToList();



                return runnersObjects;
            }

        }

        List<tblTitle> HRWebServices.GetTitles()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblTitle> runnersObjects = dbcontext.tblTitles.ToList();



                return runnersObjects;
            }

        }

        List<tblCountry> HRWebServices.GetCountries()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblCountry> runnersObjects = dbcontext.tblCountries.ToList();



                return runnersObjects;
            }
        }


        List<tblProvince> HRWebServices.GetProvinces()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblProvince> runnersObjects = dbcontext.tblProvinces.ToList();



                return runnersObjects;
            }
        }


        List<tblCity> HRWebServices.GetCities()
        {
            using (var dbcontext = new HRDBContext())
            {
                List<tblCity> runnersObjects = dbcontext.tblCities.ToList();



                return runnersObjects;
            }
        }


        int HRWebServices.GetLastEmployeeId()
        {
            using (var dbcontext = new HRDBContext())
            {

                int maxEmployeeId = (dbcontext.tblEmployees.Select(e => e.Emp_EmployeeId).DefaultIfEmpty(0).Max()) + 1;

                return maxEmployeeId;
            }
        }


        public bool insertDepartments(tblDepartment objDepartment)
        {
            using (var dbcontext = new HRDBContext())
            {
                try
                {
                    dbcontext.tblDepartments.Add(objDepartment);
                    dbcontext.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }

            }

        }


        public bool insertEmployees(tblEmployee objEmployee)
        {
            using (var dbcontext = new HRDBContext())
            {
                try
                {
                    dbcontext.tblEmployees.Add(objEmployee);
                    dbcontext.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }

            }


        }




    }
}