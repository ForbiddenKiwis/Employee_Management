Lab1_ASPNetConnectedMode
Description
This project is an ASP.NET Web Forms application that manages employee records in a SQL database. It provides functionalities to save, update, delete, and search for employee information based on various criteria such as Employee ID, First Name, Last Name, and Job Title.

Features
CRUD Operations: Create, Read, Update, and Delete employee records.
Search Functionality: Search for employees by ID, first name, last name, or job title.
User Interface: Simple web-based interface for interacting with employee data.
Technologies Used
ASP.NET Web Forms
C#
SQL Server
ADO.NET for database connectivity
Installation
Clone the repository or download the source code.
Open the project in Visual Studio.
Ensure that you have a SQL Server instance running.
Update the connection string in the Web.config file to point to your database.
Run the application in Visual Studio.
Usage
Adding an Employee: Fill in the employee details and click the "Save" button.
Updating an Employee: Enter the Employee ID and updated details, then click "Update".
Deleting an Employee: Enter the Employee ID of the employee to be deleted and click "Delete".
Listing All Employees: Click the "List All" button to view all employee records.
Searching for Employees: Select a search criterion from the dropdown and enter the search term, then click "Search".
Methods
Employee Class
SaveEmployee(Employee emp): Saves a new employee record to the database.
UpdateEmployee(Employee emp): Updates an existing employee record.
DeleteEmployee(Employee emp): Deletes an employee record from the database.
GetAllEmployee(): Retrieves a list of all employees.
SearchEmployeeId(int id): Searches for an employee by ID.
SearchEmployeeFirstName(string firstName): Searches for employees by first name.
SearchEmployeeLastName(string lastName): Searches for employees by last name.
SearchEmployeeJobTitle(string jobTitle): Searches for employees by job title.
EmployeeDB Class
Handles database operations for the Employee class, including methods to save, update, delete, and retrieve employee records.

UtilityDB Class
Provides a method to establish a connection to the SQL database.

Contributing
If you would like to contribute to this project, please fork the repository and submit a pull request with your changes.

License
This project is licensed under the MIT License.

Contact
For any questions or support, please contact [Your Name/Email].
