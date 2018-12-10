package billing;

public class PrivateCustomer implements Customer {
    private final String name;
    private final int adverts;

    final String[] products;

    public PrivateCustomer(String name, int adverts, String[] products) {
        this.name = name;
        this.adverts = adverts;
        this.products = products;
    }

    @Override
    public String name() {
        return name;
    }

    @Override
    public Bill generateBill() {
        return new Bill(name(), 20 * adverts + 10 * products.length * adverts);
    }
}
