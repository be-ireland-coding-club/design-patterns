using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{

    class FrenchInvoice : IInvoice
    {
        public string send()
        {
            //Implementation specific code goes here
            return "Sent invoice in French";
        }
    }
}
