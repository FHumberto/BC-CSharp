using System.Globalization;

namespace BC_CSharp.Selecao
{
    public static class B1037
    {
        public static void PMain()
        {
            float n = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n < 0 || n > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (n >= 0 && n <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n > 25 && n <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (n > 50 && n <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (n > 75 && n <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
