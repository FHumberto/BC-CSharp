using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1011
    {
        public static void PMain()
        {
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("VOLUME = " + ((4 / 3.0) * 3.14159 * Math.Pow(raio, 3)).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
