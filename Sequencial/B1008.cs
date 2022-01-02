using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1008
    {
        public static void PMain()
        {
            int id = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = U$ " + (horas * salario).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
