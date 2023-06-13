using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_operation_with_LINQ
{
    class Department
    {
        public static List<Department> departments = new List<Department>();

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        

        public  void insertDepartment()
        { 

            Console.WriteLine("Please Enter your Department id:");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter your Department Name:");
            string Name = Console.ReadLine();


             //Console.WriteLine("Please Enter your Employee id:");
             //int EmpId= Convert.ToInt32(Console.ReadLine()); 

            this.DepartmentId = Id;
            this.DepartmentName = Name; 
            //this.EmployeeId = EmpId;

            departments.Add(this);

        }
        public void ReadDepartment()
        {

            for (int i = 0; i < departments.Count; i++)
            {
                Console.WriteLine(departments[i].DepartmentId);
                Console.WriteLine(departments[i].DepartmentName);
                //Console.WriteLine(departments[i].EmployeeSalary);
            }
            var table = new ConsoleTable("Id", "Name");

            foreach (var dept in departments)
            {
              table.AddRow(dept.DepartmentId, dept.DepartmentName);
            }

            table.Write();

        }
    }
}
