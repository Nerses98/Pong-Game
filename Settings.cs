using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Pong
{
    public enum Direction
    {
        Right,
        Left,
        Up,
        Down
    }
   public class Settings
   {    public static bool GameOver { get; set; }
        public static  int Speed { get; set; }
        public static  int CircleWidth { get; set; }
        public static  int CircleHeight { get; set; }
        public static  int RectWidth { get; set; }
        public static  int RectHeight { get; set; }    
        public static int ballvelX;
        public static  int ballvelY ;
        public static int playervelX;
        public static Direction direction { get; set; }
        public Settings()
        {          
            Speed = 15;
            GameOver = false;
            CircleWidth = 15;
            CircleHeight = 15;
            RectHeight = 15;
            RectWidth = 80;
            ballvelX = 3;
            ballvelY = 3;
            playervelX = 7;
            direction = Direction.Down;
        }
   }
}
