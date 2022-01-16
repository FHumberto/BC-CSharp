using System.Globalization;

namespace BC_CSharp.Selecao
{
    public static class B1041
    {
        public static void PMain()
        {
            string[] l = Console.ReadLine().Split(' ');
            float x = float.Parse(l[0], CultureInfo.InvariantCulture);
            float y = float.Parse(l[1], CultureInfo.InvariantCulture);
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y != 0 && x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
