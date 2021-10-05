package ie.bearingpoint.patterns.observer;

public class ABCNews extends Channel{

    public ABCNews(NewsAgency newsAgency){
        this.newsAgency = newsAgency;
        this.newsAgency.attach(this);
    }

    @Override
    public void update() {
        System.out.println( "ABC News: " + newsAgency.getState() );
    }
}