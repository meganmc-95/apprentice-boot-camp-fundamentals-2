using Xunit;

namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {
        [Fact]
        public void ShouldCalculateATotalScoreOfZeroWithNoPinsKnockedDown(){
            var bowling = new Bowling();
            var rolls = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(0, totalScore);
        }

        [Fact]
        public void ShouldCalculateATotalScoreWithVariedPinsKnockedDown(){
            var bowling = new Bowling();
            var rolls = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(20, totalScore);
        }
        [Fact]
        public void ShouldCalculateATotalScoreWithSpareIncluded(){
            var bowling = new Bowling();
            var rolls = new int[] {5, 5, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var totalScore = bowling.Score(rolls);

            Assert.Equal(12, totalScore);
        }
    }
}
