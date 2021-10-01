import java.util.ArrayList;
import java.util.List;

public class NewsAgency {

    private List<Channel> channels = new ArrayList<Channel>();
    private String state;

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
        notifyAllObservers();
    }

    public void attach(Channel channel){
        channels.add(channel);
    }

    public void notifyAllObservers(){
        for (Channel channel : channels) {
            channel.update();
        }
    }
}
