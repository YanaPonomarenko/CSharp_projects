namespace homework7
{
    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public interface ICopyable
    {
        void Copy();
    }
    public abstract class OfficeDevice
    {
        public string Name { get; protected set; }
        public bool IsOn { get; protected set; }

        public OfficeDevice(string name)
        {
            Name = name;
            IsOn = false;
        }

        public virtual void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} включений");
        }

        public virtual void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} виключений");
        }
    }
    public class Printer : OfficeDevice, IPrintable
    {
        public Printer(string name) : base(name) { }

        public void Print()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name}: Увімкніть пристрій");
                return;
            }
            Console.WriteLine($"{Name}: Друк документа");
        }
    }

    public class Scanner : OfficeDevice, IScannable
    {
        public Scanner(string name) : base(name) { }

        public void Scan()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name}: Увімкніть пристрій");
                return;
            }
            Console.WriteLine($"{Name}: Сканування документа");
        }
    }

    public class Copier : OfficeDevice, ICopyable
    {
        public Copier(string name) : base(name) { }

        public void Copy()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name}: Увімкніть пристрій");
                return;
            }
            Console.WriteLine($"{Name}: Копіювання документа");
        }
    }

    public class Mfu : OfficeDevice, IPrintable, IScannable, ICopyable
    {
        public Mfu(string name) : base(name) { }

        public void Print()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name}: Увімкніть пристрій");
                return;
            }
            Console.WriteLine($"{Name} (МФУ): Друк документа");
        }

        public void Scan()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name}: Увімкніть пристрій");
                return;
            }
            Console.WriteLine($"{Name}: Увімкніть пристрій");
        }

        public void Copy()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Name}: Увімкніть пристрій");
                return;
            }
            Console.WriteLine($"{Name} (МФУ): Копіювання документа");
        }
    }

    public class Office
    {
        private OfficeDevice[] devices;

        public Office(OfficeDevice[] devices)
        {
            this.devices = devices;
        }

        public void TurnOnAll()
        {
            Console.WriteLine("\n=== Вмикаємо всі пристрої ===");
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }

        public void TurnOffAll()
        {
            Console.WriteLine("\n=== Вимикаємо всі пристрої ===");
            foreach (var device in devices)
            {
                device.TurnOff();
            }
        }

        public void StartPrint()
        {
            Console.WriteLine("\n=== Запуск друку ===");
            foreach (var device in devices)
            {
                if (device is IPrintable printable)
                {
                    printable.Print();
                }
            }
        }

        public void StartScan()
        {
            Console.WriteLine("\n=== Запуск сканування ===");
            foreach (var device in devices)
            {
                if (device is IScannable scannable)
                {
                    scannable.Scan();
                }
            }
        }

        public void StartCopy()
        {
            Console.WriteLine("\n=== Запуск копіювання ===");
            foreach (var device in devices)
            {
                if (device is ICopyable copyable)
                {
                    copyable.Copy();
                }
            }
        }

        public void StartAllOperations()
        {
            StartPrint();
            StartScan();
            StartCopy();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OfficeDevice[] devices =
            {
            new Printer("HP Printer"),
            new Scanner("Canon Scanner"),
            new Copier("Xerox Copier"),
            new Mfu("Epson MFU")
        };

            Office office = new Office(devices);

            office.TurnOnAll();

            office.StartPrint();
            office.StartScan();
            office.StartCopy();

            office.TurnOffAll();
        }
    }
}
