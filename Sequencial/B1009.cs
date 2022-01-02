using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1009
    {
        public static void PMain()
        {
            _ = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("TOTAL = R$ " + (salario + (vendas * 0.15)).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
