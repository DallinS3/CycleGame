using CycleData.Game.Casting;
using CycleData.Game.Directing;
using CycleData.Game.Scripting;
using CycleData.Game.Services;


namespace CycleData
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();
            // cast.AddActor("food", new Food());
            cast.AddActor("bicycle", new Bicycle(1));
            cast.AddActor("bicycle", new Bicycle(2));
            cast.AddActor("bicycle", new Bicycle(3));
            cast.AddActor("bicycle", new Bicycle(4));
            // cast.AddActor("score", new Score());
            // cast.AddActor("powa", new PowerUp());

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsActing());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}