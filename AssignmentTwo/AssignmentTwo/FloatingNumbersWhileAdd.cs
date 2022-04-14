using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{


    class FloatingNumbersWhileAdd
    {
        double _input = -1.0;
        double _initial = 0.0;

        public void start()
        {
            writeProgramInfo();
            ReadInput();
            
            ShowResults();
        }

        private void writeProgramInfo()
        {
            Console.WriteLine("***********summation of real numbers******** ");
            Console.CursorLeft = Console.BufferWidth - 65;
            Console.WriteLine("using a while-statement ");
            Console.WriteLine();
            Console.WriteLine("write 0 to finish! ");
            Console.WriteLine("sure to use correct decimal character  ");

        }

        private void ReadInput()
        {
            while (_input != 0.0)
            {

                Console.Write("write an amount to sum or zero to finish:");
                 _input = Input.ReadDoubleConsole();
                SumNumbers();
                if (_input.Equals(0))
                    break;
            }
                
                            
        }
                   
               
        private void SumNumbers()
        {

           
                _initial = _initial + _input; 
                    
            
        }

        private void ShowResults()
        {
            Console.WriteLine("-----------------------------");
            Console.Write("THE SUM IS " + _initial);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
        
