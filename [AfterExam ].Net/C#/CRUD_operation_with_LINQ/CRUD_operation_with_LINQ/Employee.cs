using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_operation_with_LINQ
{
    class Employee
    {
        public static List<Employee> employees = new List<Employee>();

       
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSalary { get; set; }

        public  int DepartmentId { get; set; }
        public void insertEmployee()
        {

            //Employee emp = new Employee();

            Console.Write("Please Enter your Employee id:");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter your Employee Name:");
            string Name = Console.ReadLine();

            Console.Write("Please Enter your Employee Salary:");
            string Salary = Console.ReadLine();

            Console.WriteLine("Please Enter your Department id:");
            int DeptId= Convert.ToInt32(Console.ReadLine()); 


            this.EmployeeId = Id;
            this.EmployeeName = Name;
            this.EmployeeSalary = Salary;
            this.DepartmentId = DeptId;


            employees.Add(this);


        }

        public void ReadEmployee()
        {
            
            for(int i=0; i< employees.Count; i++)
            {
                Console.WriteLine(employees[i].EmployeeId);
                Console.WriteLine(employees[i].EmployeeName);
                Console.WriteLine(employees[i].EmployeeSalary);

                Console.WriteLine(employees[i].DepartmentId);
            }
            var table = new ConsoleTable("EmployeeId", "EmployeeName", "EmployeeSalary", "DeptId");

            


            foreach (var employee in employees)

            {
                table.AddRow(employee.EmployeeId, employee.EmployeeName, employee.EmployeeSalary,employee.DepartmentId);

            }
            table.Write();

        }
    }
}
