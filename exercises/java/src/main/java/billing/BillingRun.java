package billing;

import java.util.ArrayList;
import java.util.List;

public class BillingRun {
    private final Customer[] customers;

    public BillingRun(Customer... customers) {

        this.customers = customers;
    }

    public List<Bill> bills() {
        final ArrayList<Bill> result = new ArrayList<>();
        for (Customer customer: customers) {
            result.add(customer.generateBill());
        }
        return result;
    }

}
