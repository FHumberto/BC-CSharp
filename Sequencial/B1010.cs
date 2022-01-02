using System.Globalization;

namespace BC_CSharp.Sequencial
{
    public static class B1010
    {
        public static void PMain()
        {
            string[] l1 = Console.ReadLine().Split(' ');
            _ = l1[0];
            int np1 = int.Parse(l1[1]);
            float val1 = float.Parse(l1[2], CultureInfo.InvariantCulture);
            string[] l2 = Console.ReadLine().Split(' ');
            _ = l2[0];
            int np2 = int.Parse(l2[1]);
            float val2 = float.Parse(l2[2], CultureInfo.InvariantCulture);
            Console.WriteLine("VALOR A PAGAR: R$ " + ((np1 * val1) + (np2 * val2)).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
