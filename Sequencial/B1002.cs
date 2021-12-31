using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1002
    {
        public static void PMain()
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("A=" + (3.14159 * (raio * raio)).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
