// Allows you to separate a "set of types" from the logic to work with them.
//
// Rather than lots of types having to have methods for various 'actions', they can focus more on being 'just data'.
// If you add new 'actions', you do not need to go an update all the types to have this new method, you just add a new Visitor.
// If you do add a new type though, all the visitors need to be updated to handle this.

fun main(args: Array<String>) {
    // We create a 'car' and a 'visitor'
    val myCar = Car()
    val aVisitor = BasicCarPartVisitor()
    // We then use the visitor to visit the car
    myCar.accept(aVisitor)
    // or we could just do those three lines in one go
    Car().accept(BasicCarPartVisitor())

    // We don't have to use it _just_ for a complete Car though, nor be so borring
    Wheel("spare").accept(ExpressiveCarPartVisitor())
    Engine("huge").accept(ExpressiveCarPartVisitor())
    Car("Black",).accept(ExpressiveCarPartVisitor())

    // The visitors are objects, and thus can store state if we want to
    Car().accept(StatefullCarPartVisitor())
    Car().accept(StatefullCarPartVisitor())
    // Compare
    val visitor = StatefullCarPartVisitor()
    Car().accept(visitor)
    Car().accept(visitor)

    // Perhaps 'inpsect' the visitor at the end?
    val countingVisitor = CarPartTrackingVisitor()
    countingVisitor.printReport()
    Car().accept(countingVisitor)
    countingVisitor.printReport()
    listOf(
        Engine("100cc"),
        Wheel("rugged"),
        Body("red"),Body("green"),Body("blue"),
    ).forEach { it.accept(countingVisitor) }
    countingVisitor.printReport()
}