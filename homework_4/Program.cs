namespace homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nCalculator");
                Console.WriteLine("1 - decimal to binary");//десяткова у двійкове 
                Console.WriteLine("2 - binary to decimal");//двійковк у десяткове
                Console.WriteLine("3 - hexadecimal to decimal");// шістнадцяткове у десяткове
                Console.WriteLine("0 - exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            DecimalToBinary();
                            break;

                        case "2":
                            BinaryToDecimal();
                            break;

                        case "3":
                            HexToDecimal();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Wrong choice.");
                            break;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error number too big");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error wrong format");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void DecimalToBinary()
        {
            Console.Write("Enter decimal: ");
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"Binary: {binary}");
        }

        static void BinaryToDecimal()
        {
            Console.Write("Enter binary: ");
            string binary = Console.ReadLine();

            foreach (char c in binary)
                if (c != '0' && c != '1')
                    throw new FormatException();

            int result = Convert.ToInt32(binary, 2);
            Console.WriteLine($"Decimal: {result}");
        }

        static void HexToDecimal()
        {
            Console.Write("Enter hex: ");
            string hex = Console.ReadLine().ToUpper();

            foreach (char c in hex)
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                    throw new FormatException();

            int result = Convert.ToInt32(hex, 16);
            Console.WriteLine($"Decimal: {result}");
        }
    }
}

