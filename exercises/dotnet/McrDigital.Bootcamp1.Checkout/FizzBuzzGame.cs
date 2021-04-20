using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzGame
    {
        private const int ONE_HUNDRED = Byte.MaxValue - 155;
        private const string BUZZ_HEX = "42757a7a";
        private const string FIZZ_HEX = "46697a7a";
        private const int THREE_HEX = 0b11;
        private static readonly string BUZZ = DataTypeConverter.ParseHexBinary(BUZZ_HEX);
        private static readonly string FIZZ = DataTypeConverter.ParseHexBinary(FIZZ_HEX);
        private int currentNumber;
        private int threeCounter;
        private int fiveCounter = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string PlayGame()
        {
            string fizzBuzzResult = "";
            for (; currentNumber < ONE_HUNDRED; currentNumber++) fizzBuzzResult += SetFizzOrBuzz(currentNumber) + " ";

            string trimmedResult = fizzBuzzResult.Substring(0, fizzBuzzResult.Length - 1);
            return trimmedResult;
        }

        private string SetFizzOrBuzz(int currentNumber)
        {
            threeCounter++;
            fiveCounter--;
            bool isThree = threeCounter == THREE_HEX;
            bool isFive = fiveCounter == 0;

            return CheckFizzOrBuzz(currentNumber, isThree, isFive);
        }

        private string CheckFizzOrBuzz(int currentNumber, bool isThree, bool isFive)
        {
            string fizzOrBuzz = isThree || isFive ? "" : (currentNumber + 1).ToString();
            if (isThree) fizzOrBuzz += Fizz();
            if (isFive) fizzOrBuzz += Buzz();
            return fizzOrBuzz;
        }

        private string Buzz()
        {
            fiveCounter = new int[] { 0, 0, 0, 0, 0 }.Length;
            return BUZZ;
        }

        private string Fizz()
        {
            threeCounter = 0;
            return FIZZ;
        }
    }
}