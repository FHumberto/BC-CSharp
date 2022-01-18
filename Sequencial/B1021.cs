﻿using System.Globalization;

namespace BC_CSharp.Sequencial
{
    internal static class B1021
    {
        public static void PMain()
        {
            int z;
            double[] dinheiro = { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0, 1.0, 0.5, 0.25, 0.10, 0.05, 0.01, 0 };
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTAS:");
            int i = 0;
            n += 1e-9;

            while (dinheiro[i] >= 0.01)

            {
                z = 0;

                while (n >= dinheiro[i])

                {
                    n -= dinheiro[i];

                    z++;
                }

                if (dinheiro[i] == 1.0)

                    Console.WriteLine("MOEDAS:");

                if (dinheiro[i] >= 2.0)

                    Console.WriteLine("{0} nota(s) de R$ {1}", z, dinheiro[i].ToString("F2", CultureInfo.InvariantCulture));
                else

                    Console.WriteLine("{0} moeda(s) de R$ {1}", z, dinheiro[i].ToString("F2", CultureInfo.InvariantCulture));

                i++;
            }
        }
    }
}