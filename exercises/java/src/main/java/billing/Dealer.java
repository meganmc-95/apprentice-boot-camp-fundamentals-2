package billing;

public class Dealer implements Customer {
    private final String name;
    private final int adverts;
    private final String[] products;

    Dealer(String name, int adverts, String[] products) {
        this.name = name;
        this.adverts = adverts;
        this.products = products;
    }

    @Override
    public String name() {
        return name;
    }

    public Bill generateBill() {
        return new Bill(name(), 50 * adverts + 10 * products.length * adverts);
    }
}
