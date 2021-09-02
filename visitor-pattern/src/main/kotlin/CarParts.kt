// Our basic interface for 'parts'
// The only 'fingerprint' of the visitor pattern is that 'accept' function
interface CarPart {
    fun accept(visitor: CarPartVisitor)
}

// Now we can just define all the parts we want to add

data class Wheel(val name: String) : CarPart {
    override fun accept(visitor: CarPartVisitor) {
        visitor.visit(this)
    }
}

data class Body(val colour: String) : CarPart {
    override fun accept(visitor: CarPartVisitor) {
        visitor.visit(this)
    }
}

data class Engine(val size: String) : CarPart {
    override fun accept(visitor: CarPartVisitor) {
        visitor.visit(this)
    }
}

class Car(colour: String = "pink", size: String = "tiny") : CarPart {
    private var parts: List<CarPart> = listOf(
        Wheel("front left"), Wheel("front right"),
        Wheel("back left"), Wheel("back right"),
        Body(colour), Engine(size),
    )

    override fun accept(visitor: CarPartVisitor) {
        parts.forEach{ it.accept(visitor) }
        visitor.visit(this)
    }
}

//class SunRoof : CarPart {
//    override fun accept(visitor: CarPartVisitor) {
//        visitor.visit(this);
//    }
//}