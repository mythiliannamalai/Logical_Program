namespace Logical_Program
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
                //Console.Write(FIRST_NUMBER + " " + SECOND_NUMBER + " ");
            }

        }
    }
    class Display
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Fibonacci_Series();

        }
    }
}