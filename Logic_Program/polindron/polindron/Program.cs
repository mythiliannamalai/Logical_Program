namespace day_6
{
    class Program
    {
        public void Fibonacci_Series()
        {
            int FIRST_NUMBER = 0;
            int SECOND_NUMBER = 1;
            int NEXT_NUMBER;
            int USER_ENTER_NUMBER;
            Console.WriteLine("1) Enter the Nth value :");
            USER_ENTER_NUMBER = int.Parse(Console.ReadLine());
            Console.WriteLine(FIRST_NUMBER + " ");
            Console.WriteLine(SECOND_NUMBER + " ");
            for (int i = 2; i <= USER_ENTER_NUMBER; i++)
            {
                NEXT_NUMBER = (FIRST_NUMBER + SECOND_NUMBER);
                Console.WriteLine(NEXT_NUMBER + " ");
                FIRST_NUMBER = SECOND_NUMBER;
                SECOND_NUMBER = NEXT_NUMBER;
            }

        }
        public void Perfect_number()
        {
            int START_RANGE;
            int END_RANGE;
            Console.WriteLine("\n 2) Starting Range : ");
            START_RANGE = int.Parse(Console.ReadLine());
            Console.WriteLine("Ending Range : ");
            END_RANGE = int.Parse(Console.ReadLine());
            for (int n = START_RANGE; n <= END_RANGE; n++)
            {
                int sum = 0;
                int i = 1;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                {
                    Console.Write("{0} ", n);
                }
                else
                {
                    Console.WriteLine("There is no perfect in between the {0} and {1} number...", START_RANGE, END_RANGE);
                }
            }
        }
        public void Prime_number()
        {
            int IS_PRIME;
            int VALUE = 1;
            Console.WriteLine("\n 3) Enter the number : ");
            IS_PRIME = int.Parse(Console.ReadLine());
            for (int i = 2; i < IS_PRIME; i++)
            {
                if (IS_PRIME % i == 0)
                {
                    VALUE = 0;
                }
            }
            if (VALUE == 0)
            {
                Console.WriteLine(" {0} is not prime number...", IS_PRIME);
            }
            else
            {
                Console.WriteLine("{0} is prime number...", IS_PRIME);
            }

        }
        public void poli_num()
        {
            Console.WriteLine("\n 4) Enter the number :");
            int num = int.Parse(Console.ReadLine());
            int revers = 0;
            int reminder = 0;
            int original_num = num;
            while (num != 0)
            {
                reminder = num % 10;
                revers = (revers * 10) + reminder;
                num = num / 10;

            }
            if (original_num == revers)
            {
                Console.WriteLine("{0} is polindron..", revers);
            }
            else
            {
                Console.WriteLine("{0} is not polindron..", revers);
            }
        }
    }
    class Display
    {
        public static void Main()
        {
            Console.WriteLine("1.Fibonacci number");
            Console.WriteLine("2.Perfect number");
            Console.WriteLine("3.Prime number");
            Console.WriteLine("4.Polindron number");
            Console.WriteLine("Enter your choice : ");
            int x = int.Parse(Console.ReadLine());
            Program program = new Program();
            switch (x)
            {
                case 1:
                    program.Fibonacci_Series();
                    break;
                case 2:
                    program.Perfect_number();
                    break;
                case 3:
                    program.Prime_number();
                    break;
                case 4:
                    program.poli_num();
                    break;
                default:
                    Console.WriteLine("invalid input....");
                    break;
            }

        }
    }
}