using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Loops_Assignment
{
    public class Die
    {
        private Random _generator;
        private int _roll;
        private int _sides;

        // Random roll, 9 sides
        public Die()
        {
            _generator = new Random();
            _sides = 9;
            _roll = _generator.Next(1, _sides + 1);
        }

        // Random Roll, Custom sides
        public Die(int sides)
        {
            _generator = new Random();

            if (sides < 1)
            {
                _sides = 1;
            }
            else if (sides > 9)
            {
                _sides = 9;
            }
            else
            {
                _sides = sides;
            }

            _roll = _generator.Next(1, _sides + 1);
        }

        // Custom roll, Custom sides
        public Die(int sides, int startingRoll)
        {
            _generator = new Random();
            if (sides < 1)
            {
                _sides = 1;
            }
            else if (sides > 9)
            {
                _sides = 9;
            }
            else
            {
                _sides = sides;
            }

            if (startingRoll < 1)
            {
                _roll = 1;
            }
            else if (startingRoll > _sides + 1)
            {
                _roll = _sides;
            }
            else
            {
                _roll = startingRoll;
            }
        }
        public int Roll
        {
            get {  return _roll; }
        }
        public int Sides
        {
            get { return _sides; }
        }
        public override string ToString()
        {
            return _roll.ToString();
        }
        public void RollDie()
        {
            _roll = _generator.Next(1, _sides + 1);
        }
        public void RollDie(int loadedValue)
        {
            int chance = _generator.Next(1, 101);

            if (chance <= 50)
            {
                _roll = loadedValue;
            }
            else
            {
                _roll = _generator.Next(1, _sides + 1);
            }
        }
        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("|       |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 2)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 3)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O     |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("|     O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 4)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O   O |");
                Console.WriteLine("|       |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 5)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O   O |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 6)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 7)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O O O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 8)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O O O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O O O |");
                Console.WriteLine("'-------'");
            }
            else if (_roll == 9)
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| O O O |");
                Console.WriteLine("| O O O |");
                Console.WriteLine("| O O O |");
                Console.WriteLine("'-------'");
            }
        }
    }
}
