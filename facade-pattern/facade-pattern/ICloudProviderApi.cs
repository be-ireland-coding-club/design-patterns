using System;
namespace facade_pattern
{
    /// <summary>
    /// This class is meant to represent an external API, which we cannot change.
    ///
    /// In order to create a VM, within this Cloud Provider a user needs to create both a tenant
    /// and then an account, before hand.
    /// 
    /// </summary>
    public interface ICloudProviderApi
    {
        public int CreateTenant(string tenantName);

        public int CreateAccount(string accountName);

        public int CreateVirtualMachine(string virtualMachineName);
    }
}
