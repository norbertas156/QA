namespace FinancialCalculationSystem.Services
{
    public class TaxCalculatorService
    {
        public double CalculateTax(double income, double deductions)
        {
            if (income < 0 || deductions < 0) return 0;
            var taxableIncome = income - deductions;

            if (taxableIncome <= 10000)
                return taxableIncome * 0.1;
            else if (taxableIncome <= 20000)
                return 1000 + (taxableIncome - 10000) * 0.15;
            else if (taxableIncome <= 50000)
                return 2500 + (taxableIncome - 20000) * 0.2;
            else
                return 8500 + (taxableIncome - 50000) * 0.25;
        }

        public double ApplyAdditionalTax(double baseTax, bool highIncome, bool isSelfEmployed)
        {
            if (highIncome)
                baseTax += baseTax * 0.05;
            if (isSelfEmployed)
                baseTax += baseTax * 0.1;
            return baseTax;
        }
    }
}