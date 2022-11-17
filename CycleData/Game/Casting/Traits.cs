using System;
using System.Collections.Generic;
using System.Linq;
using CycleData.Game.Casting;

namespace CycleData.Game.Casting
{
    /// <summary>
    /// <para>A list of traits for each individual bike.</para>
    /// <para>The responsibility of traits are to fill in the PrepareBody method of Bicycles.</para>
    /// /// </summary>
    public class Traits
    {
        public Color color1;
        public Color color2;
        public int direction = 1;
        public int no ;

        public int x = 0;
        public int y = 0;

        public Traits(int id)
        {
            if (id == 1){
                no = 1;
                color1 = Constants.RED;
                color2 = Constants.BLUE;
                x = 0;
                y = 0;

            }
            if (id == 2){
                color1 = Constants.BLUE;
                color2 = Constants.GREEN;
                x = 50;
                y = 100;
            }
            if (id == 3){
                color1 = Constants.YELLOW;
                color2 = Constants.WHITE;
                x = 50;
                y = -100;
            }
            if (id == 4){
                color1 = Constants.YELLOW;
                color2 = Constants.RED;
                x = 100;
                y = 0;
            }
        }
    }
}