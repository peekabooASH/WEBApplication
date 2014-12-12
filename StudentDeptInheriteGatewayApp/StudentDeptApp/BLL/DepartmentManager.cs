using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDeptApp.DAL;
using StudentDeptApp.Models;

namespace StudentDeptApp.BLL
{
    public class DepartmentManager
    {
        private DepartmentGateway aDepartmentGateway;

        public DepartmentManager()
        {
            aDepartmentGateway=new DepartmentGateway();
        }

        public string Insert(Department aDepartment)
        {
            if (!IsCodeExist(aDepartment.Code))
            {
                aDepartmentGateway.Insert(aDepartment);
                return "Insert Successfully";
            }
            return "There are some problem .";
        }

        private bool IsCodeExist(string code)
        {
            bool hasrow = aDepartmentGateway.IsCodeExist(code);
            if (hasrow)
            {
                return true;
            }
            return false;
        }

        public List<Department> GetAllDepartment()
        {
            List<Department> depstments;
            depstments = aDepartmentGateway.GetAllDepartment();
            return depstments;
        }
    }
}