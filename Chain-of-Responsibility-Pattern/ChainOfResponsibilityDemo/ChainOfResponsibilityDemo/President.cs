using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Quantity < 100000.0)
            {
                Console.WriteLine("{0} approved of request ID: {1} \n", this.GetType().Name, purchase.Id);
            }
            else {
                Console.WriteLine("Request {0} requires a meeting for discussion. \n", purchase.Id);
            }

        }
    }
}
