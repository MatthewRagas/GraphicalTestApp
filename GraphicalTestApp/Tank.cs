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
        private AABB _tankBox;
        private TankTurret _turret;


        public Tank(float x, float y, string path) : base(x, y)
        {
            _tank = new Sprite(path);
            _tankBox = new AABB(40, 40);
            _turret = new TankTurret(0,0);
            
            AddChild(_tank);
            AddChild(_tankBox);
            AddChild(_turret);
        }

        public Tank() : this(640, 380, "tankBody_green.png")
        {

        }        

        public Tank(string path) : this(640, 380, path)
        {
                       
        }

        public Tank(float x, float y) : this(x, y, "tankBody_green.png")
        {

        }

        public AABB GetAABB
        {            
            get
            {
                return _tankBox;
            }
        }


        public void Moveforward()
        {   
            
            if(Input.IsKeyDown(87))
            {                
                YVelocity = 150;
            }
            else if(Input.IsKeyDown(83))
            {
                YVelocity = -80;
            }
            else
            {
                YVelocity = 0;
            }
        }        

        public override void Update(float deltaTime)
        {                       
            _tankBox.DetectCollision(Program.box);                                                                           
            Moveforward();            
            base.Update(deltaTime);
        }
    }
}