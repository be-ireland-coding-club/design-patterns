using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    public class Team : IEmployee
    {
        private readonly List<IEmployee> employeeList = new List<IEmployee>();

        public void GetData() {
            foreach (IEmployee employee in employeeList) {
                employee.GetData();
            }
        }
        public void AddEmployee(IEmployee employee) {
            employeeList.Add(employee);
        }
        public void RemoveEmployee(IEmployee employee) {
            employeeList.Remove(employee);
        }
    }
}
