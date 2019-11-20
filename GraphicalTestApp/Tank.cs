using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        private Sprite _tank;



        public Tank(float x, float y, string path) : base(x, y)
        {
            _tank = new Sprite(path);
            AddChild(_tank);            

            //OnUpdate += MoveRight();
        }

        public Tank() : this(640, 380, "tank_green.png")
        {

        }        

        public Tank(string path) : this(640, 380, path)
        {
            
           
        }

        public Tank(float x, float y) : this(x, y, "tank_green.png")
        {

        }

        public void RotateRight(float deltaTime)
        {
            if(Input.IsKeyDown(68))
            {
                Rotate(4 * deltaTime);
            }            
        }

        public void RotateLeft(float deltaTime)
        {
            if(Input.IsKeyDown(65))
            {
                Rotate(-4 * deltaTime);
            }
        }

        public void Moveforward()
        {
            if(Input.IsKeyDown(87))
            {
                
            }
            else
            {
                XVelocity = 0;
            }
        }

        public override void Update(float deltaTime)
        {
            RotateRight(deltaTime);
            RotateLeft(deltaTime);
            Moveforward();
            base.Update(deltaTime);
        }
    }
}
