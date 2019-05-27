using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDtableWinForm
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

 //           lv_listEmployees.View = View.Details;
            lv_listEmployees.BeginUpdate();

            //lv_listEmployees.Columns.Add("Employee ID");
            //lv_listEmployees.Columns.Add("First Name");
            //lv_listEmployees.Columns.Add("Last Name");
            //lv_listEmployees.Columns.Add("E-mail");
            //lv_listEmployees.Columns.Add("Phone Number");
            //lv_listEmployees.Columns.Add("Hire Date");
            //lv_listEmployees.Columns.Add("Job ID");
            //lv_listEmployees.Columns.Add("Salary");
            //lv_listEmployees.Columns.Add("Commission PCT");
            //lv_listEmployees.Columns.Add("Manager ID");
            //lv_listEmployees.Columns.Add("Department ID");

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = HrDAC.Instance.GetEmployee(long.Parse(txtBox_EmployeeID.Text));

            txtBox_FirstName.Text = emp.First_name;
            txtBox_LastName.Text = emp.Last_name;
            txtBox_Email.Text = emp.Email;
            txtBox_PhoneNumber.Text = emp.Phone_number;
            txtBox_HireDate.Text = emp.Hire_date.ToShortDateString();
            txtBox_JobID.Text = emp.Job_id;
            txtBox_Salary.Text = emp.Salary.ToString();
            txtBox_CommissionPCT.Text = emp.CommissionPCT.ToString();
            txtBox_ManagerID.Text = emp.Manager_id.ToString();
            txtBox_DepartmentID.Text = emp.Department_id.ToString();
        }

        private void BtnAllSearch_Click(object sender, EventArgs e)
        {
            List<Employee> lemp = new List<Employee>();
            lemp = HrDAC.Instance.GetEmployees();

            lv_listEmployees.Items.Clear();
            foreach (Employee emp in lemp)
            {
                ListViewItem lvi = new ListViewItem(emp.Employee_id.ToString());
                lvi.SubItems.Add(emp.First_name);
                lvi.SubItems.Add(emp.Last_name);
                lvi.SubItems.Add(emp.Email);
                lvi.SubItems.Add(emp.Phone_number);
                lvi.SubItems.Add(emp.Hire_date.ToString());
                lvi.SubItems.Add(emp.Job_id.ToString());
                lvi.SubItems.Add(emp.Salary.ToString());
                lvi.SubItems.Add(emp.CommissionPCT.ToString());
                lvi.SubItems.Add(emp.Manager_id.ToString());
                lvi.SubItems.Add(emp.Department_id.ToString());
                lv_listEmployees.Items.Add(lvi);
            }

            lv_listEmployees.EndUpdate();
        }
    }
}
