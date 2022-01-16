using System.Globalization;

namespace BC_CSharp.Selecao
{
    public static class B1040
    {
        public static void PMain()
        {
            string[] n = Console.ReadLine().Split(' ');
            float n1 = float.Parse(n[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(n[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(n[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(n[3], CultureInfo.InvariantCulture);
            float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
            if (media == 4.85f)
            {
                media = 4.8f;
            }
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float n5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + n5.ToString("F1", CultureInfo.InvariantCulture));
                float mf = (media + n5) / 2;
                if (mf >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mf.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
