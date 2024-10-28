using FinancialCalculationSystem.Models;
using System;

namespace FinancialCalculationSystem.Services
{
    public class ForecastingService
    {
        private InterestCalculatorService intCalc;
        private TaxCalculatorService taxCalc;

        public ForecastingService()
        {
            intCalc = new InterestCalculatorService();
            taxCalc = new TaxCalculatorService();
        }

        public double PredictFutureValue(Investment invest, int years)
        {
            double finalAmount = invest.PrincipalAmount;
            for (int i = 0; i < years; i++)
            {
                double interest = intCalc.CalcCompIntrst(finalAmount, invest.InterestRate, 1);
                double tax = taxCalc.CalculateTax(interest, 0);

                if (invest.isHighRisk)
                {
                    tax = taxCalc.ApplyAdditionalTax(tax, highIncome: true, isSelfEmployed: false);
                }

                finalAmount += (interest - tax);
            }
            return finalAmount;
        }
    }
}