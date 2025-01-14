﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class TankTurret : Actor
    {
        private Sprite _turret;                

        public TankTurret(float x, float y)
        {
            _turret = new Sprite("tankGreen_barrel2_outline.png");
            

            X = 0;
            Y = 0;
            _turret.X = -5.5f;
            _turret.Y = 0;

            
            AddChild(_turret);
        }        

        public void RotateRight(float deltaTime)
        {
            if (Input.IsKeyDown(81))
            {
                Rotate(2 * deltaTime);
            }
        }

        public void RotateLeft(float deltaTime)
        {
            if (Input.IsKeyDown(69))
            {
                Rotate(-2 * deltaTime);
            }
        }       

        public override void Update(float deltaTime)
        {            
            RotateRight(deltaTime);
            RotateLeft(deltaTime);
            base.Update(deltaTime);
        }
    }
}
