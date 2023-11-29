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
        
         public void poli_num(){
        int num=234;
        int rev=0;
        while (num!=0) {
            rev = rev * 10 + num % 10;
            num = num / 10;
        }
        System.out.println("Revs number : "+rev);
    }
        
        public void poli_string(){
        String name = "mythili";
        String rev = "";
        for (int i=name.length()-1;i>=0;i--){
            rev= rev+name.charAt(i);
        }
        System.out.println(" Revs string : "+rev);
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
