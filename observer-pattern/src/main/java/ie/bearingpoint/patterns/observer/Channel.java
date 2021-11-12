package ie.bearingpoint.patterns.observer;

public abstract class Channel {
    protected NewsAgency newsAgency;
    public abstract void update();
}