package ie.bearingpoint.patterns.state;

public interface PackageState {

    void next(Package pkg);
    void prev(Package pkg);
    void printStatus();
}