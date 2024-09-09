using Lab1_ASPNetConnectedMode.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_ASPNetConnectedMode.BLL
{
    public class Employee
    {
        //Private variables
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;

        // Properties
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        // Custom methods
        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateRecord(emp);
        }

        public void DeleteEmployee(Employee emp)
        {
            EmployeeDB.DeleteRecord(emp);
        }

        public List<Employee> GetAllEmployee() {
            return EmployeeDB.GetAllRecords();
        }

        public static List<Employee> SearchEmployeeId(int id) => EmployeeDB.SearchRecordById(id);
        public static List<Employee> SearchEmployeeFirstName(string FirstName) => EmployeeDB.SearchRecordByFirstName(FirstName);
        public static List<Employee> SearchEmployeeLastName(string LastName) => EmployeeDB.SearchRecordByLastName(LastName);
        public static List<Employee> SearchEmployeeJobTitle(string JobTitle) => EmployeeDB.SearchRecordByJobTitle(JobTitle);


    }
}