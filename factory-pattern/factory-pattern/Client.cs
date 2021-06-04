using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    class Client
    {
        private GenerateInvoice _generateInvoice;

        public void init()
        {
            //var config = readfromConfigFile etc.
            //use config.lang or get locale
            //Just hardcoding for example here

            var lang = "fr";
            if (lang == "eng")
            {
                _generateInvoice = new GenerateEnglishInvoice();
            }
            else if (lang == "fr")
            {
                _generateInvoice = new GenerateFrenchInvoice();
            }
            else
            {
                throw new Exception("Unkown language");
            }
        }

        public string execute()
        {
            this.init();
            return _generateInvoice.emailInvoice();
        }
    }
}
