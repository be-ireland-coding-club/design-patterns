using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{

    abstract class GenerateInvoice
    {

        public abstract IInvoice createInvoice();

        public string emailInvoice()
        {

            var invoice = createInvoice();

            return invoice.send();
        }
    }
}
