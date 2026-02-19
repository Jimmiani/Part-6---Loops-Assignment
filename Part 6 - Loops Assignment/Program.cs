using System.Numerics;

namespace Part_6___Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string choice = "";
            while (!done)
            {
                Console.Clear();
                CentreText("Welcome to my loops programming assignment!", 2);
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
                while (choice != "1" && choice != "2" && choice != "3" && choice != "Q")
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
                else if (choice == "Q")
                {
                    done = true;
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
            double balance = 150, cash = 10000, fee = 0.75;
            List <string> balanceUpdate = new List<string>();
            while (!done)
            {
                int y = 20;
                string balanceText = $"Your balance: {balance.ToString("C")}";
                string cashText = $"Your cash: {cash.ToString("C")}";
                Console.Clear();
                CentreText("Welcome to the Bank of Blorb!", 1);
                Console.WriteLine();
                CentreText(balanceText, 3);
                CentreText(cashText, 4);
                CentreText("---------------------------------------", 5);


                Console.SetCursorPosition(42, 7);
                CentreText("Here, you are able to make any Blorbian transaction that you wish.", 7);
                CentreText($"Please note: You are charged a fee of {fee.ToString("C")} for each banking transaction or any error made.", 8);
                CentreText("Select what transaction you'd like to perform:", 10);
                CentreText("Option 1: Deposit", 12);
                CentreText("Option 2: Withdrawal", 13);
                CentreText("Option 3: Bill Payment", 14);
                CentreText("Option 4: Balance Update", 15);
                CentreText("Or, enter 'Q' to exit.", 16);
                CentreText("---------------------------------------", 18);
                CentreText("Enter in your choice here: ", 19, true);
                choice = Console.ReadLine();
                choice = choice.ToUpper().Trim();
                while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "Q")
                {
                    balance -= fee;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    balanceUpdate.Add($"ERROR AT {DateTime.Now.ToString("HH:mm:ss")}: -{fee.ToString("C")}. Balance: {(balance + fee).ToString("C")} --> {balance.ToString("C")}");
                    CentreText(balanceText, 3);
                    CentreText("Invalid Input. Account balance updated. Try again: ", y, true);
                    choice = Console.ReadLine();
                    y++;
                }
                if (choice == "1")
                {
                    double deposit;
                    y = 7;
                    Console.Clear();
                    CentreText("How much would you like to deposit today?", 1);
                    CentreText(balanceText, 3);
                    CentreText(cashText, 4);
                    CentreText("Deposit Amount: $", 6, true);
                    while (!double.TryParse(Console.ReadLine(), out deposit))
                    {
                        CentreText("Invalid Input. Try again: $", y, true);
                        y++;
                    }
                    while (deposit < fee || deposit > cash)
                    {
                        CentreText($"Deposited amount must be larger than {fee.ToString("C")} and less than cash on-hand. Try again: $", y, true);
                        y++;
                        while (!double.TryParse(Console.ReadLine(), out deposit))
                        {
                            CentreText("Invalid Input. Try again: $", y, true);
                            y++;
                        }
                    }
                    balance += deposit - fee;
                    cash -= deposit;
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    cashText = $"Your cash: {cash.ToString("C")}";
                    balanceUpdate.Add($"DEPOSIT AT {DateTime.Now.ToString("HH:mm:ss")}: +{deposit.ToString("C")}. Balance: {(balance - deposit + fee).ToString("C")} --> {balance.ToString("C")}");

                    y++;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string(' ', Console.WindowWidth));
                    CentreText(balanceText, 3);
                    CentreText(cashText, 4);
                    CentreText("Money deposited. Your account balance has been updated.", y); y++;
                    CentreText($"Reminder: a fee of {fee.ToString("C")} is charged for each banking transaction. Your balance may be lower than expected due to that.", y); y += 2;
                    CentreText("Press 'ENTER' to return to the bank menu.", y);
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    double withdrawal;
                    y = 7;
                    Console.Clear();
                    CentreText("How much would you like to withdraw today?", 1);
                    CentreText(balanceText, 3);
                    CentreText(cashText, 4);
                    CentreText("Withdrawal Amount: $", 6, true);
                    while (!double.TryParse(Console.ReadLine(), out withdrawal))
                    {
                        CentreText("Invalid Input. Try again: $", y, true);
                        y++;
                    }
                    while (withdrawal > balance + fee || withdrawal < 0)
                    {
                        CentreText("Amount must be less than the account balance plus the transaction fee, and cannot be less than zero. Try again: $", y, true);
                        y++;
                        while (!double.TryParse(Console.ReadLine(), out withdrawal))
                        {
                            CentreText("Invalid Input. Try again: $", y, true);
                            y++;
                        }
                    }
                    balance -= withdrawal + fee;
                    cash += withdrawal;
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    cashText = $"Your cash: {cash.ToString("C")}";
                    balanceUpdate.Add($"WITHDRAWAL AT {DateTime.Now.ToString("HH:mm:ss")}: -{withdrawal.ToString("C")}. Balance: {(balance + withdrawal + fee).ToString("C")} --> {balance.ToString("C")}");
                    y++;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, 4);
                    Console.Write(new string(' ', Console.WindowWidth));
                    CentreText(balanceText, 3);
                    CentreText(cashText, 4);
                    CentreText("Money withdrawn. Your account balance has been updated.", y); y++;
                    CentreText($"Reminder: a fee of {fee.ToString("C")} is charged for each banking transaction. Your balance may be lower than expected due to that.", y); y += 2;
                    CentreText("Press 'ENTER' to return to the bank menu.", y);
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    double billPayment;
                    y = 7;
                    Console.Clear();
                    CentreText("How much would you like to pay today?", 1);
                    CentreText(balanceText, 3);
                    CentreText(cashText, 4);
                    CentreText("Payment Amount: $", 6, true);
                    while (!double.TryParse(Console.ReadLine(), out billPayment))
                    {
                        CentreText("Invalid Input. Try again: $", y, true);
                        y++;
                    }
                    while (billPayment < 0 || billPayment > balance + fee)
                    {
                        CentreText("Amount must be less than the account balance plus the transaction fee, and cannot be less than zero. Try again: $", y, true);
                        y++;
                        while (!double.TryParse(Console.ReadLine(), out billPayment))
                        {
                            CentreText("Invalid Input. Try again: $", y, true);
                            y++;
                        }
                    }
                    balance -= billPayment + fee;
                    balanceText = $"Your balance: {balance.ToString("C")}";
                    balanceUpdate.Add($"BILL PAYMENT AT {DateTime.Now.ToString("HH:mm:ss")}: -{billPayment.ToString("C")}. Balance: {(balance + billPayment + fee).ToString("C")} --> {balance.ToString("C")}");
                    y++;
                    Console.SetCursorPosition(0, 3);
                    Console.Write(new string(' ', Console.WindowWidth));
                    CentreText(balanceText, 3);
                    CentreText("Bill paid. Your account balance has been updated.", y); y++;
                    CentreText($"Reminder: a fee of {fee.ToString("C")} is charged for each banking transaction. Your balance may be lower than expected due to that.", y); y += 2;
                    CentreText("Press 'ENTER' to return to the bank menu.", y);
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    y = 5;
                    balance -= fee;
                    balanceUpdate.Add($"BALANCE UPDATE AT {DateTime.Now.ToString("HH:mm:ss")}: -{fee.ToString("C")}. Balance: {(balance + fee).ToString("C")} --> {balance.ToString("C")}");
                    Console.Clear();
                    CentreText("Bank of Blorb Chequing Account", 1);
                    CentreText("---------------------------------------", 3);
                    for (int i = 0; i < balanceUpdate.Count; i++)
                    {
                        CentreText(balanceUpdate[i], y);
                        y += 2;
                    }
                    CentreText("---------------------------------------", y); y += 2;
                    CentreText("Press 'ENTER' to return to the bank menu.", y);
                    Console.ReadLine();
                }
                else if (choice.ToUpper() == "Q")
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
                Console.WriteLine("Let's see how many rolls it takes until we get doubles!");
                Console.SetCursorPosition(Console.WindowWidth - 13, 1);
                Console.WriteLine($"Rolls: {rolls}");
                Console.WriteLine();
                Console.WriteLine("Dice 1:");
                d1.RollDie();
                d1.DrawRoll();
                Console.WriteLine();
                Console.WriteLine("Dice 2:");
                d2.RollDie();
                d2.DrawRoll();
                Console.WriteLine();
                if (d1.Roll !=  d2.Roll)
                {
                    rolls++;
                    Console.WriteLine($"Aw man! A {d1.Roll} and a {d2.Roll} aren't doubles! Press 'ENTER' to roll again!");
                    Console.ReadLine();
                }
                else if (d1.Roll == d2.Roll && rolls == 1)
                {
                    Console.WriteLine($"Wow! We already got doubles?! It only took one try! Press 'ENTER' to return to the main menu.");
                    Console.ReadLine();
                    break;
                }
                else if (d1.Roll == d2.Roll)
                {
                    Console.WriteLine($"Hey! We got doubles! It only took {rolls} tries! Press 'ENTER' to return to the main menu.");
                    Console.ReadLine();
                    break;
                }
            }
        }

        public static void CentreText(string text, int y, bool write = false)
        {
            if (!write)
            {
                Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, y);
                Console.WriteLine(text);
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, y);
                Console.Write(text);
            }
        }
    }
}
