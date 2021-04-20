namespace McrDigital.Bootcamp1.Checkout
{
    using System;

    public class Receipt
    {
        private const int DISCOUNT_CONDITION_A = 5;
        private const int DISCOUNT_A = 30;
        private const string FIVE_A_COST = "220";
        private string _text = String.Empty;
        private int _total;
        private int _numberOfA;
        private int _numberOfB;

        public string Text
        {
            get => $"{this._text}Total: {this._total}";
        }

        public void Scanned(string item, int totalAmount, int numberOfItem, int discountCondition, int discount, string discountAmount)
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

        public void ScannedA()
        {
            this._numberOfA++;
            Scanned("A", 50, _numberOfA, DISCOUNT_CONDITION_A, DISCOUNT_A, FIVE_A_COST);
        }

        public void ScannedB()
        {
            this._numberOfB++;
            Scanned("B", 30, _numberOfB, 2, 15, "45");
        }

        public void ScannedC()
        {
            this._text = $"{this._text}C: 20\n";
            this._total += 20;
        }

        public void ScannedD()
        {
            this._text = $"{this._text}D: 15\n";
            this._total += 15;
        }
    }
}