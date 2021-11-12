package ie.bearingpoint.patterns.state;

public class Package {

    private PackageState state = new OrderedState();

    // getter, setter

    public void setState(PackageState newState){
        state=newState;
    }

    public PackageState getState(){
        return state;
    }

    public void previousState() {
        state.prev(this);
    }

    public void nextState() {
        state.next(this);
    }

    public void printStatus() {
        state.printStatus();
    }
}