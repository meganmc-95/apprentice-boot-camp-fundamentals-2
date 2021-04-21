using System.Runtime.InteropServices;

namespace McrDigital.Bootcamp1.Checkout
{
    using System;

    public class Receipt
    {
        private string _text = String.Empty;
        private int _total;
        private int _numberOfA;
        private int _numberOfB;
        private const string ITEM_A = "A";
        private const string ITEM_B = "B";

        public string Text
        {
            get => $"{this._text}Total: {this._total}";
        }

        public void Scanned(string item, int totalAmount, [Optional] int numberOfItem, [Optional] int discountCondition, [Optional] int discount, [Optional] string discountAmount)
        {
            if (item == ITEM_A)
            {
                this._numberOfA++;
                DiscountedItems(item, totalAmount, numberOfItem, discountCondition, discount, discountAmount);
            }
            else if (item == ITEM_B)
            {
                this._numberOfB++;
                DiscountedItems(item, totalAmount, numberOfItem, discountCondition, discount, discountAmount);
            } 
            else
            {
                this._text = $"{this._text}{item}: {totalAmount}\n";
                this._total += totalAmount;
            }
        }

        private void DiscountedItems(string item, int totalAmount, int numberOfItem, int discountCondition, int discount, string discountAmount)
        {
            this._text = $"{this._text}{item}: {totalAmount}";
            this._total += totalAmount;
            Discount(numberOfItem, discountCondition, discount, discountAmount);
            this._text = $"{this._text}\n";
        }

        private void Discount(int numberOfItem, int discountCondition, int discount, string discountAmount)
        {
            if (numberOfItem % discountCondition == 0)
            {
                this._text = $"{this._text} - {discount} ({discountCondition} for {discountAmount})";
                this._total -= discount;
            }
        }
    }
}