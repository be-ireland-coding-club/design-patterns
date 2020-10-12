using System;
namespace facade_pattern
{
    public class CloudProviderApi : ICloudProviderApi
    {
        private string tenantName;
        private string accountName;
        private string virtualMachineName;

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
