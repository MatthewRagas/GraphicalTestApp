using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet : Entity
    {
        private Sprite _bullet;
        private AABB _bulletBox;
        public Bullet(float x, float y) : base(x,y)
        {
            _bullet = new Sprite("");
            _bulletBox = new AABB(5, 10);

            AddChild(_bulletBox);
        }
    }
}
