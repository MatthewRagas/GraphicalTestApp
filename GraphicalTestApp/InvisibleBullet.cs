using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class InvisibleBullet : Entity
    {
        private Bullet _bullet;

        public InvisibleBullet(float x, float y) : base(x,y)
        {
            _bullet = new Bullet(x, y);

            AddChild(_bullet);
        }        

        public override void Update(float deltaTime)
        {
            _bullet.Y = 0;
            base.Update(deltaTime);                       
        }
    }
}
