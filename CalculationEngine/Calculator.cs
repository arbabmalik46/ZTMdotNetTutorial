namespace CalculationEngine;

public class Calculator
{
    public decimal Sum(decimal? a, decimal b)
    {
        return (decimal)a + b;
    }

    public decimal Subtract(decimal? a, decimal b)
    {
        return (decimal)a - b;
    }
}