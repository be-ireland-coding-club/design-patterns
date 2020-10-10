using System;
using Xunit;

namespace facade_pattern.Tests
{
    public class CloudProviderApiTests
    {
        CloudProviderApi unitUnderTest;

        public CloudProviderApiTests()
        {
            unitUnderTest = new CloudProviderApi();
        }

        [Fact]
        public void CanCreateATenantAndGetA200Response()
        {
            int responseCode = unitUnderTest.CreateTenant("TestTenant");

            Assert.True(responseCode == 201);
        }

        [Fact]
        public void CannotCreateTheSameTenantTwiceAndGet400Response()
        {
            unitUnderTest.CreateTenant("TestTenant");

            int responseCode = unitUnderTest.CreateTenant("TestTenant");

            Assert.True(responseCode == 400);
        }

        [Fact]
        public void CanCreateTwoDifferentTenantsAndGet200Response()
        {
            unitUnderTest.CreateTenant("TestTenant1");

            int responseCode = unitUnderTest.CreateTenant("TestTenant2");

            Assert.True(responseCode == 201);
        }

        [Fact]
        public void CannotCreateAnAccountWithoutATenantWillGetA400Response()
        {
            int responseCode = unitUnderTest.CreateAccount("TestAccount");

            Assert.True(responseCode == 400);
        }

        [Fact]
        public void CanCreateAnAccountWithAfterATenantIsCreatedAndGetA200Response()
        {
            unitUnderTest.CreateTenant("TestTenant");
            int responseCode = unitUnderTest.CreateAccount("TestAccount");

            Assert.True(responseCode == 201);
        }

        [Fact]
        public void CannotCreateAnDuplicateAccountAfterATenantIsCreatedAndGetA400Response()
        {
            unitUnderTest.CreateTenant("TestTenant");
            unitUnderTest.CreateAccount("TestAccount");
            int responseCode = unitUnderTest.CreateAccount("TestAccount");

            Assert.True(responseCode == 400);
        }

        [Fact]
        public void CanCreateTwoDifferentAccountsAndGet200Response()
        {
            unitUnderTest.CreateTenant("TestTenant");
            unitUnderTest.CreateAccount("TestAccount1");
            int responseCode = unitUnderTest.CreateAccount("TestAccount2");

            Assert.True(responseCode == 201);
        }

        [Fact]
        public void CannotCreateAVirtualMachineWithoutAnAccountWillGetA400Response()
        {
            int responseCode = unitUnderTest.CreateVirtualMachine("TestVirtualMachine");

            Assert.True(responseCode == 400);
        }

        [Fact]
        public void CanCreateAVirtualMachineAfterAnAccountIsCreatedAndGetA200Response()
        {
            unitUnderTest.CreateTenant("TestTenant");
            unitUnderTest.CreateAccount("TestAccount");
            int responseCode = unitUnderTest.CreateVirtualMachine("TestVirtualMachine");

            Assert.True(responseCode == 201);
        }

        [Fact]
        public void CannotCreateAnDuplicateVirtualMachineAfterAnAccountIsCreatedAndGetA400Response()
        {
            unitUnderTest.CreateTenant("TestTenant");
            unitUnderTest.CreateAccount("TestAccount");
            unitUnderTest.CreateVirtualMachine("TestVirtualMachine");
            int responseCode = unitUnderTest.CreateVirtualMachine("TestVirtualMachine");

            Assert.True(responseCode == 400);
        }

        [Fact]
        public void CanCreateTwoDifferentVirtualMachinessAndGet200Response()
        {
            unitUnderTest.CreateTenant("TestTenant");
            unitUnderTest.CreateAccount("TestAccount");
            unitUnderTest.CreateVirtualMachine("TestVirtualMachine1");
            int responseCode = unitUnderTest.CreateVirtualMachine("TestVirtualMachine2");

            Assert.True(responseCode == 201);
        }
    }
}
