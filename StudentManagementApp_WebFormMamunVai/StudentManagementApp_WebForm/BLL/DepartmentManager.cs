using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApp_WebForm.DAL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.BLL
{
    public class DepartmentManager
    {

        DeparmentGateway aDepartmentGateway;
        public DepartmentManager()
        {
            aDepartmentGateway = new DeparmentGateway();
        }


        public bool Insert(Department aDepartment)
        {
            int rowAffected = 0;
            if (!IsRegNoExist(aDepartment))
            {
                rowAffected = aDepartmentGateway.Insert(aDepartment);
            }
            else
            {
                throw new Exception("Reg No already exists!");
            }

            return rowAffected > 0;

        }

        private bool IsRegNoExist(Department aDepartment)
        {
            Department retrivedDepartment = aDepartmentGateway.GetDepartment(aDepartment.dept_Name);

            return retrivedDepartment != null;
        }

        public List<Department> GetAllDepartment()
        {
            return aDepartmentGateway.GetAllDepartment();
        }

        public Department GetDepartmentByCode(string depart_name)
        {
            return aDepartmentGateway.GetDepartment(depart_name);
        }

    }
}