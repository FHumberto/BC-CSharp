namespace BC_CSharp.Selecao
{
    internal static class B1042
    {
        public static void PMain()
        {
            string[] n = Console.ReadLine().Split(' ');
            int[] x = new int[3];
            x[0] = int.Parse(n[0]);
            x[1] = int.Parse(n[1]);
            x[2] = int.Parse(n[2]);
            int[] y = { x[0], x[1], x[2] };
            Array.Sort(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(y[i]);
            }
        }
    }
}
