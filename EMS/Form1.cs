using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS.Business.Implementation;

namespace EMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartActivity();
        }

        public void StartActivity()
        {
            EmployeeService employeeService = new EmployeeService();
           // bool response = employeeService.ValidateEmployeeName("hari"); // return false
            //if (!response)
            //    MessageBox.Show("Employee Name already exists");            

           // bool response1 = employeeService.ValidateEmployeeName("dhiraj"); // return true
        }
    }
}
