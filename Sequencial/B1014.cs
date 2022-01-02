using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1014
    {
        public static void PMain()
        {
            int dis = int.Parse(Console.ReadLine());
            double cmb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine((dis / cmb).ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
