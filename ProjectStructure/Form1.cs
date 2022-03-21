using ProjectStructure.BLL;
using ProjectStructure.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();//Bo
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Designation = txtDesignation.Text;
                emp.Salary = Convert.ToDecimal(txtSalary.Text);
                EmployeeBL empbl = new EmployeeBL();
                int res = empbl.AcceptDetails(emp);
                if (res == 1)
                {
                    MessageBox.Show("Save");
                }
            }
            catch { }
        }
    }
}
