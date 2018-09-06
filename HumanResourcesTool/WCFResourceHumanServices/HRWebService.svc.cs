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


                List<tblEmployee> runnersObjects = dbcontext.tblEmployees.Include(t => t.tblTitle).Include(d => d.tblDepartment).Include(p => p.tblPosition).Include(c => c.tblCity).ToList();




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


        public bool updateEmployees(tblEmployee objEmployee, int EmployeeId)
        {
            using (var dbcontext = new HRDBContext())
            {
                try
                {
                    dbcontext.tblEmployees.Add(objEmployee);
                    dbcontext.Entry(objEmployee).State = System.Data.Entity.EntityState.Modified;
                    dbcontext.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }

            }

        }


        public bool deleteEmployees(int EmployeeId)
        {
            using (var dbcontext = new HRDBContext())
            {
                try
                {
                    var itemToRemove = dbcontext.tblEmployees.SingleOrDefault(x => x.Emp_EmployeeId == EmployeeId); 

                    if (itemToRemove != null)
                    {
                        dbcontext.tblEmployees.Remove(itemToRemove);
                        dbcontext.SaveChanges();
                        return true;
                    } else
                    {
                        return false;
                    }


                }
                catch (Exception)
                {
                    return false;
                }

            }

        }



        bool HRWebServices.GetVerifyIfEmployeeExist(int EmployeeId)
        {
            using (var dbcontext = new HRDBContext())
            {

                if (dbcontext.tblEmployees.Any(e => e.Emp_EmployeeId == EmployeeId))
                {
                    return true;
                } else
                {
                    return false;
                }
                    
            }
        }


        tblEmployee HRWebServices.GetEmployeeInfo(int EmployeeId)
        {
            using (var dbcontext = new HRDBContext())
            {


                var Employee = dbcontext.tblEmployees.First(e => e.Emp_EmployeeId == EmployeeId);

                if (Employee != null)
                {
                    tblEmployee objEmployee = new tblEmployee();

                    objEmployee.Emp_EmployeeId = Employee.Emp_EmployeeId;
                    objEmployee.Cit_CityId = Employee.Cit_CityId;
                    objEmployee.Dep_DepartmentId = Employee.Dep_DepartmentId;
                    objEmployee.Emp_Address = Employee.Emp_Address;
                    objEmployee.Emp_AnualSalary = Employee.Emp_AnualSalary;
                    objEmployee.Emp_BirthOfDate = Employee.Emp_BirthOfDate;
                    objEmployee.Emp_CellPhone = Employee.Emp_CellPhone;
                    objEmployee.Emp_Email = Employee.Emp_Email;
                    objEmployee.Emp_FirstName = Employee.Emp_FirstName;
                    objEmployee.Emp_Gender = Employee.Emp_Gender;
                    objEmployee.Emp_HourlyRate = Employee.Emp_HourlyRate;
                    objEmployee.Emp_LastName = Employee.Emp_LastName;
                    objEmployee.Emp_Phone = Employee.Emp_Phone;
                    objEmployee.Emp_Photo = Employee.Emp_Photo;
                    objEmployee.Emp_PostalCode = Employee.Emp_PostalCode;
                    objEmployee.Emp_StartDate = Employee.Emp_StartDate;
                    objEmployee.Emp_TerminationDate = Employee.Emp_TerminationDate;
                    objEmployee.Pos_PositionId = Employee.Pos_PositionId;
                    objEmployee.Tit_TitleId = Employee.Tit_TitleId;

                    return objEmployee;

                }
                else
                {
                    return null;
                }

            }
        }


    }
}