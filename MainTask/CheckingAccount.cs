namespace MainTask
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0, double fee = 1.50)
        : base(name, balance)
        {
            Fee = fee;
        }

        public double Fee { get; set; }

        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
        public override string ToString()
        {
            return $"[CheckingAccount: {Name}, Balance: {Balance}, Fee: {Fee}]";
        }
    }
}
