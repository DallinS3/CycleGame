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
            Bicycle zoom = (Bicycle)cast.GetFirstActor("zoom");
            // Score score = (Score)cast.GetFirstActor("score");
            PowerUp power_up = (PowerUp)cast.GetFirstActor("power_up");
            
            // if (zoom.GetBike().GetPosition().Equals(power_up.GetPosition()))
            // {
            //     int points = power_up.GetPoints();
            //     zoom.GrowTrail(points);
            //     // score.AddPoints(points);
            //     power_up.Reset();
            // }
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Bicycle zoom = (Bicycle)cast.GetFirstActor("zoom");
            Bicycle drag = (Bicycle)cast.GetFirstActor("dragon");
            Bicycle slimshad = (Bicycle)cast.GetFirstActor("shadow");
            Bicycle shuriken = (Bicycle)cast.GetFirstActor("ninja");
            Actor bike = zoom.GetBike();
            List<Actor> body = zoom.GetBody();

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(bike.GetPosition()))
                {
                    _isGameOver = true;
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Bicycle bike = (Bicycle)cast.GetFirstActor("bike");
                List<Actor> segments = bike.GetSegments();
                PowerUp food = (PowerUp)cast.GetFirstActor("food");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.WHITE);
                }
                food.SetColor(Constants.WHITE);
            }
        }

    }
}