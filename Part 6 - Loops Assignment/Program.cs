namespace Part_6___Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string choice = "";
            Console.SetBufferSize(200, 200);
            Console.SetWindowSize(150, 40);

            while (!done)
            {
                Console.Clear();
                Console.SetCursorPosition(36, 2);
                Console.WriteLine("Welcome to my extremely cool menu screen for my loops programming assignment!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pick what part of the assignment you'd like to see.");
                Console.WriteLine("Option 1: Prompter");
                Console.WriteLine("Option 2: Simple Banking Machine");
                Console.WriteLine("Option 3: Doubles Roller");
                Console.WriteLine("Or, you can press 'Q' to exit the program.");
                Console.WriteLine();
                Console.Write("Pick your option (1 - 3, or 'Q'.): ");
                choice = Console.ReadLine();
                choice = choice.ToUpper().Trim();
                while (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.Write("Invalid Input. Try again: ");
                    choice = Console.ReadLine();
                }
                if (choice == "1")
                {
                    Prompter();
                }
                else if (choice  == "2")
                {
                    BankOfBlorb();
                }
            }
        }

        // Prompter
        public static void Prompter()
        {
            int maxValue, minValue, midNumber;
            Console.Clear();
            Console.WriteLine("I'm going to ask you for three integers: a minimum value, a maximum value, and a number between those values.");
            Console.WriteLine();
            Console.Write("Minimum value: ");
            while (!int.TryParse(Console.ReadLine(), out minValue))
            {
                Console.Write("Invalid Input. Try again: ");
            }
            Console.Write("Maximum value: ");
            while (!int.TryParse(Console.ReadLine(), out maxValue))
            {
                Console.Write("Invalid Input. Try again: ");
            }
            while (maxValue <= minValue)
            {
                Console.Write("Maximum value must be larger than the minimum value. Try again: ");
                while (!int.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.Write("Invalid Input. Try again: ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Thanks! Now enter in an integer between {minValue} and {maxValue}!");
            Console.Write("Enter in the number here: ");
            while (!int.TryParse(Console.ReadLine(), out midNumber))
            {
                Console.Write("Invalid Input. Try again: ");
            }
            while (midNumber < minValue || midNumber > maxValue)
            {
                Console.Write($"Middle integer must be in between {minValue} and {maxValue}. Try again: ");
                while (!int.TryParse(Console.ReadLine(), out midNumber))
                {
                    Console.Write("Invalid Input. Try again: ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks! Press 'ENTER' to return to the main menu");
            Console.ReadLine();
        }

        // Simple Banking Machine
        public static void BankOfBlorb()
        {
            string choice = "";
            bool done = false;
            double balance = 150;
            while (!done)
            {
                int y = 19;
                Console.Clear();
                Console.SetCursorPosition(60, 1);
                Console.WriteLine("Welcome to the Bank of Blorb!");
                Console.WriteLine();
                Console.SetCursorPosition(64, 3);
                Console.WriteLine($"Your balance: {balance.ToString("C")}");
                Console.SetCursorPosition(55, 4);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition(42, 6);
                Console.WriteLine("Here, you are able to make any Blorbian transaction that you wish.");
                Console.SetCursorPosition(38, 7);
                Console.WriteLine("Please note: You are charged a fee of $0.75 for each banking transaction.");
                Console.SetCursorPosition(52, 9);
                Console.WriteLine("Select what transaction you'd like to perform:");
                Console.SetCursorPosition(64, 11);
                Console.WriteLine("Option 1: Deposit");
                Console.SetCursorPosition(64, 12);
                Console.WriteLine("Option 2: Withdrawal");
                Console.SetCursorPosition(64, 13);
                Console.WriteLine("Option 3: Bill Payment");
                Console.SetCursorPosition(64, 14);
                Console.WriteLine("Option 4: Balance Update");
                Console.SetCursorPosition(64, 15);
                Console.WriteLine("Or, enter 'Q' to exit.");
                Console.SetCursorPosition(55, 16);
                Console.WriteLine("---------------------------------------");
                Console.SetCursorPosition(61, 18);
                Console.Write("Enter in your choice here: ");
                choice = Console.ReadLine();
                choice = choice.ToUpper().Trim();
                while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "Q")
                {
                    Console.SetCursorPosition(61, y);
                    Console.Write("Invalid Input. Try again: ");
                    choice = Console.ReadLine();
                    y++;
                }
                if (choice == "1")
                {
                    BlorbDeposit(balance);
                }
            }
        }
        public static void BlorbDeposit(double balance)
        {
            Console.Clear();
            Console.SetCursorPosition(131, 1);
            Console.WriteLine($"Balance: {balance.ToString("C")}");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("How much would you like to deposit today?");
            Console.ReadLine();
        }
    }
}
