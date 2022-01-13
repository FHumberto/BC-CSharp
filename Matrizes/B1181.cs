using System.Globalization;

namespace BC_CSharp.Matrizes
{
    public static class B1181
    {
        public static void PMain()
        {
            byte l = byte.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());
            double[,] mat = new double[12, 12];
            double val = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (i == l)
                    {
                        val = val + mat[i, j];
                    }
                }
            }
            if (o == 'S')
            {
                Console.WriteLine(val.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine((val / 12).ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
