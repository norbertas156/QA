using FinancialCalculationSystem.Models;
using System;

namespace FinancialCalculationSystem.Services
{
    public class InterestCalculatorService
    {
        public double CalculateSimpleInterest(double principal, float rate, int years)
        {
            return principal * rate * years / 100;
        }

        public double CalcCompIntrst(double principal, float rate, int years)
        {
            return principal * Math.Pow((1 + rate / 100), years) - principal;
        }
    }
}