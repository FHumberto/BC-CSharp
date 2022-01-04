namespace BC_CSharp.Sequencial
{
    public static class B1019
    {
        public static void PMain()
        {
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine((s / 3600) + ":" + ((s / 60) % 60) + ":" + (s % 60));
        }
    }
}
