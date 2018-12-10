package billing;

public interface Customer {

    String name();

    Bill generateBill();
    
}
