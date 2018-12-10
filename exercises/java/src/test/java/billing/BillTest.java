package billing;

import org.junit.Test;

import static org.assertj.core.api.Assertions.*;

public class BillTest {
    @Test
    public void equality() {
        assertThat(new Bill("bob", 0)).isEqualTo(new Bill("bob", 0));
    }

    @Test
    public void inequality() {
        Bill bobOwingNothing = new Bill("bob", 0);
        Bill bobOwingSomething = new Bill("bob", 10);
        assertThat(bobOwingNothing).isNotEqualTo(bobOwingSomething);
        
        Bill sarahOwingNothing = new Bill("sarah", 0);
        assertThat(bobOwingNothing).isNotEqualTo(sarahOwingNothing);
    }

}