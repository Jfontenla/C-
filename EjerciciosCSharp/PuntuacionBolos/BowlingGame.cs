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

        public int Score() {
            int result = 0;
            int count = 0;
            foreach(string frame in _frames)
            {
                var points = new int();
                var isInteger = int.TryParse(frame, out points);
               
                if (isInteger)
                {
                    result += points;
                }else if (isSemiFull(frame) || isFull(frame))
                {
                    if (isSemiFull(frame))
                    {
                        result += ScoreSemiFull(_frames, count);
                    }
                    else
                    {
                        
                    }
                }
                count++;
                
            }
            return result;
        }

        public bool isSemiFull(string frame)
        {
            return frame.Trim() == "/";
        }
        public bool isFull(string frame)
        {
            return frame.Trim().ToUpper() == "X";
        }
        public int ScoreSemiFull(ArrayList _frames,int position )
        {
            var Score = new int();
            var pointsNextPosition = _frames[position + 1].ToString();
            Score = 10 + int.Parse(pointsNextPosition) - int.Parse(_frames[position-1].ToString());
            return Score;
        }

        public int ScoreFull(ArrayList _frames, int position)
        {
            var score = new int();
            score = 10 + int.Parse(_frames[position + 1].ToString()) +int.Parse( _frames[position + 2].ToString());
            return score;
        }


    }
}
