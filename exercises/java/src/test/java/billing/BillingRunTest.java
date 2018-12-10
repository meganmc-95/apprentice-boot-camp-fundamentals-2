package billing;

import org.junit.Test;

import static org.assertj.core.api.Assertions.*;

public class BillingRunTest {
    @Test
    public void empty() {
        assertThat(new BillingRun().bills()).isEmpty();
    }

    @Test
    public void privateCustomerNoAdvertsNoProducts() {
        BillingRun billingRun = new BillingRun(
                new PrivateCustomer("Derek", 0, new String[]{})
        );
        assertThat(billingRun.bills()).containsExactly(new Bill("Derek", 0));
    }

    @Test
    public void privateCustomerWithOneAdvert() {
        BillingRun billingRun = new BillingRun(
                new PrivateCustomer("Derek", 1, new String[]{})
        );
        assertThat(billingRun.bills()).containsExactly(new Bill("Derek", 20));
    }

    @Test
    public void privateCustomerWithOneAdvertOneProduct() {
        BillingRun billingRun = new BillingRun(
                new PrivateCustomer("Derek", 1, new String[]{"Advert promotion"})
        );
        assertThat(billingRun.bills()).containsExactly(new Bill("Derek", 30));
    }

    @Test
    public void dealerWith20AdvertsOneProduct() {
        BillingRun billingRun = new BillingRun(
                new Dealer("Arthur’s Cars", 20, new String[]{"Advert promotion"})
        );
        assertThat(billingRun.bills()).containsExactly(new Bill("Arthur’s Cars", 1200));
    }

    @Test
    public void dealerWith1000AdvertsTwoProducts() {
        BillingRun billingRun = new BillingRun(
                new Dealer("Super Car Market", 1000, new String[]{"Finance", "Valuations"})
        );
        assertThat(billingRun.bills()).containsExactly(new Bill("Super Car Market", 70000));
    }
}
