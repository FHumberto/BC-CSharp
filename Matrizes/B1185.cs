using System.Globalization;

namespace BC_CSharp.Matrizes
{
    public static class B1185
    {
        public static void PMain()
        {
            char o = char.Parse(Console.ReadLine());
            float[,] mat = new float[12, 12];
            float val = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    mat[i, j] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if ((i + j) < 11)
                    {
                        val += mat[i, j];
                    }
                }
            }
            if (o == 'S')
            {
                Console.WriteLine(val.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine((val / 66).ToString("F1", CultureInfo.InvariantCulture));
            }
        }

    }
}
