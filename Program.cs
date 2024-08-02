// See https://aka.ms/new-console-template for more information

namespace Day_3
{
    internal class Program
    {
        public static void sumOut(int a, int b, out int result)
        {
            result = a + b;

        }
        public static void sumRef(ref int a,ref int b)
        {
            Console.WriteLine(a + b);

        }
        static void Main(string[] args)
        {
            int output=0,a = 1, b = 3;
            sumOut(a,b,out output)
            sumRef(ref a, ref b);
            Console.WriteLine("Value a=" + a + "b=" + b);
           
           
        }
    }

}
