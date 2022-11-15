using System.Collections.Generic;
using CycleData.Game.Casting;


namespace CycleData.Game.Scripting
{
    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Action class.
    public class MoveActorsActing : Action
    {
        /// <summary>
        /// <para>An update action that moves all the actors.</para>
        /// <para>
        /// The responsibility of MoveActorsAction is to move all the actors.
        /// </para>
        /// </summary>

        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public MoveActorsActing()
        {
            
        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> actors = cast.GetAllActors();
            foreach (Actor actor in actors)
            {
                actor.MoveNext();
            }

            /*
                EXAMPLES GIVEN IN-CLASS
            
            foreach (Actor actor in cast.GetAllActors())
            {
                actor.MoveNext();
            }

            -- OR --

            Snake snake = (Snake)cast.GetFirstActor("snake");
            snake.MoveNext();

            -- OR --

            Actor snake = cast.GetFirstActor("snake");
            snake.MoveNext();
            */
        }
    }
}