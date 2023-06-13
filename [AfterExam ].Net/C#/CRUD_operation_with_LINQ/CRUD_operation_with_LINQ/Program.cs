using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_operation_with_LINQ
{
    class Program
    {

        

        static void Main(string[] args)
        {

            Employee emp = new Employee();
            Department dept = new Department();

            m:
            Console.WriteLine("===============Welcome to CRUD Operation===============");
            Console.WriteLine("Insert Data Employee : 1");
            Console.WriteLine("Insert Data Department : 2");
            Console.WriteLine("Read Employee : 3");
            Console.WriteLine("Delete Dapartment : 4");
            Console.WriteLine("perform join : 5");

            int process = Convert.ToInt32(Console.ReadLine());

            switch (process)
            {
                case 1:
                    emp.insertEmployee();
                    goto m;
                case 2:
                    dept.insertDepartment();
                     goto m;
                case 3:
                    emp.ReadEmployee();
                    goto m;
                case 4:
                    dept.ReadDepartment();
                    goto m;
                case 5:
                    InnerJoin();
                    goto m;
                default:
                    break;
            }                

        }
        public static void InnerJoin()
        {
            var join_result = from Emp in Employee.employees
                       join dept in Department.departments
                       on Emp.DepartmentId equals dept.DepartmentId
                       select new
                       {
                           Emp.EmployeeName,
                           Emp.EmployeeSalary,
                           DepartmentName = dept.DepartmentName
                       };
            var table = new ConsoleTable("EmployeeName", "DepartmentName");

            foreach (var i in join_result)

            {
                table.AddRow(i.EmployeeSalary,i.DepartmentName);
            }

            table.Write();
        }



       

       
       
        
    }

}
