using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1015
    {
        public static void PMain()
        {
            string[] l1 = Console.ReadLine().Split(' ');
            string[] l2 = Console.ReadLine().Split(' ');
            float x1 = float.Parse(l1[0], CultureInfo.InvariantCulture);
            float y1 = float.Parse(l1[1], CultureInfo.InvariantCulture);
            float x2 = float.Parse(l2[0], CultureInfo.InvariantCulture);
            float y2 = float.Parse(l2[1], CultureInfo.InvariantCulture);
            Console.WriteLine((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
