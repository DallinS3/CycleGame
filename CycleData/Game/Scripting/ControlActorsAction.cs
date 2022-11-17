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
        private Point _direction = new Point(0, Constants.CELL_SIZE);
        // private Point _directionS = new Point(0, Constants.CELL_SIZE);
        // private Point _directionD = new Point(0, Constants.CELL_SIZE);
        // private Point _directionN = new Point(0, Constants.CELL_SIZE);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this._keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            foreach (Bicycle bike in cast.GetActors("bicycle"))
            {
                int no = bike.GetBikeNo();
                // left
                if ((_keyboardService.IsKeyDown("a") && no == 1) || 
                    (_keyboardService.IsKeyDown("left") && no == 2) || 
                    (_keyboardService.IsKeyDown("j") && no == 3) || 
                    (_keyboardService.IsKeyDown("four") && no == 4))
            {
                _direction = new Point(-Constants.CELL_SIZE, 0);
            }
           
            
            // right
            if ((_keyboardService.IsKeyDown("d") && no == 1) ||
                 (_keyboardService.IsKeyDown("right") && no == 2) || 
                 (_keyboardService.IsKeyDown("l") && no == 3) || 
                 (_keyboardService.IsKeyDown("six") && no == 4))
            {
                _direction = new Point(Constants.CELL_SIZE, 0);
            }

            // up 
            if ((_keyboardService.IsKeyDown("w") && no == 1) || 
            (_keyboardService.IsKeyDown("up") && no == 2) || 
            (_keyboardService.IsKeyDown("i") && no == 3) || 
            (_keyboardService.IsKeyDown("eight") && no == 4))
            {
                _direction = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if ((_keyboardService.IsKeyDown("s") && no == 1) || 
            (_keyboardService.IsKeyDown("down") && no == 2) || 
            (_keyboardService.IsKeyDown("k") && no == 3) || 
            (_keyboardService.IsKeyDown("five") && no == 4))
            {
                _direction = new Point(0, Constants.CELL_SIZE);
            }

            
                // Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
                bike.TurnBike(_direction);
            }

            // Bicycle dragoneer = (Bicycle)cast.GetFirstActor("dragon");
            // dragoneer.TurnBike(_directionD);

            // Bicycle shadower = (Bicycle)cast.GetFirstActor("shadow");
            // shadower.TurnBike(_directionS); 

            // Bicycle ninjago = (Bicycle)cast.GetFirstActor("ninja");
            // ninjago.TurnBike(_directionN);
        }
    }
}