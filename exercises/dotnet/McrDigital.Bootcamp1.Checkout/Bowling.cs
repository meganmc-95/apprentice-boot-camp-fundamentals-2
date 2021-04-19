namespace McrDigital.Bootcamp1.Checkout {
  public class Bowling {

      public bool isSpare(int first, int second) {
          return ((first + second) == 10) && (first != 10);
      }

      public bool isStrike(int first) {
          return first == 10;
      }

      public int Score(int[] rolls) {
          var score = 0;
          int increment = 2;

          for(int i = 0; i < rolls.Length; i += increment) {
              increment = 2;
              var firstRoll = rolls[i];
              var secondRoll = rolls[i + 1];

              score += firstRoll;
              score += secondRoll;

              if(isStrike(firstRoll)) {
                increment = 1;
                score += rolls[i + 2];
                score += rolls[i + 3];
              } else if(isSpare(firstRoll, secondRoll)) {
                  score += rolls[i + 2];
              } 
          }

          return score;
      }
  }

}