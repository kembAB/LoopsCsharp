using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class CurrencyConverter
    {
        decimal _input = 0;
        decimal _initial = 0;
         decimal rate;
         decimal value;
         string currencyn;

        public void start()
        {
            writeProgramInfo();
            ReadInput();
            calculate();
            ShowResults();
        }

        private void writeProgramInfo()
        {
            Console.WriteLine("***********The Currency Converter******** ");
            Console.WriteLine();
            Console.WriteLine("write 0 to finish! ");
            Console.WriteLine("sure to use correct decimal character  ");

        }

        private void ReadInput()
        {
         
           
            do
            {
                Console.Write("write an amount to sum or zero to finish:");
                _input = Input.ReadDecimalConsole();
                SumNumbers();
                if (_input.Equals(0))

                    break;

            } while (_input != 0);
            Console.Write("Name of the foreign currency:");
             currencyn = Console.ReadLine();
            Console.Write("Exchange rate:");
            
          rate=Input.ReadCurrencyConsole();
            


        }

        
        private void SumNumbers()
        {


            _initial = _initial + _input;


        }

        private void calculate()
        {
           value =_initial / rate ;
            
        }

        private void ShowResults()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine( "{0:c} can be exhanged to  {1:f2} {2} with a rate {3:c}/{2}",_initial , value , currencyn, rate);
     
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}

