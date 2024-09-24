using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalculationService
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
        bool IsGreaterThan(int a, int b);
        bool IsLessThan(int a, int b);
        bool IsEqual(int a, int b);
    }
}
