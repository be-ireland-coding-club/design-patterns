// The decorator pattern is a way to 'dynamically' add logic onto basic types

// Our basic 'StaffMember' interface and an implementation of it, 'Employee'
interface StaffMember {
    val name: String

    fun doWork()

    fun description(): String
}

class Employee(override val name: String): StaffMember {
    override fun doWork() {
        println("I'm $name, doing my work")
    }

    override fun description() = "I do stuff"
}

// A basic decorator will, by default, just forward the work down to what it is decorating
open class StaffMemberDecorator(private val decoratedStaffMember: StaffMember): StaffMember {
    override val name: String
        get() = decoratedStaffMember.name


    override fun doWork() = decoratedStaffMember.doWork()

    override fun description() = decoratedStaffMember.description()
}

class ManagerDecorator(decoratedStaffMember: StaffMember): StaffMemberDecorator(decoratedStaffMember) {
    var managing = emptySet<StaffMember>()

    override fun doWork() {
        super.doWork()
        if(managing.isEmpty()) {
            println("I've no body to boss around")
        } else {
            println("I best poke those lazy bums")
            managing.forEach { it.doWork() }
            println("Hah, that's told them!")
        }
    }

    // We don't have to override this, as the base 'StaffMemberDecorator' provides an implementation
    override fun description() = super.description() + ", well I get others to do it for me"
}

class DeveloperDecorator(decoratedStaffMember: StaffMember): StaffMemberDecorator(decoratedStaffMember) {
    var coffeeLevel = 2

    override fun doWork() {
        if (coffeeLevel > 0) {
            print("<thinks hard> ")
            super.doWork()
            coffeeLevel--
        } else {
            println("Brain no worky! Give coffee!")
        }
    }

    // Well aware this _should_ have more logic around this, but that's besides the point
    fun drinkCoffee(amount: Int) {
        println("<sips coffee> Mmmm, coffee be good")
        coffeeLevel+=amount
    }

    override fun description() = super.description() + ", by turning coffee into code"
}

fun main(args: Array<String>) {
    val uselessJim = Employee("Jim")
    uselessJim.doWork()

    // If we don't want to keep 'jim' in scope, we could do the following for the exact same
    with (Employee("Bob")) {
        doWork()
    }

    with (DeveloperDecorator(Employee("Techbro"))) {
        doWork()
        doWork()
        doWork()
        drinkCoffee(3) // Note, we can only call this function as we have a 'DeveloperDecorator' not a 'StaffMember'
        doWork()
        doWork()
        doWork()
        doWork()
    }

    // Let's give Jim a promotion
    with(ManagerDecorator(uselessJim)) {
        doWork()
        println()
        // Let's give this manager some staff to manage
        managing += Employee("Drone 1")
        managing += Employee("Drone 2")
        managing += Employee("Drone 3")
        doWork()
    }

    // The order we apply these decorators matters!!!
    with (ManagerDecorator(DeveloperDecorator(Employee("manager>developer>employee")))) {
        println(description())
        doWork()
    }
    println()
    with (DeveloperDecorator(ManagerDecorator(Employee("developer>manager>employee")))) {
        println(description())
        doWork()
    }
    // Why does 'description' have the order change, but  'doWork' is the same order?
}