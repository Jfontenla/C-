using System;
using System.Collections;
using System.Linq;
namespace PuntuacionBolos
{
    public class BowlingGame
    {
        public ArrayList _frames;

        public static void Main() {

        }

        public BowlingGame()
        {
            _frames = new ArrayList();
        }
        public BowlingGame(ArrayList frames)
        {
            _frames = frames;
        }

        public void AddFrame(int firstThrow, int secondThrow) {
            
        }

        public int Socre() {
            int result = 0;
            foreach(int frame in _frames)
            {
                result += frame;
            }
            return result;
        }
    }
}
