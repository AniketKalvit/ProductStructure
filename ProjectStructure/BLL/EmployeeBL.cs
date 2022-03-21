using ProjectStructure.BO;
using ProjectStructure.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.BLL
{
    public class EmployeeBL
    {
        public int AcceptDetails(Employee emp)
        {
            // code goes here to calculate salary..... other logic on the data
            EmployeeDAL ob = new EmployeeDAL();
            int res=ob.Save(emp);
            return res;
        }
    }
}
