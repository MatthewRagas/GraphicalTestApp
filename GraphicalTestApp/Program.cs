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
            //Actor root1 = new Actor();
            game.Root = root;
            //game.Root = root1;

            //Players
            Tank player = new Tank(720, 300);
            Tank player1 = new Tank("PNG/Default size/tank_huge.png");

                      
            //HitBoxes
            
            AABB tankBox1 = new AABB(40, 40);

            root.AddChild(player1);
            root.AddChild(player);                                               

            //## Set up game here ##//

            game.Run();
        }
    }
}
