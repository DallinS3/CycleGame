# Unit 05, Cycle – Designing Together

1.	Objects in program (central nouns)
    * Bicycles
    * Bike paths/trails (rear of bike)
    * PowerUps (later in development / WIP)

2.	Responsibilities, behaviors, & states of objects
    * Users will control bikes to move in various directions
    * Bikes will move & trailing paths grow as game develops/ensues
    * Bikers will always be moving until they crash into their opponents trail
    * PowerUps give increased velocity for x amount of time 

3.	Relationships between objects. Roleplay gameplay
    * Each trail belongs to one biker
    * Each bike has one name
    * PowerUps give speed boosts when they are collected by the bikes

4.	Translate objects into classes design (class names, method names, parameters, & return types)
    * Bicycle megascooooter5100 = new Bicycle; (names are Zoom, Dragon, Shadow, and Ninja)
    * PowerUp powa = new PowerUp
    * Trails
    * Class names = HandleCollisionsAction, MoveActorsAction, ControlActorsAction, Actors, Bicycles, Cast, Color, PowerUp, Director, KeyboardService, VideoService, Program, Constants, Action, Script, DrawActors, Point, etc.

5.	Documentation
    * Object:
        * Bike
        * PowerUp
        * Trail
    * Class = Action:
        * public interface (which provides polymorphic power to child class that inherit this parent code)
        * Execute() function --> Returns nothing (void); Parameters = Cast cast, Script script
    * Class = Bicycle:
        * PrepareBody() function --> Returns nothing (void)
        * Variable: List<Actor> _segments = new List<Actor>
        * GetBody() function --> Returns all _segments
        * GetBike() function --> Returns an actor
        * GrowTrail() function --> Returns nothing (void)
        * MoveNext() function --> Returns nothing (void)
        * TurnBike() function --> Returns nothing (void)


# Authors
Jacob Holst (pizzatoaster103@github.com)
Dallin Scott (something@actor.getEmail())
