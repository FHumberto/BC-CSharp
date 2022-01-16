using System.Globalization;

namespace BC_CSharp.Selecao
{
    public static class B1038
    {
        public static void PMain()
        {
            string[] l = Console.ReadLine().Split(' ');
            int cod = int.Parse(l[0]);
            int qtd = int.Parse(l[1]);
            double val = 0;
            switch (cod)
            {
                case 1:
                    val = qtd * 4.00;
                    break;
                case 2:
                    val = qtd * 4.50;
                    break;
                case 3:
                    val = qtd * 5.00;
                    break;
                case 4:
                    val = qtd * 2.00;
                    break;
                case 5:
                    val = qtd * 1.50;
                    break;
            }
            Console.WriteLine("Total: R$ " + val.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
