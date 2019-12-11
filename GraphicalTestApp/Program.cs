using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static AABB box = new AABB(40, 40);
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            //Actor root1 = new Actor();
            game.Root = root;
            //game.Root = root1;

            //Players
            InvisibleTank player = new InvisibleTank(640, 380);
            
            box.X = 640;
            box.Y = 380;
            //InvisibleTank player2 = new InvisibleTank(600, 380);
            //root.AddChild(player1);
            root.AddChild(player);
            root.AddChild(box);
            

            //## Set up game here ##//

            game.Run();
        }
    }
}
