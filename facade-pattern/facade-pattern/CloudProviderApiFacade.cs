using System;
namespace facade_pattern
{
    public class CloudProviderApiFacade
    {
        private CloudProviderApi api;
        public CloudProviderApiFacade()
        {
            api = new CloudProviderApi();
        }


        public string CreateVirtualMachine(string tenantName, string accountName, string virtualMachineName)
        {
            int createTenantResponse = api.CreateTenant(tenantName);
            string message;
            if (IsResponseCodeSuccessful(createTenantResponse))
            {
                int createAccountResponse = api.CreateAccount(accountName);
                if (IsResponseCodeSuccessful(createAccountResponse))
                {
                    int createVirtualMachineResponse = api.CreateVirtualMachine(virtualMachineName);
                    if (IsResponseCodeSuccessful(createVirtualMachineResponse))
                    {
                        message = "Success";
                    }
                    else
                    {
                        message = "Unable to create virtual machine";
                    }
                }
                else
                {
                    message = "Unable to create account";
                }
            }
            else
            {
                message = "Unable to create tenant";
            }
            return message;
        }

        private bool IsResponseCodeSuccessful(int responseCode)
        {
            return responseCode == 201;
        }
    }
}
