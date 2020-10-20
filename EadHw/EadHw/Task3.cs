//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EadHw
//{
//    class Task3
//    {


//        static void Main(string[] args)
//        {
//            double value = 0;
//            int dec = 0;
//            int choice = 0;
//            try
//            {
//                Console.Write("\n\n Enter Floating Number : ");
//                value = Convert.ToDouble(Console.ReadLine());

//                Console.Write("\n\n Round Off Number : ");
//                dec = Convert.ToInt32(Console.ReadLine());

//                Console.Write("\n\n Enter Option For Rounding: \n 1. Old Method ");
//                Console.Write("\n 2. Banker Method \n");
//                choice = Convert.ToInt32(Console.ReadLine());
//            }
//            catch (Exception ex)
//            {
//                Console.Write(ex.Message);
//            }


//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Rounding By Old Method :" + Math.Round(value, dec, MidpointRounding.AwayFromZero));
//                    break;
//                case 2:
//                    Console.WriteLine("Rounding By Old Method :" + Math.Round(value, dec));
//                    break;
//                default:
//                    Console.WriteLine("Invalid Option");
//                    break;
//            }
//            Console.ReadLine();

//        }
//    }
//}
