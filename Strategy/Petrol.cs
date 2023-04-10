using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Petrol : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Еду на бензине");
        }
    }
}
