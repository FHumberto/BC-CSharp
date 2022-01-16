using System.Globalization;

// o A nunca pode ser zero.

namespace BC_CSharp.Selecao
{
    public static class B1036
    {
        public static void PMain()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0], CultureInfo.InvariantCulture);
            double b = double.Parse(linha[1], CultureInfo.InvariantCulture);
            double c = double.Parse(linha[2], CultureInfo.InvariantCulture);
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
