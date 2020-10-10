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
    public class CloudProviderApi
    {
        private string tenantName;
        private string accountName;
        private String virtualMachineName;

        private readonly int SuccessResponseCode = 201;
        private readonly int ErrorResponseCode = 400;

        public CloudProviderApi()
        {
        }

        public int CreateTenant(string tenantName)
        {
            int responseCode = ErrorResponseCode;
            if (this.tenantName == null || this.tenantName != tenantName)
            {
                this.tenantName = tenantName;
                responseCode = SuccessResponseCode;
            }
            return responseCode;
        }

        public int CreateAccount(string accountName)
        {
            int responseCode = ErrorResponseCode;
            if (tenantName != null)
            {
                if (this.accountName == null || this.accountName != accountName)
                {
                    this.accountName = accountName;
                    responseCode = SuccessResponseCode;
                }
            }
            return responseCode;
        }

        public int CreateVirtualMachine(string virtualMachineName)
        {
            int responseCode = ErrorResponseCode;
            if (accountName != null)
            {
                if (this.virtualMachineName == null || this.virtualMachineName != virtualMachineName)
                {
                    this.virtualMachineName = virtualMachineName;
                    responseCode = SuccessResponseCode;
                }
            }
            return responseCode;
        }
    }
}
