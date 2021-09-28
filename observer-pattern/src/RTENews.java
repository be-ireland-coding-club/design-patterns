public class RTENews extends Channel{

    public RTENews(NewsAgency newsAgency){
        this.newsAgency = newsAgency;
        this.newsAgency.attach(this);
    }

    @Override
    public void update() {
        System.out.println( "RTE News: " + newsAgency.getState()  );
    }
}