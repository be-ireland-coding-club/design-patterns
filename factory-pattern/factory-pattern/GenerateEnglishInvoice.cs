using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    class GenerateEnglishInvoice : GenerateInvoice
    {
        public override IInvoice createInvoice()
        {
            return new EnglishInvoice();
        }
    }
}
