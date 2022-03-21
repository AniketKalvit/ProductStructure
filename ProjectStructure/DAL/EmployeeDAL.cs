using ProjectStructure.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.DAL
{
   public class EmployeeDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        public EmployeeDAL()
        {
            con = new SqlConnection();
        }
        public int Save(Employee emp)
        {
            string qry = "insert into Employee values(@id,@name,@designation,@salary)";
            // step 5
            cmd = new SqlCommand(qry, con);
            //step 6
            con.Open();
            // step 7
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.Parameters.AddWithValue("@name", emp.Name);
            cmd.Parameters.AddWithValue("@designation", emp.Designation);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            // step 8
            int result = cmd.ExecuteNonQuery();
            return result;
        }
    }
}
