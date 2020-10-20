using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADhomeWork
{
    class Task1
    {
        static void Main(string[] args)
        {

            int temp = 0;
            //   try
            //{
            Console.WriteLine("\n\n Enter The Tempearture (C) :");
            temp = Convert.ToInt32(Console.ReadLine());
            //}
            // catch (Exception ex)
            // {
            //     Console.Write(ex);
            // }


            if (temp < 0)
                temp = -1;
            else if (temp < 10)
                temp = 0;
            else if (temp < 20)
                temp = 10;
            else if (temp < 30)
                temp = 20;
            else if (temp < 40)
                temp = 30;
            else
                temp = 40;



            switch (temp)
            {
                case -1:
                    Console.WriteLine("Freezing weather");
                    break;
                case 0:
                    Console.WriteLine("Very Cold weather");
                    break;
                case 10:
                    Console.WriteLine("Cold weather");
                    break;
                case 20:
                    Console.WriteLine("Normal in Temp");
                    break;
                case 30:
                    Console.WriteLine("Its Hot");
                    break;
                case 40:
                    Console.WriteLine("Its Very Hot");
                    break;
            }


        }
    }
}