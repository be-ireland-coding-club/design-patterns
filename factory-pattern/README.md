# The Factory Pattern

Factory Method pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

In this example solution the product being created is an invoice, the creator of this product then carries out some buisness logic by sending a email of the invoice to customers. Initally the implentation of the gernation of this invoice may have only been in English, but as the software being sold expands their is a need to generate a invoice in different languages. By following the factory pattern sub classes of the creator are easily able to swap the concerte product (type of invoice) being instaniated without having to change the buisness logic of sending the email.

For more information about the Factory Pattern you can read up on it [here](https://refactoring.guru/design-patterns/factory-method).

# UML Diagram of Invoice Example
![UML Diagram](./imgs/factory-method-uml.png)