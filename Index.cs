using BC_CSharp.Inicial;
using BC_CSharp.Sequencial;

namespace BC_CSharp
{
    internal static class Index
    {
        private static void Main()
        {
            string? a;
            do
            {
                Console.WriteLine("INFORME O NUMERO DO PROBLEMA:");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1000:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1000 - HELLO WORLD!");
                            B1000.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1001:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1001 - EXTREMAMENTE BASICO:");
                            B1001.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1002:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1002 - AREA DO CIRCULO:");
                            B1002.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1003:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1003 - SOMA SIMPLES:");
                            B1003.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1004:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1004 - PRODUTO SIMPLES:");
                            B1004.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1005:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1005 - MEDIA 1:");
                            B1005.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1006:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1006 - MEDIA 2:");
                            B1006.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1007:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1007 - DIFERENCA:");
                            B1007.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1008:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1008 - SALARIO:");
                            B1008.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1009:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1009 - SALARIO COM BONUS:");
                            B1009.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1010:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1010 - CALCULO SIMPLES:");
                            B1010.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1011:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1011 - ESFERA:");
                            B1011.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1012:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1012 - AREA:");
                            B1012.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    default:
                        Console.WriteLine("VALOR INVALIDO");
                        break;
                }
                Repetir(1);
                a = Convert.ToString(Console.ReadLine());
            }
            while (a == "S" || a == "s");
        }

        private static void Repetir(int i)
        {
            if (i == 0)
            {
                Console.WriteLine("\nDESEJA EXECUTAR O PROBLEMA NOVAMENTE? [S/N]");
            }
            else
            {
                Console.WriteLine("\nDESEJA EXECUTAR TODO O CODIGO NOVAMENTE? [S/N]");
            }
        }
    }
}