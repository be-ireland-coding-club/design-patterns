@file:Suppress("unused")

// We define this interface 'once', though it does need to be updated as we add new things that could be visited
interface CarPartVisitor {
    fun visit(wheel: Wheel)
    fun visit(body: Body)
    fun visit(engine: Engine)
    fun visit(car: Car)
}

// Now we can define all the 'logic' we want

class BasicCarPartVisitor : CarPartVisitor {
    override fun visit(wheel: Wheel) {
        println("Visiting a wheel")
    }

    override fun visit(body: Body) {
        println("Visiting a body")
    }

    override fun visit(engine: Engine) {
        println("Visiting a engine")
    }

    override fun visit(car: Car) {
        println("Visiting a car")
    }
}

class ExpressiveCarPartVisitor : CarPartVisitor {
    override fun visit(wheel: Wheel) {
        println("Kicking the ${wheel.name} wheel")
    }

    override fun visit(body: Body) {
        println("Polishing the ${body.colour} body")
    }

    override fun visit(engine: Engine) {
        println("Revving up my ${engine.size} engine")
    }

    override fun visit(car: Car) {
        println("Starting my car")
    }
}

class StatefullCarPartVisitor : CarPartVisitor {
    private var wheelCount = 0
    override fun visit(wheel: Wheel) {
        wheelCount++;
        println("Kicking wheel $wheelCount")
    }

    override fun visit(body: Body) {
        println("Polishing the ${body.colour} body")
    }

    override fun visit(engine: Engine) {
        println("Revving up my ${engine.size} engine")
    }

    override fun visit(car: Car) {
        println("Starting my car")
    }

    fun resetCount() {
        wheelCount = 0
    }
}

class CarPartTrackingVisitor : CarPartVisitor {
    private var wheelCount = 0
    private var bodyCount = 0
    private var engineCount = 0
    private var carCount = 0
    
    override fun visit(wheel: Wheel) {
        wheelCount++;
    }

    override fun visit(body: Body) {
        bodyCount++
    }

    override fun visit(engine: Engine) {
        engineCount++
    }

    override fun visit(car: Car) {
        carCount++
    }

    fun printReport() {
        println("We've counted:")
        printPartCount(wheelCount, "wheel")
        printPartCount(bodyCount, "body")
        printPartCount(engineCount, "engine")
        printPartCount(carCount, "car")
    }
    
    private fun printPartCount(count: Int, name: String) {
        println("  $count $name${ if (count == 1) { "" } else { "s" } }")
    }
}