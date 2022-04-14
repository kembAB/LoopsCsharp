using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Input
    {
       

        public static decimal ReadCurrencyConsole()
        {
            decimal cuinput;


            if (decimal.TryParse(Console.ReadLine(),
                NumberStyles.Currency,
                
                NumberFormatInfo.InvariantInfo,
                out cuinput))
            {
                return cuinput;

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input.please try again  ");
            Console.ResetColor();
            return ReadDecimalConsole();
        }
       
        public static string ReadStringConsole()
        {
           
                string sinput = Console.ReadLine();
                foreach (char c in sinput)
                {
                    if (char.IsLetter(c))
                    
                        return sinput;
                }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input.please try again  ");
            Console.ResetColor();
            return ReadStringConsole();
        }
        public static decimal  ReadDecimalConsole()
        {
            decimal deinput;

           
            if (decimal.TryParse(Console.ReadLine(),
                NumberStyles.AllowDecimalPoint,
               
                NumberFormatInfo.InvariantInfo,
                out deinput))
            {
                return deinput;

            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input.please try again  ");
            Console.ResetColor();
            return ReadDecimalConsole();
        }
        public static int ReadIntegerConsole()
        {
            int input;


            { if (int.TryParse(Console.ReadLine(), out input))
            return input;}

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input.please try again  ");
            Console.ResetColor();
            return ReadIntegerConsole();
        }


        public static double ReadDoubleConsole()
        {
            double dinput;
            

            if (double.TryParse(Console.ReadLine(),
                NumberStyles.Number,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out dinput))
            {
                return dinput;
                
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input.please try again  ");
            Console.ResetColor();
            return ReadDoubleConsole();
            
            
                
        }
    }
}






   