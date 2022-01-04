namespace BC_CSharp.Sequencial
{
    public static class B1018
    {
        public static void PMain()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine(n);
            do
            {
                Console.WriteLine("{0} nota(s) de R$ {1},00", (n / notas[i]), notas[i]);
                if (n >= notas[i])
                {
                    n -= notas[i] * (n / notas[i]);
                }
            } while (notas[i++] != 1);
        }
    }
}
