namespace McrDigital.Bootcamp1.Checkout {
  public class Bowling {
      public int Score(int[] rolls) {
          var score = 0;

          for(int i = 0; i < rolls.Length; i += 2) {
              var firstRoll = rolls[i];
              var secondRoll = rolls[i + 1];
              var spareStrike = firstRoll + secondRoll;

              score += firstRoll;
              score += secondRoll;

              if(spareStrike == 10) {
                  score += rolls[i + 2];
              }

          }

          return score;
      }
  }

}