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
        public string name;
        public int x = 0;
        public int y = 0;

        /// <summary>
        /// Assigns specific traits to a bike based on its ID
        /// </summary>
        /// <param name="id"></param>
        public Traits(int id)
        {
            if (id == 1){
                no = 1;
                color1 = Constants.RED;
                color2 = Constants.WHITE;
                x = (Constants.MAX_X - (Constants.CELL_SIZE * 5));
                y = (Constants.MAX_Y - (Constants.CELL_SIZE * 5));
                name = "Zoomer";

            }
            if (id == 2){
                color1 = Constants.YELLOW;
                color2 = Constants.ORANGE;
                x = (Constants.MAX_X - (Constants.CELL_SIZE * 22));
                y = (Constants.MAX_Y - (Constants.CELL_SIZE * 12));
                name = "Slim Shadow";
            }
            if (id == 3){
                color1 = Constants.GRAY;
                color2 = Constants.GREY;
                x = (Constants.MAX_X - (Constants.CELL_SIZE * -14));
                y = (Constants.MAX_Y - (Constants.CELL_SIZE * -10));
                name = "Pendragon";
            }
            if (id == 4){
                color1 = Constants.DARKBLUE;
                color2 = Constants.BLUE;
                x = (Constants.MAX_X - (Constants.CELL_SIZE * -3));
                y = (Constants.MAX_Y - (Constants.CELL_SIZE *-3));
                name = "Ninjago";
            }
        }
    }
}