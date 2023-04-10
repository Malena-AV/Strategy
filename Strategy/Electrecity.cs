using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Electrecity : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Еду на электричестве");
        }
    }
}
