using System;

namespace factory_pattern
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(new Client().execute());
        }
    }
}
