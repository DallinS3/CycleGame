using System.Collections.Generic;
using CycleData.Game.Casting;
using CycleData.Game.Services;


namespace CycleData.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            _videoService.ClearBuffer();

            foreach (Bicycle bike in cast.GetActors("bicycle"))
            {
                List<Actor> segments = bike.GetSegments();

                _videoService.DrawActors(segments);
            }

            // Bicycle zoomer = (Bicycle)cast.GetFirstActor("zoom");
            // Bicycle pendragon = (Bicycle)cast.GetFirstActor("dragon");
            // Bicycle shadii = (Bicycle)cast.GetFirstActor("shadow");
            // Bicycle ninjago = (Bicycle)cast.GetFirstActor("ninja");
            // List<Actor> segments = zoomer.GetSegments();
            // List<Actor> segments2 = pendragon.GetSegments();
            // List<Actor> segments3 = shadii.GetSegments();
            // List<Actor> segments4 = ninjago.GetSegments();
            // Actor score = cast.GetFirstActor("score");
            // Actor power_up = cast.GetFirstActor("powerUp");
            List<Actor> messages = cast.GetActors("messages");
            
            
            // _videoService.DrawActors(segments2);
            // _videoService.DrawActors(segments3);
            // _videoService.DrawActors(segments4);
            // _videoService.DrawActor(score);
            // _videoService.DrawActor(power_up);
            _videoService.DrawActors(messages);
            _videoService.FlushBuffer();
        }
    }
}