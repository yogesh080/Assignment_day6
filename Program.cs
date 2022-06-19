namespace Assingment6
{
    internal class Program
    {
        public static int Factor(int input)
        {
            int sum = 0;
            for (int i = 1; i < input ; i++)
            {
                if(input%i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
            
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = Factor(input);
            if(input == result)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
            
            
        }

        }
    }