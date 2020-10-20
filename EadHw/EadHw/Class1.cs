using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EadHw
{
    class Instance
    {
        private static int count = 0;
        public Instance()
        {
            count++;
        }
        public int numberOfObject()
        {
            return count;
        }


    }
    class Class1
    {
        static void Main(string[] args)
        {

            Instance I1 = new Instance();
            Instance I2 = new Instance();
            Instance I3 = new Instance();
            Instance I4 = new Instance();
            
            Console.WriteLine(I1.numberOfObject());
            Console.ReadLine();
        }
        }
    }

