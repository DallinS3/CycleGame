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
        private Point _direction = new Point(Constants.CELL_SIZE, 0);

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
            // left
            if (_keyboardService.IsKeyDown("a") || _keyboardService.IsKeyDown("left") || _keyboardService.IsKeyDown("j") || _keyboardService.IsKeyDown("four"))
            {
                _direction = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (_keyboardService.IsKeyDown("d") || _keyboardService.IsKeyDown("right") || _keyboardService.IsKeyDown("l") || _keyboardService.IsKeyDown("six"))
            {
                _direction = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (_keyboardService.IsKeyDown("w") || _keyboardService.IsKeyDown("up") || _keyboardService.IsKeyDown("i") || _keyboardService.IsKeyDown("eight"))
            {
                _direction = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (_keyboardService.IsKeyDown("s") || _keyboardService.IsKeyDown("down") || _keyboardService.IsKeyDown("k") || _keyboardService.IsKeyDown("five"))
            {
                _direction = new Point(0, Constants.CELL_SIZE);
            }

            Bicycle zoomer = (Bicycle)cast.GetFirstActor("zoom");
            zoomer.TurnBike(_direction); 

            Bicycle dragoneer = (Bicycle)cast.GetFirstActor("dragon");
            dragoneer.TurnBike(_direction);

            Bicycle shadower = (Bicycle)cast.GetFirstActor("shadow");
            zoomer.TurnBike(_direction); 

            Bicycle ninjago = (Bicycle)cast.GetFirstActor("ninja");
            dragoneer.TurnBike(_direction);
        }
    }
}