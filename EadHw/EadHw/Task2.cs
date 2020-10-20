//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EadHw
//{
//    class Task2
//    {


//        static void Main(string[] args)
//        {
//            int opran1 = 0, opran2 = 0;
//            char opera = '0';
//            try
//            {
//                Console.Write("\n\n Enter Operator : ");
//                opera = Convert.ToChar(Console.ReadLine());

//                Console.Write("\n\n Enter First Operands : ");
//                opran1 = Convert.ToInt32(Console.ReadLine());

//                Console.Write("\n\n Enter First Operands : ");
//                opran2 = Convert.ToInt32(Console.ReadLine());
//            }
//            catch (Exception ex)
//            {
//                Console.Write(ex.Message);
//            }


//            switch (opera)
//            {
//                case '-':
//                    Console.WriteLine(opran1 + "-" + opran2 + "= " + (opran1 - opran2));
//                    break;
//                case '+':
//                    Console.WriteLine(opran1 + "+" + opran2 + "= " + (opran1 + opran2));
//                    break;
//                case '*':
//                    Console.WriteLine(opran1 + "*" + opran2 + "= " + (opran1 * opran2));
//                    break;
//                case '/':
//                    if (opran2 == 0)
//                        Console.WriteLine(opran1 + "/" + opran2 + " = Infinity");
//                    else
//                        Console.WriteLine(opran1 + "/" + opran2 + "= " + (opran1 / opran2));
//                    break;
//                default:
//                    Console.WriteLine("Invalid Operands");
//                    break;
//            }
//            Console.ReadLine();

//        }
//    }
//}

