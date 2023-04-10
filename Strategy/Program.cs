using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrecity electrecity = new Electrecity();
            Gas gas = new Gas();
            Petrol petrol = new Petrol();

            Car car1 = new Car(electrecity);
            Car car2 = new Car(gas);
            Car car3 = new Car(petrol);

            car1.Move();
            car2.Move();
            car3.Move();

            Console.ReadKey();
        }
    }
}
