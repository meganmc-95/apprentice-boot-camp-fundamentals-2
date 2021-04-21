namespace McrDigital.Bootcamp1.Checkout
{
    public class Checkout
    {
        private int _total;
        private int _numberOfA;
        private int _numberOfB;
        private static readonly Item ItemA = new Item("A", 50, 5, 30, "220"); //static?
        private readonly Item ItemB = new Item("B", 30, 2, 15, "45");
        private readonly Item ItemC = new Item("C", 20);
        private readonly Item ItemD = new Item("D", 15);
        private readonly Receipt _receipt = new Receipt();

        public string Receipt
        {
            get => this._receipt.Text;
        }

        public int Total
        {
            get => this._total;
        }

        public void Scan(string Item)
        {
            if ("A".Equals(Item))
            {
                this._numberOfA++;
                AddPromoItem(ItemA.item, ItemA.totalAmount, this._numberOfA, ItemA.discountCondition, ItemA.discount, ItemA.discountAmount);
            }
            else if ("B".Equals(Item))
            {
                this._numberOfB++;
                AddPromoItem(ItemB.item, ItemB.totalAmount, this._numberOfB, ItemB.discountCondition, ItemB.discount, ItemB.discountAmount);
            }
            else if ("C".Equals(Item))
            {
                AddItem(ItemC.item, ItemC.totalAmount);
            }
            else if ("D".Equals(Item))
            {
                AddItem(ItemD.item, ItemD.totalAmount);
            }
        }

        private void AddPromoItem(string item, int totalAmount, int numberOfItem, int discountCondition, int discount, string discountAmount)
        {
            this._total += totalAmount;
            Discount(numberOfItem, discountCondition, discount);
            this._receipt.Scanned(item, totalAmount, numberOfItem, discountCondition, discount, discountAmount);
        }

        private void AddItem(string item, int itemCost)
        {
            this._total += itemCost;
            this._receipt.Scanned(item, itemCost);
        }

        private void Discount(int numberOfItem, int discountCondition, int discount)
        {
            if (numberOfItem % discountCondition == 0)
            {
                this._total -= discount;
            }
        }
    }
}