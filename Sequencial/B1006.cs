using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1006
    {
        public static void PMain()
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("MEDIA = " + ((a * 2 + b * 3 + c * 5) / 10.0).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
