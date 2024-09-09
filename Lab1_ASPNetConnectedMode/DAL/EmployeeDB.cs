using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Lab1_ASPNetConnectedMode.BLL;
using System.Windows.Forms;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public class EmployeeDB
    {
        // Method saves an Employee object data to the database; Version 1
        public static void SaveRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = connDB;
            cmdInsert.CommandText = "INSERT INTO Employees(EmployeeId, FirstName, Lastname, JobTitle) " + "VALUES(@EmployeeId, @FirstName, @LastName, @JobTitle)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@lastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            try
            {
                cmdInsert.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
            connDB.Close();
        }

        public static void UpdateRecord(Employee emp)
        {
            SqlConnection connDb = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = connDb;
            cmdUpdate.CommandText = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, JobTitle = @jobTitle WHERE EmployeeId  = @EmployeeId";
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            try
            {
                cmdUpdate.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            connDb.Close();
        }

        public static void DeleteRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = connDB;
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            try
            {
                cmdDelete.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            connDB.Close();
        }

        public static List<BLL.Employee> GetAllRecords()
        {
            List<BLL.Employee> listE = new List<BLL.Employee>();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdInsertAll = new SqlCommand("SELECT * FROM EMPLOYEES", conn);
            SqlDataReader reader = cmdInsertAll.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                listE.Add(emp);
            }
            conn.Close();
            conn.Dispose();
            return listE;
        }

        public static List<BLL.Employee> SearchRecordById(int id)
        {
            List<BLL.Employee> empL = new List<BLL.Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            string sql = "SELECT * FROM Employees " + " WHERE EmployeeId = @EmployeeId";
            SqlCommand cmdSearch = new SqlCommand(sql, conn);
            cmdSearch.Parameters.AddWithValue("@EmployeeId", id);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empL.Add(emp);
            }
            conn.Close();
            conn.Dispose();
            return empL;
        }

        public static List<BLL.Employee> SearchRecordByFirstName(string FirstName)
        {
            List<BLL.Employee> empL = new List<BLL.Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            string sql = "SELECT * FROM Employees " + " WHERE FirstName = @FirstName";
            SqlCommand cmdSearch = new SqlCommand(sql, conn);
            cmdSearch.Parameters.AddWithValue("@FirstName", FirstName);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empL.Add(emp);
            }
            conn.Close();
            conn.Dispose();
            return empL;
        }

        public static List<BLL.Employee> SearchRecordByLastName(string LastName)
        {
            List<BLL.Employee> empL = new List<BLL.Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            string sql = "SELECT * FROM Employees " + " WHERE LastName = @LastName";
            SqlCommand cmdSearch = new SqlCommand(sql, conn);
            cmdSearch.Parameters.AddWithValue("@LastName", LastName);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empL.Add(emp);
            }
            conn.Close();
            conn.Dispose();
            return empL;
        }

        public static List<BLL.Employee> SearchRecordByJobTitle(string JobTitle)
        {
            List<BLL.Employee> empL = new List<BLL.Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            string sql = "SELECT * FROM Employees " + " WHERE JobTitle = @JobTitle";
            SqlCommand cmdSearch = new SqlCommand(sql, conn);
            cmdSearch.Parameters.AddWithValue("@JobTitle", JobTitle);
            SqlDataReader reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                empL.Add(emp);
            }
            conn.Close();
            conn.Dispose();
            return empL;
        }
    }
}