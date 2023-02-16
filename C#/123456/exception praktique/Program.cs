using System;

namespace exception_praktique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lets start some activity");
            var value = DoSomeParse(Console.ReadLine());
            var result = DoSomeCriminal(DoSomeParse(Console.ReadLine()), DoSomeParse(Console.ReadLine()));
            TrollFunction();
           
        }

        private static int DoSomeParse(object someValueToConvert)
        {
            try
            {
                return int.Parse(someValueToConvert.ToString());
            }
            catch
            {
                Random rnd = new Random();
                int RndInt = rnd.Next(1, 100);
                return RndInt;
            }
        }

        private static double DoSomeCriminal(int firstValue, int secondValue)
        {
            try
            {
                return firstValue / secondValue;
            }
            catch
            {
                Random rnd = new Random();
                double RndDouble;
                return RndDouble = rnd.Next(1, 100);
            }
           
        }

        private static void TrollFunction()
        {
            try
            {
                var ex = new NotImplementedException("not implemented exception created");
                Console.WriteLine(ex.Message);
                throw ex;
            }
            catch
            {
                Console.WriteLine("not implemented exception created");
            }
        }
    }
}
