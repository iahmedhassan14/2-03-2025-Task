namespace MainTask
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0)
            : base(name, balance)
        {
            IntRate = intRate;
        }

        public double IntRate { get; set; }

        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            double interest = amount * (IntRate / 100);
            return base.Withdraw(amount + interest);
        }
        public override string ToString()
        {
            return $"[SavingsAccount: {Name}, Balance: {Balance}, Interest Rate: {IntRate}%]";
        }

    }
}
