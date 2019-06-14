using PuntuacionBolos;
using System.Collections;
using Xunit;

namespace xUnitPuntuacionBolos
{
    public class PuntuacionesBolosTest
    {
        [Fact]
        public void ScoreWithoutPoints()
        {
            var framesWithoutStrikes = new ArrayList { "0","0" ,"0","0" ,"0","0", "0","0", "0","0", "0","0","0","0", "0","0", "0","0" };
            var BowlingGame = new BowlingGame(framesWithoutStrikes);

            var result = BowlingGame.Score();
            Assert.Equal(result, 0);
        }

        [Fact]
        public void ScoreWithPoints()
        {
            var framesWithoutStrikes1 = new ArrayList { "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0","1","0" };
            var BowlingGame1 = new BowlingGame(framesWithoutStrikes1);
            var result1 = BowlingGame1.Score();

            var framesWithoutStrikes2 = new ArrayList { "2", "0", "2", "0", "2", "0", "2", "0", "2", "0", "2", "0", "2", "0", "2", "0", "2", "0","2","0" };
            var BowlingGame2 = new BowlingGame(framesWithoutStrikes2);
            var result2 = BowlingGame2.Score();


            Assert.Equal(result1, 10);
            Assert.Equal(result2, 20);
        }



        [Fact]
        public void IsSemiFull()
        {
            var frame1 = "/";
            var BowlingGame1 = new BowlingGame();
            var result1 = BowlingGame1.isSemiFull(frame1);

            var frame2 = "X";
            var BowlingGame2 = new BowlingGame();
            var result2 = BowlingGame2.isSemiFull(frame2);


            Assert.Equal(result1, true);
            Assert.Equal(result2, false);
        }


        [Fact]
        public void FramesWithSemiPulls()
        {
            var framesWithoutStrikes1 = new ArrayList { "5", "/", "2", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            var BowlingGame1 = new BowlingGame(framesWithoutStrikes1);
            var result1 = BowlingGame1.Score();

            var framesWithoutStrikes2 = new ArrayList { "5", "/", "2", "/", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }; 
            var BowlingGame2 = new BowlingGame(framesWithoutStrikes2);
            var result2 = BowlingGame2.Score();


             framesWithoutStrikes2 = new ArrayList { "5", "/", "0", "/", "0", "/", "0", "/", "0", "/", "0", "/", "0", "/", "0", "/", "0", "/", "0", "/","0" };
            BowlingGame2 = new BowlingGame(framesWithoutStrikes2);
            var result3 = BowlingGame2.Score();

            Assert.Equal(result1, 14);
            Assert.Equal(result2, 22);
            Assert.Equal(result3, 100);
        }

        public void FramesWithPulls()
        {
            var framesWithoutStrikes1 = new ArrayList { "5", "X", "2", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            var BowlingGame1 = new BowlingGame(framesWithoutStrikes1);
            var result1 = BowlingGame1.Score();
        }
    }
}
