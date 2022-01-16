using BC_CSharp.Inicial;
using BC_CSharp.Matrizes;
using BC_CSharp.Selecao;
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

                    case 1013:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1013 - O MAIOR:");
                            B1013.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1014:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1014 - CONSUMO:");
                            B1014.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1015:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1015 - DISTANCIA ENTRE DOIS PONTOS:");
                            B1015.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1016:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1016 - DISTANCIA:");
                            B1016.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1017:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1017 - GASTO DE COMBUSTIVEL:");
                            B1017.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1018:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1018 - CEDULAS:");
                            B1018.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1019:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1019 - CONVERSÃO DE TEMPO:");
                            B1019.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1020:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1020 - IDADE:");
                            B1020.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1035:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1035 - TESTE DE SELECAO:");
                            B1035.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1036:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1036 - FORMULA DE BASKARA:");
                            B1036.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1037:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1037 - INTERVALO:");
                            B1037.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1038:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1038 - LANCHE:");
                            B1038.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1040:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1040 - MEDIA 3:");
                            B1040.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1041:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1041 - COORDENADAS DE UM PONTO:");
                            B1041.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1181:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1181 - LINHA NA MATRIZ:");
                            B1181.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1182:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1182 - COLUNA NA MATRIZ:");
                            B1182.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1183:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1183 - ACIMA DA DIAGONAL PRINCIPAL:");
                            B1183.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;


                    case 1184:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1184 - ABAIXO DA DIAGONAL PRINCIPAL:");
                            B1184.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1185:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1185 - ACIMA DA DIAGONAL SECUNDARIA:");
                            B1185.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1186:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1186 - ABAIXO DA DIAGONAL SECUNDARIA:");
                            B1186.PMain();
                            Repetir(0);
                            a = Convert.ToString(Console.ReadLine()); //NULL
                        } while (a == "S" || a == "s");
                        break;

                    case 1187:
                        do
                        {
                            Console.WriteLine("\nPROBLEMA 1187 - AREA SUPERIOR:");
                            B1187.PMain();
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