package ie.bearingpoint.patterns.observer;

public class BBCNews extends Channel {

    public BBCNews(NewsAgency newsAgency){
        this.newsAgency = newsAgency;
        this.newsAgency.attach(this);
    }

    @Override
    public void update() {
        System.out.println( "BBC News: " + newsAgency.getState() );
    }
}