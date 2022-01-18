namespace BC_CSharp.Selecao
{
    public static class B1049
    {
        public static void PMain()
        {
            string? t1 = Console.ReadLine();
            string? t2 = Console.ReadLine();
            string? t3 = Console.ReadLine();
            if (t1 == "vertebrado")
            {
                if (t2 == "ave")
                {
                    if (t3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (t3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (t2 == "mamifero")
                {
                    if (t3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (t3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (t1 == "invertebrado")
            {

                if (t2 == "inseto")
                {
                    if (t3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (t3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (t2 == "anelideo")
                {
                    if (t3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (t3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
