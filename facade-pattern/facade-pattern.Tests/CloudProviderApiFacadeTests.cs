using System;
using Moq;
using Xunit;

namespace facade_pattern.Tests
{
    public class CloudProviderApiFacadeTests
    {
        private CloudProviderApiFacade unitUnderTest;

        [Fact]
        public void FacadeReturnsCorrectResultWhenTenantCantBeCreated()
        {
            // Given
            var mock = new Mock<ICloudProviderApi>();
            mock.Setup(foo => foo.CreateTenant(It.IsAny<string>())).Returns(400);

            unitUnderTest = new CloudProviderApiFacade(mock.Object);


            // When
            string response = unitUnderTest.CreateVirtualMachine("TestTenant", "TestAccount", "TestVirtualMachine");

            // Then
            Assert.Equal("unable to create tenant", response.ToLower());
        }

        [Fact]
        public void FacadeReturnsCorrectResultWhenAccountCantBeCreated()
        {
            // Given
            var mock = new Mock<ICloudProviderApi>();
            mock.Setup(foo => foo.CreateTenant(It.IsAny<string>())).Returns(201);
            mock.Setup(foo => foo.CreateAccount(It.IsAny<string>())).Returns(400);
            mock.Setup(foo => foo.CreateVirtualMachine(It.IsAny<string>())).Returns(201);

            unitUnderTest = new CloudProviderApiFacade(mock.Object);


            // When
            string response = unitUnderTest.CreateVirtualMachine("TestTenant", "TestAccount", "TestVirtualMachine");

            // Then
            Assert.Equal("unable to create account", response.ToLower());
        }

        [Fact]
        public void FacadeReturnsCorrectResultWhenVirtualMachineCantBeCreated()
        {
            // Given
            var mock = new Mock<ICloudProviderApi>();
            mock.Setup(foo => foo.CreateTenant(It.IsAny<string>())).Returns(201);
            mock.Setup(foo => foo.CreateAccount(It.IsAny<string>())).Returns(201);
            mock.Setup(foo => foo.CreateVirtualMachine(It.IsAny<string>())).Returns(400);

            unitUnderTest = new CloudProviderApiFacade(mock.Object);


            // When
            string response = unitUnderTest.CreateVirtualMachine("TestTenant", "TestAccount", "TestVirtualMachine");

            // Then
            Assert.Equal("unable to create virtual machine", response.ToLower());
        }

        [Fact]
        public void FacadeReturnsCorrectResultWhenVirtualMachineCreatedSuccessfully()
        {
            // Given
            var mock = new Mock<ICloudProviderApi>();
            mock.Setup(foo => foo.CreateTenant(It.IsAny<string>())).Returns(201);
            mock.Setup(foo => foo.CreateAccount(It.IsAny<string>())).Returns(201);
            mock.Setup(foo => foo.CreateVirtualMachine(It.IsAny<string>())).Returns(201);

            unitUnderTest = new CloudProviderApiFacade(mock.Object);


            // When
            string response = unitUnderTest.CreateVirtualMachine("TestTenant", "TestAccount", "TestVirtualMachine");

            // Then
            Assert.Equal("success", response.ToLower());
        }
    }
}
