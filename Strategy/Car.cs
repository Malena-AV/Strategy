using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Car
    {
        // паттерн который позволяет использовать разную реализацию в одном поведении
        private IMovement movement;
        public Car(IMovement movement)
        {
            this.movement = movement; 
        }

        public void Move()
        {
            movement.Move();
        }
    }
}
