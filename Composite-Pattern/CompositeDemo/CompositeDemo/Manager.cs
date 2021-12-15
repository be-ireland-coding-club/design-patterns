using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    public class Manager : IEmployee
    {
        private readonly string name;
        private readonly long employeeId;
        private readonly string position;

        public Manager(long employeeId, string name, string position) {
            this.employeeId = employeeId;
            this.name = name;
            this.position = position;
        }
        public void GetData()
        {
            Console.WriteLine("EmployeeId: {0} | Name: {1} | Position: {2} \n", this.employeeId, this.name, this.position);
        }
    }
}
