using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class WholeNumbersForAdd
    {
        int input;
        int initial = 0;
        public void start()
        {
            writeProgramInfo();
            ReadInput();
            SumNumbers();
            ShowResults();
        }

        private void writeProgramInfo()
        {
            Console.WriteLine("***********summation of real numbers******** ");
            Console.CursorLeft = Console.BufferWidth - 65;
            Console.WriteLine("using a for-statement ");
            Console.WriteLine();
            
        }

        private void ReadInput()
        {


            Console.Write("Number of values to sum?");
            
             input = Input.ReadIntegerConsole();
        }

        private void SumNumbers()
        {
           

            for (int index = 1; index <= input; index++)
            {


                Console.Write("please give the value no " + index + "<whole number>:");

                int inputt = Input.ReadIntegerConsole();

                initial = initial + inputt;

            }
        }
        public void ShowResults()

        {


            Console.WriteLine("-----------------------------");
            Console.Write("THE SUM IS " + initial);
            Console.WriteLine();
            Console.WriteLine();

           
           
           
        }




    }
}


        

    



            


