using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bratzTeamDemo
{
    class calculatorClass
    {
        private int numOne;
        private int numTwo;

        public  int subtraction(int num1, int num2)
        {
            numOne = num1;
            numTwo = num2;

            return numOne - numTwo;
        }
    }
}
