import org.junit.Before;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class NewsAgencyTest {

    @Test
    void testObserverPattern() {
        NewsAgency newsAgency = new NewsAgency();

        new ABCNews(newsAgency);
        new BBCNews(newsAgency);
        new RTENews(newsAgency);

        System.out.println("First state change: First headline");
        newsAgency.setState("First headline");
        assertEquals(newsAgency.getState(),"First headline");

        System.out.println("First state change: New headline");
        newsAgency.setState("New headline");
        assertEquals(newsAgency.getState(),"New headline");
    }
}