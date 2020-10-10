# The Facade Pattern

The facade pattern is a structural design pattern for simplifying connecting to a library, framework, API or other classes.  The goal of this pattern is to abstract away the complex logic of the external code, behind an interface(Facade).

In the example in this solution, the CloudProviderApi.cs class is meant to represent an API for an external Cloud Provider.  In order to "create" a Virtual Machine within this mock cloud provider, a client needs to create both a tenant and an account beforehand.

The 'client' in this scenario is FacadeDemo.cs, it needs to create a Virtual Machine, and it doesn't need to be exposed to the internals of the Cloud Provider API.  This is where the CloudProviderApiFacade.cs class comes in, as it allows the logic required for the Cloud Provider API to be abstracted away from the client.  If the CloudProviderAPI changes in the future, or the developers go with a different solution the scope of the changes should ideally be isolated to the CloudProviderApiFacade class.

For more information about the Facade Pattern you can read up on it [here](https://refactoring.guru/design-patterns/facade).