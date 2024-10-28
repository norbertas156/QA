namespace FinancialCalculationSystem.Models
{
    public class Investment
    {
        public string investmentName;
        public double PrincipalAmount;
        public float InterestRate;
        public int DurationInYears;
        public bool isHighRisk;

        public Investment(string name, double principal, float rate, int duration, bool risk)
        {
            investmentName = name;
            PrincipalAmount = principal;
            InterestRate = rate;
            DurationInYears = duration;
            isHighRisk = risk;
        }
    }
}
