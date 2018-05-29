package p1.myshop.entities;

public class Quantity {

    int value;

    Quantity(int value) {
        this.value = value;
    }

    public int toInt() {
        return value;
    }
}
