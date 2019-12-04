﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class InvisibleTank : Entity
    {
        private Tank _tank;
        public InvisibleTank(float x, float y) : base(x,y)
        {
            _tank = new Tank(0,0);
            AddChild(_tank);
        }

        public override void Update(float deltaTime)
        {           
            //_tank.X = 0;
            _tank.Y = 0;
            RotateRight(deltaTime);
            RotateLeft(deltaTime);
            base.Update(deltaTime);
            X = _tank.XAbsolute;
            Y = _tank.YAbsolute;
        }

        public void RotateRight(float deltaTime)
        {
            if (Input.IsKeyDown(68))
            {
                Rotate(2 * deltaTime);
            }
        }

        public void RotateLeft(float deltaTime)
        {
            if (Input.IsKeyDown(65))
            {
                Rotate(-2 * deltaTime);
            }
        }
    }
}
