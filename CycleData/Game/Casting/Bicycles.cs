using System;
using System.Collections.Generic;
using System.Linq;

namespace CycleData.Game.Casting
{
    /// <summary>
    /// <para>A long limbless reptile.</para>
    /// <para>The responsibility of Bicycle is to move itself.</para>
    /// </summary>
    public class Bicycle : Actor
    {
        private List<Actor> _segments = new List<Actor>();

        /// <summary>
        /// Constructs a new instance of a Bicycle.
        /// </summary>
        public Bicycle()
        {
            PrepareBody();
        }

        /// <summary>
        /// Gets the bike's trail.
        /// </summary>
        /// <returns>The trail in a List.</returns>
        public List<Actor> GetBody()
        {
            return new List<Actor>(_segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the bike's main segment.
        /// </summary>
        /// <returns>The head segment as an instance of Actor.</returns>
        public Actor GetBike()
        {
            return _segments[0];
        }

        /// <summary>
        /// Gets the bike's segments (including the head).
        /// </summary>
        /// <returns>A list of snake segments as instances of Actors.</returns>
        public List<Actor> GetSegments()
        {
            return _segments;
        }

        /// <summary>
        /// Grows the bike's trail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public void GrowTrail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor trail = _segments.Last<Actor>();
                Point velocity = trail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = trail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(Constants.GREEN);
                _segments.Add(segment);
            }
        }

        /// <inheritdoc/>
        public override void MoveNext()
        {
            foreach (Actor segment in _segments)
            {
                segment.MoveNext();
            }

            for (int i = _segments.Count - 1; i > 0; i--)
            {
                Actor trailing = _segments[i];
                Actor previous = _segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }
        }

        /// <summary>
        /// Turns the bike in the given direction.
        /// </summary>
        /// <param name="velocity">The given direction.</param>
        public void TurnBike(Point direction)
        {
            _segments[0].SetVelocity(direction);
        }

        /// <summary>
        /// Prepares the snake body for moving.
        /// </summary>
        private void PrepareBody()
        {
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = new Point(x - i * Constants.CELL_SIZE, y);
                Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
                string text = i == 0 ? "8" : "#";
                Color color = i == 0 ? Constants.YELLOW : Constants.GREEN;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                _segments.Add(segment);
            }
        }
    }
}