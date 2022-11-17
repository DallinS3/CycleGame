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
                
                int num = bike.GetBikeNo();
                _direction = bike.GetVelocity();

                // left
                if ((_keyboardService.IsKeyDown("a") && num == 1) || 
                    (_keyboardService.IsKeyDown("left") && num == 2) || 
                    (_keyboardService.IsKeyDown("j") && num == 3) || 
                    (_keyboardService.IsKeyDown("four") && num == 4))
                    {
                        _direction = new Point(-Constants.CELL_SIZE, 0);
                        bike.TurnBike(_direction);
                    }
                
                    
                    // right
                    if ((_keyboardService.IsKeyDown("d") && num == 1) ||
                        (_keyboardService.IsKeyDown("right") && num == 2) || 
                        (_keyboardService.IsKeyDown("l") && num == 3) || 
                        (_keyboardService.IsKeyDown("six") && num == 4))
                    {
                        _direction = new Point(Constants.CELL_SIZE, 0);
                        bike.TurnBike(_direction);
                    }

                    // up 
                    if ((_keyboardService.IsKeyDown("w") && num == 1) || 
                    (_keyboardService.IsKeyDown("up") && num == 2) || 
                    (_keyboardService.IsKeyDown("i") && num == 3) || 
                    (_keyboardService.IsKeyDown("eight") && num == 4))
                    {
                        _direction = new Point(0, -Constants.CELL_SIZE);
                        bike.TurnBike(_direction);
                    }

                    // down
                    if ((_keyboardService.IsKeyDown("s") && num == 1) || 
                    (_keyboardService.IsKeyDown("down") && num == 2) || 
                    (_keyboardService.IsKeyDown("k") && num == 3) || 
                    (_keyboardService.IsKeyDown("five") && num == 4))
                    {
                        _direction = new Point(0, Constants.CELL_SIZE);
                        bike.TurnBike(_direction);
                    }

            
                // Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
                bike.GrowTrail(1, bike.GetTrailColor());
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