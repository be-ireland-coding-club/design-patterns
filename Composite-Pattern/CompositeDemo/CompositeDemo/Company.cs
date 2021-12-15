using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    public class Company
    {
        public static void Main(string[] args)
        {
            Developer dev1 = new Developer(100, "Dev 1", "Senior Developer");
            Developer dev2 = new Developer(101, "Dev 2", "Developer");
            Team devTeam = new Team();
            devTeam.AddEmployee(dev1);
            devTeam.AddEmployee(dev2);

            Manager man1 = new Manager(200, "Manager 1", "Senior Manager");
            Manager man2 = new Manager(201, "Manager 2", "Manager");
            Team managementTeam = new Team();
            managementTeam.AddEmployee(man1);
            managementTeam.AddEmployee(man2);

            Team devopsTeam = new Team();
            devopsTeam.AddEmployee(devTeam);
            devopsTeam.AddEmployee(managementTeam);
            devopsTeam.GetData();

            Console.ReadKey();
        }
    }
}
