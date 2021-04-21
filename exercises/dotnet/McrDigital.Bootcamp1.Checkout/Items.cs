namespace McrDigital.Bootcamp1.Checkout
{
    public class Item
    {
        public string item;
        public int totalAmount;
        public int discountCondition;
        public int discount;
        public string discountAmount;

        public Item(string item, int totalAmount)
        {
            this.item = item;
            this.totalAmount = totalAmount;
        }

        public Item(string item, int totalAmount, int discountCondition, int discount, string discountAmount)
        {
            this.item = item;
            this.totalAmount = totalAmount;
            this.discountCondition = discountCondition;
            this.discount = discount;
            this.discountAmount = discountAmount;

        }
    }
}
