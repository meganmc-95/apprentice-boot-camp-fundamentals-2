using Xunit;

namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {

        private Bowling bowling;
        public BowlingGameTests() {
            this.bowling = new Bowling();
        }

        [Fact]
        public void ShouldCalculateATotalScoreOfZeroWithNoPinsKnockedDown(){
            var rolls = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(0, totalScore);
        }

        [Fact]
        public void ShouldCalculateATotalScoreWithVariedPinsKnockedDown(){
            var rolls = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(20, totalScore);
        }

        [Fact]
        public void ShouldCalculateATotalScoreWithSpareIncluded(){
            var rolls = new int[] {5, 5, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(12, totalScore);
        }

        [Fact]
        public void ShouldCalculateATotalScoreWithStrikeIncluded(){
            var rolls = new int[] {10, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(14, totalScore);
        }
    }
}
