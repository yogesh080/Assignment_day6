namespace Assingment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series of number is: ");
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }
        }
    }
}