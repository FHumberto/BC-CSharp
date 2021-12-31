using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1005
    {
        public static void PMain()
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("MEDIA = " + (((n1 * 3.5) + (n2 * 7.5)) / 11.0).ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
