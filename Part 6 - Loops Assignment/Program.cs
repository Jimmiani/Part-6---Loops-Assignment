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
                Console.SetCursorPosition(53, 2);
                Console.WriteLine("Welcome to my loops programming assignment!");
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
                else if (choice == "3")
                {
                    DoublesRoller();
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
            double balance = 150, cash = 10000;
            List <string> balanceUpdate = new List<string>();
            while (!done)
            {
                int y = 20;
                string balanceText = $"Your balance: {balance.ToString("C")}";
                string cashText = $"Your cash: {cash.ToString("C")}";
                Console.Clear();
                Console.SetCursorPosition(60, 1);
                Console.WriteLine("Welcome to the Bank of Blorb!");
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                Console.WriteLine(balanceText);
                Console.SetCursorPosition((Console.WindowWidth - cashText.Length) / 2, 4);
                Console.WriteLine(cashText);
                Console.SetCursorPosition(55, 5);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition(42, 7);
                Console.WriteLine("Here, you are able to make any Blorbian transaction that you wish.");
                Console.SetCursorPosition(38, 8);
                Console.WriteLine("Please note: You are charged a fee of $0.75 for each banking transaction.");
                Console.SetCursorPosition(52, 10);
                Console.WriteLine("Select what transaction you'd like to perform:");
                Console.SetCursorPosition(64, 12);
                Console.WriteLine("Option 1: Deposit");
                Console.SetCursorPosition(64, 13);
                Console.WriteLine("Option 2: Withdrawal");
                Console.SetCursorPosition(64, 14);
                Console.WriteLine("Option 3: Bill Payment");
                Console.SetCursorPosition(64, 15);
                Console.WriteLine("Option 4: Balance Update");
                Console.SetCursorPosition(64, 16);
                Console.WriteLine("Or, enter 'Q' to exit.");
                Console.SetCursorPosition(55, 18);
                Console.WriteLine("---------------------------------------");
                Console.SetCursorPosition(61, 19);
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
                    double deposit;
                    y = 7;
                    Console.Clear();
                    Console.SetCursorPosition(54, 1);
                    Console.WriteLine("How much would you like to deposit today?");
                    Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                    Console.WriteLine(balanceText);
                    Console.SetCursorPosition((Console.WindowWidth - cashText.Length) / 2, 4);
                    Console.WriteLine(cashText);
                    Console.SetCursorPosition(64, 6);
                    Console.Write("Deposit Amount: $");
                    while (!double.TryParse(Console.ReadLine(), out deposit))
                    {
                        Console.SetCursorPosition(62, y);
                        Console.Write("Invalid Input. Try again: $");
                        y++;
                    }
                    while (deposit < 0.75 || deposit > cash)
                    {
                        Console.SetCursorPosition(33, y);
                        Console.Write("Deposited amount must be larger than $0.75 and less than cash on-hand. Try again: $");
                        y++;
                        while (!double.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.SetCursorPosition(62, y);
                            Console.Write("Invalid Input. Try again: $");
                            y++;
                        }
                    }
                    balance += deposit - 0.75;
                    cash -= deposit;
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    cashText = $"Your cash: {cash.ToString("C")}";
                    balanceUpdate.Add($"DEPOSIT AT {DateTime.Now.ToString("HH:mm:ss")}: +{deposit.ToString("C")}. Balance: {(balance - deposit + 0.75).ToString("C")} --> {balance.ToString("C")}");

                    y++;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                    Console.WriteLine(balanceText);
                    Console.SetCursorPosition((Console.WindowWidth - cashText.Length) / 2, 4);
                    Console.WriteLine(cashText);
                    Console.SetCursorPosition(47, y);
                    Console.WriteLine("Money deposited. Your account balance has been updated.");
                    Console.SetCursorPosition(15, y + 1);
                    Console.WriteLine("Reminder: a fee of $0.75 is charged for each banking transaction. Your balance may be lower than expected due to that.");
                    Console.SetCursorPosition(54, y + 3);
                    Console.WriteLine("Press 'ENTER' to return to the bank menu.");
                    Console.SetCursorPosition(95, y + 3);
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    double withdrawal;
                    y = 7;
                    Console.Clear();
                    Console.SetCursorPosition(54, 1);
                    Console.WriteLine("How much would you like to withdraw today?");
                    Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                    Console.WriteLine(balanceText);
                    Console.SetCursorPosition((Console.WindowWidth - cashText.Length) / 2, 4);
                    Console.WriteLine(cashText);
                    Console.SetCursorPosition(63, 6);
                    Console.Write("Withdrawal Amount: $");
                    while (!double.TryParse(Console.ReadLine(), out withdrawal))
                    {
                        Console.SetCursorPosition(62, y);
                        Console.Write("Invalid Input. Try again: $");
                        y++;
                    }
                    while (withdrawal > balance + 0.75 || withdrawal < 0)
                    {
                        Console.SetCursorPosition(12, y);
                        Console.Write("Withdrawn amount must be less than the account balance plus the transaction fee, and cannot be less than zero. Try again: $");
                        y++;
                        while (!double.TryParse(Console.ReadLine(), out withdrawal))
                        {
                            Console.SetCursorPosition(62, y);
                            Console.Write("Invalid Input. Try again: $");
                            y++;
                        }
                    }
                    balance -= withdrawal + 0.75;
                    cash += withdrawal;
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    cashText = $"Your cash: {cash.ToString("C")}";
                    balanceUpdate.Add($"WITHDRAWAL AT {DateTime.Now.ToString("HH:mm:ss")}: -{withdrawal.ToString("C")}. Balance: {(balance + withdrawal + 0.75).ToString("C")} --> {balance.ToString("C")}");
                    y++;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                    Console.WriteLine(balanceText);
                    Console.SetCursorPosition((Console.WindowWidth - cashText.Length) / 2, 4);
                    Console.WriteLine(cashText);
                    Console.SetCursorPosition(48, y);
                    Console.WriteLine("Money withdrawn. Your account balance has been updated.");
                    Console.SetCursorPosition(15, y + 1);
                    Console.WriteLine("Reminder: a fee of $0.75 is charged for each banking transaction. Your balance may be lower than expected due to that.");
                    Console.SetCursorPosition(54, y + 3);
                    Console.WriteLine("Press 'ENTER' to return to the bank menu.");
                    Console.SetCursorPosition(95, y + 3);
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    double billPayment;
                    y = 7;
                    Console.Clear();
                    Console.SetCursorPosition(56, 1);
                    Console.WriteLine("How much would you like to pay today?");
                    Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                    Console.WriteLine(balanceText);
                    Console.SetCursorPosition((Console.WindowWidth - cashText.Length) / 2, 4);
                    Console.WriteLine(cashText);
                    Console.SetCursorPosition(64, 6);
                    Console.Write("Payment Amount: $");
                    while (!double.TryParse(Console.ReadLine(), out billPayment))
                    {
                        Console.SetCursorPosition(62, y);
                        Console.Write("Invalid Input. Try again: $");
                        y++;
                    }
                    while (billPayment < 0 || billPayment > balance + 0.75)
                    {
                        Console.SetCursorPosition(12, y);
                        Console.Write("Paid amount must be less than the account balance plus the transaction fee, and cannot be less than zero. Try again: $");
                        y++;
                        while (!double.TryParse(Console.ReadLine(), out billPayment))
                        {
                            Console.SetCursorPosition(62, y);
                            Console.Write("Invalid Input. Try again: $");
                            y++;
                        }
                    }
                    balance -= billPayment + 0.75;
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    balanceUpdate.Add($"BILL PAYMENT AT {DateTime.Now.ToString("HH:mm:ss")}: -{billPayment.ToString("C")}. Balance: {(balance + billPayment + 0.75).ToString("C")} --> {balance.ToString("C")}");
                    y++;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition((Console.WindowWidth - balanceText.Length) / 2, 3);
                    Console.WriteLine(balanceText);
                    Console.SetCursorPosition(50, y);
                    Console.WriteLine("Bill paid. Your account balance has been updated.");
                    Console.SetCursorPosition(15, y + 1);
                    Console.WriteLine("Reminder: a fee of $0.75 is charged for each banking transaction. Your balance may be lower than expected due to that.");
                    Console.SetCursorPosition(54, y + 3);
                    Console.WriteLine("Press 'ENTER' to return to the bank menu.");
                    Console.SetCursorPosition(95, y + 3);
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    y = 5;
                    balance -= 0.75;
                    balanceUpdate.Add($"BALANCE UPDATE AT {DateTime.Now.ToString("HH:mm:ss")}: -$0.75. Balance: {(balance + 0.75).ToString("C")} --> {balance.ToString("C")}");
                    Console.Clear();
                    Console.SetCursorPosition(60, 1);
                    Console.WriteLine("Bank of Blorb Chequing Account");
                    Console.SetCursorPosition(55, 3);
                    Console.WriteLine("---------------------------------------");
                    for (int i = 0; i < balanceUpdate.Count; i++)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - balanceUpdate[i].Length) / 2, y);
                        Console.WriteLine(balanceUpdate[i]);
                        y += 2;
                    }
                    Console.SetCursorPosition(55, y);
                    Console.WriteLine("---------------------------------------");
                    Console.SetCursorPosition(54, y + 3);
                    Console.WriteLine("Press 'ENTER' to return to the bank menu.");
                    Console.SetCursorPosition(95, y + 3);
                    Console.ReadLine();
                }
                else if (choice == "Q")
                {
                    done = true;
                }
            }
        }

        // Doubles Roller
        public static void DoublesRoller()
        {
            Die d1 = new Die();
            Die d2 = new Die();
            int rolls = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("   Let's see how many rolls it takes until we get doubles!");
                Console.SetCursorPosition(138, 1);
                Console.WriteLine($"Rolls: {rolls}");
                Console.WriteLine();
                d1.RollDie();
                d2.RollDie();
                d1.DrawRoll();
                d2.DrawRoll();
                if (d1.Roll !=  d2.Roll)
                {
                    rolls++;
                    Console.WriteLine($"   Aw man! A {d1.Roll} and a {d2.Roll} aren't doubles! Press 'ENTER' to roll again!");
                    Console.ReadLine();
                }
                else if (d1.Roll == d2.Roll && rolls == 1)
                {
                    Console.WriteLine($"   Wow! We already got doubles?! It only took one try! Press 'ENTER' to return to the main menu.");
                    Console.ReadLine();
                    break;
                }
                else if (d1.Roll > d2.Roll)
                {
                    Console.WriteLine($"   Hey! We got doubles! It only took {rolls} tries! Press 'ENTER' to return to the main menu.");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
