using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;

            //Player
            Entity player = new Entity(640, 380);

            //Sprite
            Sprite sprite = new Sprite("tank_green.png");

            //HitBox
            AABB aABB = new AABB(40, 40);

            root.AddChild(player);
            player.AddChild(sprite);
            player.AddChild(aABB);

            //## Set up game here ##//

            game.Run();
        }
    }
}
