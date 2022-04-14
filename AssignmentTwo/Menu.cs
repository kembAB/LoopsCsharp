using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
     class Menu
    {
        public void Start()
        {

            int choice=-1;


            while (choice != 0  ) 
            {
                WriteMenuText();
                choice = Input.ReadIntegerConsole();
                
                    switch (choice)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                            sumObj.start();
                            break;
                        case 2:
                            FloatingNumbersWhileAdd floatObj = new FloatingNumbersWhileAdd();
                            floatObj.start();
                            break;

                        case 3:
                            CurrencyConverter currencyObj = new CurrencyConverter();
                            currencyObj.start();
                            break;

                        case 4:
                            WorkingSchedule wSchedule = new WorkingSchedule();
                            wSchedule.start();
                            break;
                    

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("enter the right option according to the above menu");
                        Console.ResetColor();
                        break;

                }


            }


            
        }


        private void WriteMenuText()
        {
            Console.WriteLine("----------------------------------------------");
            Console.CursorLeft = Console.BufferWidth - 65;
            Console.WriteLine(" MAIN MENU ");
            Console.WriteLine("-----------------------------------------------");
            Console.CursorLeft = Console.BufferWidth - 76;
            Console.WriteLine("whole numbers with For:1");
            Console.CursorLeft = Console.BufferWidth - 76;
            Console.WriteLine("Floating Point Numbers with While:2");
            Console.CursorLeft = Console.BufferWidth - 76;
            Console.WriteLine("Currency Converter with Do While loop:3");
            Console.CursorLeft = Console.BufferWidth - 76;
            Console.WriteLine("Work Schedule:4");
            Console.CursorLeft = Console.BufferWidth - 76;
            Console.WriteLine("Exit the Program:0");
            Console.WriteLine("------------------------------------------------");
            Console.Write(" Your Choice:");



        }

    }
   
}
