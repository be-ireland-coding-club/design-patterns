using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    class ApprovalSystem
    {
        public static void Main(string[] args)
        {
            Approver director = new Director();
            Approver vicePrez = new VicePresident();
            Approver prez = new President();

            director.SetSuccessor(vicePrez);
            vicePrez.SetSuccessor(prez);

            Purchase asset1 = new Purchase(2500, 300, "Short-term supplies");
            director.ProcessRequest(asset1);

            Purchase asset2 = new Purchase(2491, 50000, "Long-term supplies");
            director.ProcessRequest(asset2);

            Purchase asset3 = new Purchase(2811, 200000, "Short-term supplies");
            director.ProcessRequest(asset3);

            Console.ReadKey();
        }
    }
}
