namespace McrDigital.Bootcamp1.Checkout {
  public class Bowling {

      public int[] rolls {get; set;}
      public int Score(int[] rolls) {
          var score = 0;

          for(int i = 0; i < rolls.Length; i++) {
              score += rolls[i];
          }

          return score;
      }
  }

}