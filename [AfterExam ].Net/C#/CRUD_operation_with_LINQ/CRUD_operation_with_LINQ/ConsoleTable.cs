using System;

namespace CRUD_operation_with_LINQ
{
    internal class ConsoleTable
    {
        private string v1;
        private string v2;
        private string v3;

        public ConsoleTable(string v1, string v2, string v3, string v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public ConsoleTable(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void Write()
        {
            throw new NotImplementedException();
        }

        internal void AddRow(int employeeId, string employeeName, string departmentName, int departmentId)
        {
            throw new NotImplementedException();
        }

        internal void AddRow(string employeeName, int departmentId, string departmentName)
        {
            throw new NotImplementedException();
        }

        internal void AddRow(string employeeSalary, string departmentName)
        {
            throw new NotImplementedException();
        }

        internal void AddRow(int departmentId, string departmentName)
        {
            throw new NotImplementedException();
        }
    }
}