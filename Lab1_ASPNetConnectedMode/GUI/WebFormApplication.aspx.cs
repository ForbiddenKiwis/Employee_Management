using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using Lab1_ASPNetConnectedMode.BLL;




namespace Lab1_ASPNetConnectedMode.GUI
{
    public partial class WebFormApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.Items.Add("Employee Id");
                DropDownList1.Items.Add("First Name");
                DropDownList1.Items.Add("Last Name");
                DropDownList1.Items.Add("Job Title");

                DropDownList1.SelectedIndex = 0;
            }
        }

        // SAVE
        protected void Button1_Click(object sender, EventArgs e)
        {
            BLL.Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(EmpId.Text.Trim());
            employee.FirstName = EmpFirst.Text.Trim();
            employee.LastName = EmpLast.Text.Trim();
            employee.JobTitle = EmpJob.Text.Trim();
            employee.SaveEmployee(employee);
            MessageBox.Show("Customer data is saved in the database");
        }
        
        // Update
        protected void Button2_Click(object sender, EventArgs e)
        {
            BLL.Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(EmpId.Text.Trim());
            employee.FirstName = EmpFirst.Text.Trim();
            employee.LastName = EmpLast.Text.Trim();
            employee.JobTitle = EmpJob.Text.Trim();
            employee.UpdateEmployee(employee);
            MessageBox.Show("Customer Data is now updated");
        }

        // Delete
        protected void Button3_Click(object sender, EventArgs e)
        {
            BLL.Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(EmpId.Text.Trim());
            emp.FirstName = EmpFirst.Text.Trim();
            emp.LastName = EmpLast.Text.Trim();
            emp.JobTitle = EmpJob.Text.Trim();
            
            if (emp != null)
            {
                emp.DeleteEmployee(emp);
                MessageBox.Show("Employee has been deleted from the database");
            }
            else
            {
                MessageBox.Show("Employee does not exist. Use the EmployeeId to delete Emp");
            }
        }

        // List All
        protected void Button4_Click(object sender, EventArgs e)
        {
            BLL.Employee emp = new BLL.Employee();
            GridView1.DataSource = emp.GetAllEmployee();
            GridView1.DataBind();
        }

        // Search Employee
        protected void Button5_Click(object sender, EventArgs e)
        {
            BLL.Employee emp = new BLL.Employee();
            
            string selectedItems = DropDownList1.SelectedItem.ToString();

            switch (selectedItems) 
            {
                case "Employee Id":
                    string stringEmpId = Search.Text.Trim();
                    int.TryParse(stringEmpId, out int empId);
                    GridView1.DataSource = Employee.SearchEmployeeId(empId);
                    GridView1.DataBind();
                    break;
                case "First Name":
                    string empFirstName = Search.Text.Trim();
                    GridView1.DataSource = Employee.SearchEmployeeFirstName(empFirstName);
                    GridView1.DataBind();
                    break;
                case "Last Name":
                    string empLastName = Search.Text.Trim();
                    GridView1.DataSource = Employee.SearchEmployeeLastName(empLastName);
                    GridView1.DataBind();
                    break;
                case "Job Title":
                    string empJobTitle = Search.Text.Trim();
                    GridView1.DataSource = Employee.SearchEmployeeJobTitle(empJobTitle);
                    GridView1.DataBind();
                    break;
                default:
                    MessageBox.Show("Invalid Drop box item");
                    break;
            }
        }

        protected void EmpId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EmpJob_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}