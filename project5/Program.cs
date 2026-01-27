namespace project5
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime ExpirationDate { get; set; }
        private int pin;
        public double CreditLimit { get; set; }
        public double Balance { get; private set; }

        public event Action<double, double> AccountReplenished;
        public event Action<double, double> MoneySpent;
        public event Action<double> CreditStarted;
        public event Action<double> TargetAmountReached;
        public event Action<int> PinChanged;

        public CreditCard(string cardNumber, string ownerName, DateTime expirationDate, int pin, double creditLimit, double balance)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            ExpirationDate = expirationDate;
            this.pin = pin;
            CreditLimit = creditLimit;
            Balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Власник: " + OwnerName);
            Console.WriteLine("Номер картки: " + CardNumber);
            Console.WriteLine("Термін дії: " + ExpirationDate.ToString("MM/yyyy"));
            Console.WriteLine("Кредитний ліміт: " + CreditLimit);
            Console.WriteLine("Баланс: " + Balance);
            Console.WriteLine();
        }

        public void AddMoney(double amount)
        {
            Balance += amount;
            AccountReplenished?.Invoke(amount, Balance);
        }

        public void SpendMoney(double amount)
        {
            double oldBalance = Balance;
            Balance -= amount;

            MoneySpent?.Invoke(amount, Balance);

            if (oldBalance >= 0 && Balance < 0)
                CreditStarted?.Invoke(Balance);
        }

        public void ChangePin(int newPin)
        {
            pin = newPin;
            PinChanged?.Invoke(newPin);
        }

        public void CheckTargetAmount(double target)
        {
            if (Balance >= target)
                TargetAmountReached?.Invoke(Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard(
            "1234 5678 9010 1112",
            "Іван Іванов",
            new DateTime(2030, 01, 10),
            7429,
            6422,
            5732
        );

            card.AccountReplenished += OnAccountReplenished;
            card.MoneySpent += OnMoneySpent;
            card.CreditStarted += OnCreditStarted;
            card.TargetAmountReached += OnTargetReached;
            card.PinChanged += OnPinChanged;

            card.ShowInfo();

            card.AddMoney(500);
            card.SpendMoney(1200);
            card.SpendMoney(500);
            card.CheckTargetAmount(1000);
            card.ChangePin(1234);
        }

        static void OnAccountReplenished(double amount, double balance)
        {
            Console.WriteLine("Рахунок поповнено: +" + amount + ", Баланс: " + balance);
        }

        static void OnMoneySpent(double amount, double balance)
        {
            Console.WriteLine("Витрачено: -" + amount + ", Баланс: " + balance);
        }

        static void OnCreditStarted(double balance)
        {
            Console.WriteLine("Початок використання кредитних коштів! Баланс: " + balance);
        }

        static void OnTargetReached(double balance)
        {
            Console.WriteLine("Досягнуто цільової суми. Баланс: " + balance);
        }

        static void OnPinChanged(int newPin)
        {
            Console.WriteLine("PIN змінено на: " + newPin);
        }
    }
}
