namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dogum ilinizi daxil edin:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age + 18 < 2023)
            {
                Console.WriteLine("18 yadan boyuksunuz");

            }
            else if (age + 18 == 2023)
            {
                Console.WriteLine("yasiniz 18dir");
            }
            else
            {

                Console.WriteLine("18 yasi tamam olmayib");
            }






            /* Console.WriteLine("4 reqemli eded daxil edin ");
                 int number, a, b, c, d;
                 number = Convert.ToInt32(Console.ReadLine());
                 a = number / 1000 % 10;
                 b = number / 100 % 10;
                 c = number / 10 % 10;
                 d = number % 10;
                 Console.WriteLine(a + b + c + d);*/

        }
    }
}