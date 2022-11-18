using System;
using System.Collections.Generic;
using System.Data;
using CycleData.Game.Casting;
using CycleData.Game.Services;


namespace CycleData.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool _isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (_isGameOver == false)
            {
                HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
            Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
            // Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
            // Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
            // Score score = (Score)cast.GetFirstActor("score");
            // PowerUp power_up = (PowerUp)cast.GetFirstActor("powa");
            
            // if (zoom.GetBike().GetPosition().Equals(power_up.GetPosition()))
            // {
            //     int points = power_up.GetPoints();
            //     zoom.GrowTrail(points);
            //     // score.AddPoints(points);
            //     power_up.Reset();
            // }
        }

        /// <summary>
        /// Sets the game over flag if a bike collides with another bike or trail segment.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            
            // Bicycle drag = (Bicycle)cast.GetFirstActor("dragon");
            // Bicycle slimshad = (Bicycle)cast.GetFirstActor("shadow");
            // Bicycle shuriken = (Bicycle)cast.GetFirstActor("ninja");
            
            // Actor bike2 = slimshad.GetBike();
            
            // List<Actor> body2 = slimshad.GetBody();

            foreach(Bicycle bicycle in cast.GetActors("bicycle")) //bike that will compare to another bike and its segments
            {
                Actor bike = bicycle.GetBike();

                foreach(Bicycle path in cast.GetActors("bicycle")) // second bike from which the segments are from
                {
                    foreach(Actor segment in path.GetSegments())
                    {
                        if (bike.GetPosition().Equals(segment.GetPosition()) 
                        && !(bicycle.GetBikeNo() == path.GetBikeNo()))
                        {
                            // _isGameOver = true;
                            cast.RemoveActor("bicycle", bicycle);
                            if (cast.GetActors("bicycle").Count() < 2){
                                _isGameOver = true;
                            }
                        }
                    }
                }
                // Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
                
                // List<Actor> body = bicycle.GetBody();
                // foreach (Actor segment in body)
                // {
                //     if (segment.GetPosition().Equals(bike.GetPosition()))
                //     {
                //         _isGameOver = false;
                //     }
                // }
            }
            

        }

        private void HandleGameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Bicycle bicycle = (Bicycle)cast.GetFirstActor("bicycle");
                // Bicycle bike2 = (Bicycle)cast.GetFirstActor("dragon");
                List<Actor> segments = bicycle.GetSegments();
                // List<Actor> segments2 = bike2.GetSegments();
                // PowerUp power_up = (PowerUp)cast.GetFirstActor("powerUp");


                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);
                string name = "no one";
                foreach (Bicycle bike in cast.GetActors("bicycle")){
                    name = bike._name;
                }
                Actor message = new Actor();
                message.SetText($"{name} is the WINNER!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything black
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.BLACK);
                }
                // power_up.SetColor(Constants.WHITE);
            }
        }

    }
}