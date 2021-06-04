using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    class GenerateFrenchInvoice : GenerateInvoice
    {
        public override IInvoice createInvoice()
        {
            return new FrenchInvoice();
        }
    }
}
