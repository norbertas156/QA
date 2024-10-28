using FinancialCalculationSystem.Models;
using FinancialCalculationSystem.Services;

namespace FinancialCalculationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var investment = new Investment("Tech Fund", 10000, 5.5f, 10, true);
            var forecastingService = new ForecastingService();

            var predictedValue = forecastingService.PredictFutureValue(investment, investment.DurationInYears);
            Console.WriteLine($"Predicted value after {investment.DurationInYears} years: {predictedValue}");
        }
    }
}
