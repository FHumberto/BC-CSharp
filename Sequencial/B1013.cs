namespace BC_CSharp.Sequencial
{
    public static class B1013
    {
        public static void PMain()
        {
            string[] linha = Console.ReadLine().Split(' ');
            int a = int.Parse(linha[0]);
            int b = int.Parse(linha[1]);
            int c = int.Parse(linha[2]);
            double mab = (a + b + Math.Abs(a - b)) / 2.0;
            Console.WriteLine(((mab + c + Math.Abs(mab - c)) / 2.0) + " eh o maior");
        }
    }
}
