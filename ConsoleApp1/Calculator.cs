using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    private readonly ICalculationService _calculationService;

    public Calculator(ICalculationService calculationService)
    {
        _calculationService = calculationService;
    }

    public int Add(int a, int b)
    {
        return _calculationService.Add(a, b);
    }

    public int Subtract(int a, int b)
    {
        return _calculationService.Subtract(a, b);
    }

    public int Multiply(int a, int b)
    {
        return _calculationService.Multiply(a, b);
    }

    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return _calculationService.Divide(a, b);
    }

    public bool IsGreaterThan(int a, int b)
    {
        return _calculationService.IsGreaterThan(a, b);
    }

    public bool IsLessThan(int a, int b)
    {
        return _calculationService.IsLessThan(a, b);
    }

    public bool IsEqual(int a, int b)
    {
        return _calculationService.IsEqual(a, b);
    }
}
