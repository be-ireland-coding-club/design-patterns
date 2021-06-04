using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class PrinterThreadSafe
    {
        //static instace of the singleton
        private static PrinterThreadSafe _printerInstance;
        private static readonly object _lock = new object();

        private Queue<string> _queue = new Queue<string>();

        //Private constructor to prevent 'newing' up the class
        private PrinterThreadSafe()
        {

        }

        public static PrinterThreadSafe GetPrinterInstance(string instanceName)
        {
            //If there is no instance of printer class exists then instantiate   
            if (_printerInstance == null)
            {
                lock (_lock)
                {
                    if (_printerInstance == null)
                    {
                        Console.WriteLine("{0} printer object created", instanceName);
                        _printerInstance = new PrinterThreadSafe();
                    }
                }
            }
            return _printerInstance;
        }


        public void AddDocument(string documentName)
        {
            _queue.Enqueue(documentName);
        }

        public void PrintDocument()
        {
            Console.WriteLine(_queue.Dequeue());
        }
    }
}
