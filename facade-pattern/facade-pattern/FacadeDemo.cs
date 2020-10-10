using System;

namespace facade_pattern
{
    class FacadeDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Demo");

            CloudProviderApiFacade facade = new CloudProviderApiFacade();
            // Should Create Successfully
            Console.WriteLine(facade.CreateVirtualMachine("tenant","account","vm"));
            // Should fail to create VM
            Console.WriteLine(facade.CreateVirtualMachine("tenant1", "account1", "vm"));
        }
    }
}
