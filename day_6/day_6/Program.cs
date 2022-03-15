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
            Console.WriteLine("Starting Range : ");
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
                    Console.Write("{0} ", n);
            }
        }
    }
    class Display
    {
        public static void Main()
        {
            Program program = new Program();
            program.Fibonacci_Series();
            program.Perfect_number();
        }
    }
}
