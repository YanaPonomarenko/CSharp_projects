namespace project3
{

    abstract class Card
    {
        public string BankName { get; private set; }
        public double Balance { get; protected set; }
        public double Commission { get; private set; }
        public double LastWithdrawAmount { get; protected set; }

        public Card(string bankName, double commission, double initialBalance)
        {
            BankName = bankName;
            Commission = commission;
            Balance = initialBalance;
        }

        public abstract void Withdraw(double amount);
    }

    class MonoBankCard : Card 
    {
        public MonoBankCard(double initialBal)
        : base("MonoBank", 1.5, initialBal) { }

        public override void Withdraw(double amount)
        {
            double total = amount + (amount * Commission / 100);
            if (Balance >= total)
            {
                Balance -= total;
                Console.WriteLine($"{BankName}: Списано {amount}, залишок {Balance}");
            }
            else
            {
                Console.WriteLine($"{BankName}: Недостатньо коштів");
            }
        }
    }

    class PrivateBankCard : Card
    {
        public PrivateBankCard(double initialBal)
            : base("PrivateBank", 4.0, initialBal) { }

        public override void Withdraw(double amount)
        {
            double total = amount + Commission;
            if (Balance >= total)
            {
                Balance -= total;
                Console.WriteLine($"{BankName}: Списано {amount}, залишок {Balance}");
            }
            else
            {
                Console.WriteLine($"{BankName}: Недостатньо коштів");
            }
        }
    }

    class ABankCard : Card
    {
        public ABankCard(double initialBal)
            : base("ABank", 2.0, initialBal) { }

        public override void Withdraw(double amount)
        {
            if (amount < 10)
            {
                Console.WriteLine($"{BankName}: Мінімум 10");
                return;
            }

            double commission = 0;
            if (amount > 100)
            {
                commission = amount * Commission / 100;
            }

            double total = amount + commission;

            if (Balance >= total)
            {
                Balance -= total;
                Console.WriteLine($"{BankName}: Списано {amount}, залишок {Balance}");
            }
            else
            {
                Console.WriteLine($"{BankName}: Недостатньо коштів");
            }
        }
    }

    class ATM
    {
        public void ProcessWithdrawal(Card card, double amount)
        {
            Console.WriteLine($"\nБанкомат: {card.BankName}, баланс: {card.Balance}");
            card.Withdraw(amount);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Card mono = new MonoBankCard(300);
            Card privat = new PrivateBankCard(500);
            Card abank = new ABankCard(200);

            atm.ProcessWithdrawal(mono, 100);
            atm.ProcessWithdrawal(privat, 50);
            atm.ProcessWithdrawal(abank, 99);
            atm.ProcessWithdrawal(abank, 5);
            atm.ProcessWithdrawal(mono, 400);
        }
    }
}
