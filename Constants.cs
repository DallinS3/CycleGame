using System;
using Microsoft.VisualBasic;
using CycleData.Game.Casting;

namespace CycleData.Game
{
    /// <summary>
    /// <para>A tasty item that bikers like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Constants
    {
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int CELL_SIZE = 15;
        public static int MAX_X = 900;
        public static int MAX_Y = 600;

        public static int FRAME_RATE = 15;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Dorito Factory";
        public static int BIKE_LENGTH = 8;

        public static Color RED = new Color(255, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);
        public static Color DARKBLUE = new Color(0, 0, 225);
        public static Color BLUE = new Color(100, 100, 225);
        public static Color OFFWHITE = new Color(205, 205, 205);
        public static Color DARKGRAY = new Color(50, 50, 50);
        public static Color BLACK = new Color(5, 5, 5);
        public static Color GRAY = new Color(150, 150, 150);
        public static Color GREY = new Color(175, 150, 200);
        public static Color ORANGE = new Color(200, 150, 0);

    }

    // private void TestConstants(Color x)
    // {
    //     Console.WriteLine(x);
    // }
}

