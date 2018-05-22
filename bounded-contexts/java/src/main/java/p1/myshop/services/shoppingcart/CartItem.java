package p1.myshop.services.shoppingcart;

import p1.myshop.entities.ItemId;
import p1.myshop.entities.Quantity;

public class CartItem {
    public final ItemId itemId;
    public final Quantity quantity;

    public CartItem(ItemId itemId, Quantity quantity) {
        this.itemId = itemId;
        this.quantity = quantity;
    }

    public ItemId itemId() {
        return itemId;
    }
}
