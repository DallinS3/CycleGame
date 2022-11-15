using CycleData.Game.Casting;
using CycleData.Game.Services;


namespace CycleData.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService _keyboardService;
        private Point _directionZ = new Point(Constants.CELL_SIZE, 0);
        private Point _directionS = new Point(Constants.CELL_SIZE, 0);
        private Point _directionD = new Point(Constants.CELL_SIZE, 0);
        private Point _directionN = new Point(Constants.CELL_SIZE, 0);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this._keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast castA, Cast castB, Script script)
        {
            // left
            if (_keyboardService.IsKeyDown("a"))
            {
                _directionZ = new Point(-Constants.CELL_SIZE, 0);
            }
            if (_keyboardService.IsKeyDown("left"))
            {
                _directionD = new Point(-Constants.CELL_SIZE, 0);
            }
            if (_keyboardService.IsKeyDown("j"))
            {
                _directionS = new Point(-Constants.CELL_SIZE, 0);
            }
            if (_keyboardService.IsKeyDown("four"))
            {
                _directionN = new Point(-Constants.CELL_SIZE, 0);
            }
            

            
            // right || _keyboardService.IsKeyDown("right") || _keyboardService.IsKeyDown("l") || _keyboardService.IsKeyDown("six")
            if (_keyboardService.IsKeyDown("d") )
            {
                _directionZ = new Point(Constants.CELL_SIZE, 0);
            }
            if (_keyboardService.IsKeyDown("right") )
            {
                _directionD = new Point(Constants.CELL_SIZE, 0);
            }
            if (_keyboardService.IsKeyDown("l") )
            {
                _directionS = new Point(Constants.CELL_SIZE, 0);
            }
            if (_keyboardService.IsKeyDown("six") )
            {
                _directionN = new Point(Constants.CELL_SIZE, 0);
            }

            // up  || _keyboardService.IsKeyDown("up") || _keyboardService.IsKeyDown("i") || _keyboardService.IsKeyDown("eight")
            if (_keyboardService.IsKeyDown("w"))
            {
                _directionZ = new Point(0, -Constants.CELL_SIZE);
            }
            if (_keyboardService.IsKeyDown("up"))
            {
                _directionD = new Point(0, -Constants.CELL_SIZE);
            }
            if (_keyboardService.IsKeyDown("i"))
            {
                _directionS = new Point(0, -Constants.CELL_SIZE);
            }
            if (_keyboardService.IsKeyDown("eight"))
            {
                _directionN = new Point(0, -Constants.CELL_SIZE);
            }

            // down || _keyboardService.IsKeyDown("down") || _keyboardService.IsKeyDown("k") || _keyboardService.IsKeyDown("five")
            if (_keyboardService.IsKeyDown("s") )
            {
                _directionZ = new Point(0, Constants.CELL_SIZE);
            }
            if (_keyboardService.IsKeyDown("down") )
            {
                _directionD = new Point(0, Constants.CELL_SIZE);
            }
            if (_keyboardService.IsKeyDown("k") )
            {
                _directionS = new Point(0, Constants.CELL_SIZE);
            }
            if (_keyboardService.IsKeyDown("five") )
            {
                _directionN = new Point(0, Constants.CELL_SIZE);
            }


            Bicycle zoomer = (Bicycle)castA.GetFirstActor("zoom");
            zoomer.TurnBike(_directionZ); 

            Bicycle dragoneer = (Bicycle)castB.GetFirstActor("dragon");
            dragoneer.TurnBike(_directionD);

            // Bicycle shadower = (Bicycle)cast.GetFirstActor("shadow");
            // zoomer.TurnBike(_directionS); 

            // Bicycle ninjago = (Bicycle)cast.GetFirstActor("ninja");
            // dragoneer.TurnBike(_directionN);
        }
    }
}