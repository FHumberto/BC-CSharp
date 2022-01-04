namespace BC_CSharp.Sequencial
{
    public static class B1020
    {
        public static void PMain()
        {
            int dias = int.Parse(Console.ReadLine());
            Console.WriteLine((dias / 365) + " ano(s)");
            Console.WriteLine(((dias % 365) / 30) + " mes(es)");
            Console.WriteLine(((dias % 365) % 30) + " dia(s)");
        }
    }
}
