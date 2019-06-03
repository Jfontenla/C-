using PuntuacionBolos;
using System.Collections;
using Xunit;

namespace xUnitPuntuacionBolos
{
    public class PuntuacionesBolosTest
    {
        [Fact]
        public void SocreWithoutPoints()
        {
            var framesWithoutStrikes = new ArrayList { 0,0 ,0,0 ,0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0 };
            var BowlingGame = new BowlingGame(framesWithoutStrikes);

            var result = BowlingGame.Socre();
            Assert.Equal(result, 0);
        }

        [Fact]
        public void SocreWithPoints()
        {
            var framesWithoutStrikes1 = new ArrayList { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 ,1,0 };
            var BowlingGame1 = new BowlingGame(framesWithoutStrikes1);
            var result1 = BowlingGame1.Socre();

            var framesWithoutStrikes2 = new ArrayList { 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0, 2, 0 };
            var BowlingGame2 = new BowlingGame(framesWithoutStrikes2);
            var result2 = BowlingGame2.Socre();


            Assert.Equal(result1, 10);
            Assert.Equal(result2, 20);
        }
    }
}
