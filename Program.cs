namespace Assingment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if(num%i==0 )
                {
                    count++;
                }
               
            }
            if(count == 2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
        }
    }
}