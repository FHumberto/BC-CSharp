using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1017
    {
        public static void PMain()
        {
            int temp = int.Parse(Console.ReadLine());
            int vel = int.Parse(Console.ReadLine());
            Console.WriteLine(((double)(temp * vel) / 12).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
