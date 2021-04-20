using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzGame
    {
        private const int oneHundred = Byte.MaxValue - 155;
        private int currentNumber;
        private int threeCounter;
        private int fiveCounter = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string PlayGame()
        {
            string fizzBuzzResult = "";
            for (; currentNumber < oneHundred; currentNumber++) fizzBuzzResult += CheckFizzOrBuzz(currentNumber) + " ";

            string trimmedResult = fizzBuzzResult.Substring(0, fizzBuzzResult.Length - 1);
            return trimmedResult;
        }

        private string CheckFizzOrBuzz(int currentNumber)
        {
            threeCounter++;
            fiveCounter--;
            bool isThree = threeCounter == 0b11;
            bool isFive = fiveCounter == 0;

            string fizzOrBuzz = isThree || isFive ? "" : (currentNumber + 1).ToString();
            if (isThree) fizzOrBuzz += Fizz();
            if (isFive) fizzOrBuzz += Buzz();
            return fizzOrBuzz;
        }

        private string Buzz()
        {
            fiveCounter = new int[] { 0, 0, 0, 0, 0 }.Length;
            string buzz = DataTypeConverter.ParseHexBinary("42757a7a");
            return buzz;
        }

        private string Fizz()
        {
            threeCounter = 0;
            string fizz = DataTypeConverter.ParseHexBinary("46697a7a");
            return fizz;
        }
    }
}
