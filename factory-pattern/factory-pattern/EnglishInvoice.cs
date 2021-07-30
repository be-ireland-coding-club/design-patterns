using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{

    class EnglishInvoice : IInvoice
    {
        public string send()
        {
            //Implementation specific code goes here
            return "Sent invoice in English";
        }
    }
}
