using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class TankBox : Tank
    {
        private AABB _tankBox;

        public TankBox(string path) : base(path)
        {
            if (path == "PNG/Default size?tank_huge.png")
            {
                _tankBox = new AABB(80, 80);
            }
            else
            {
                _tankBox = new AABB(40, 40);
            }
            AddChild(_tankBox);
        }
    }
}
