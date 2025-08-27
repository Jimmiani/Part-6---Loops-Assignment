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
                Console.SetCursorPosition(35, 2);
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
    }
}
