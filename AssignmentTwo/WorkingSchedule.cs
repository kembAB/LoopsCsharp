using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
/* a while loop is used for the menu  */
/* since the number of weeks is known (52 weeks) we can use 52 as the upper limit and use for loop to display the schedules*/
namespace AssignmentTwo
{
    class WorkingSchedule
    {
        int columnwidth = 20;
        int columnumber = 3;
        int currrentcolumn = 0;

        public void start()
        {
            int choice = -1;


            while (choice != 0)
            {
                ScheduleMenu();
                choice = Input.ReadIntegerConsole();

                switch (choice)
                {
                    case 1:

                        DisplayWeekendschedule();
                        break;
                    case 2:
                        DisplayNightShedule();
                        break;
                    case 0:

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("enter the right option according to the above menu");
                        Console.ResetColor();
                        break;
                }


            }
        }

        private void ScheduleMenu()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.CursorLeft = Console.BufferWidth - 65;
            Console.WriteLine(" YOUR SCHEDULE PROGRAM ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            Console.CursorLeft = Console.BufferWidth - 79;
            Console.WriteLine("select from the menu which type of schedule you would like to see.");
            Console.CursorLeft = Console.BufferWidth - 78;
            Console.WriteLine("1 Show list of the weekends to work");
            Console.CursorLeft = Console.BufferWidth - 78;
            Console.WriteLine("2 Show a list of the night to work");
            Console.CursorLeft = Console.BufferWidth - 78;
            Console.WriteLine("0 Return to Main Menu");
            Console.WriteLine("------------------------------------------------");
            Console.Write(" Your Choice:");


        }

        private void DisplayWeekendschedule()
        {
            Console.WriteLine("Your schedule of the above option is as follows::");
            Console.WriteLine();
            //Console.Write(PadRight(columnwidth - str.Length, ' '));
            GotoNewLine();
            string s ;
            
            

            for (int i = 1; i <= 52;i=i+3)
            {
              
                s = "week " + i.ToString();
                Console.Write(s.PadLeft(20));
                currrentcolumn++;
                if(currrentcolumn>= columnumber)
                GotoNewLine();
                //i = i + 3;
            }
            Console.WriteLine();
            Console.WriteLine();
          
        }

        private void DisplayNightShedule()
        {
            Console.WriteLine("Your schedule of the above option is as follows::");
            Console.WriteLine();
            //Console.Write(PadRight(columnwidth - str.Length, ' '));
            GotoNewLine();
            string s="";
            

            for (int i = 6; i <= 52; i = i + 5)
            {
             

                s = "week " + i.ToString();
                Console.Write(s.PadLeft(10));
                
                currrentcolumn++;
                if (currrentcolumn >= columnumber)
                    GotoNewLine();
                //i = i + 3;
            }
            Console.WriteLine();
            Console.WriteLine();
            
        }



        private void GotoNewLine()
        {
            if (currrentcolumn >= columnumber)
            {
                
                Console.Write("\n");
                currrentcolumn = 0;
            }
        }


    }
}


