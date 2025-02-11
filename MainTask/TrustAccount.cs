namespace MainTask
{
    public class TrustAccount : Account
    {
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0)
        : base(name, balance)
        {
            Name = name;
            Balance = balance;
            IntRate = intRate;
        }

        public double IntRate { get; set; }
        private int withdraw = 0;
        private const int WithdrawTimes = 3;
        private const double WithdrawPercentage = 0.2;


        public override bool Deposit(double amount)
        {
            if (amount > 5000)
            {
                return base.Deposit(amount + 50.00);
            }
            return base.Deposit(amount);

        }
        public override bool Withdraw(double amount)
        {
            if (withdraw >= WithdrawTimes)
            {
                Console.WriteLine($"Withdrawal failed: Exceeded {WithdrawTimes} withdrawals for {Name}.");
                return false;
            }

            if (amount > Balance * WithdrawPercentage)
            {
                Console.WriteLine($"Withdrawal failed: Cannot withdraw more than 20% of balance in one transaction.");
                return false;
            }

            withdraw++;
            double interest = amount * (IntRate / 100);
            return base.Withdraw(amount + interest);
        }
        public override string ToString()
        {
            return $"[SavingsAccount: {Name}, Balance: {Balance}, Interest Rate: {IntRate}%]";
        }
    }
}
