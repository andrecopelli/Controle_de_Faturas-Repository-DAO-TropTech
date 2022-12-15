using System;
using System.Threading;

namespace LightControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||==================================================== [_] [O] [X] =||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                [Cliente: Antônio]||");
            Thread.Sleep(50);
            Console.WriteLine("||                         LIGHT CONTROL 1.0                        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||==================================================================||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||                       ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||         =====         ||");
            Thread.Sleep(50);
            Console.WriteLine("||  ESCOLHA UMA OPÇÃO:                     ||       ==     ==       ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||      ==       ==      ||");
            Thread.Sleep(50);
            Console.WriteLine("||  [1] - ADICIONAR FATURA                 ||     ==         ==     ||");
            Thread.Sleep(50);
            Console.WriteLine("||  [2] - MOSTRAR TODAS AS FATURAS         ||     ==         ==     ||");
            Thread.Sleep(50);
            Console.WriteLine("||  [3] - BUSCAR FATURA                    ||     ==   (V)   ==     ||");
            Thread.Sleep(50);
            Console.WriteLine("||  [4] - DELETAR FATURA                   ||      ==  | |  ==      ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||       ||=====||       ||");
            Thread.Sleep(50);
            Console.WriteLine(@"||                                         ||        \\_=_//        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||                       ||");
            Thread.Sleep(50);
            Console.WriteLine("||==================================================================||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||                       ||");
            Thread.Sleep(50);
            Console.WriteLine("||  [0] - SAIR                             ||     TROPTECH HOME     ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                         ||                       ||");
            Thread.Sleep(50);
            Console.WriteLine("||==================================================================||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.Write("                                                             ----=> ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    SystemActions.AddBill();
                    break;

                case "2":
                    Console.Clear();
                    SystemActions.ShowAllBills();
                    break;

                case "3":
                    Console.Clear();
                    SystemActions.SearchBill();
                    break;

                case "4":
                    Console.Clear();
                    SystemActions.DeleteBill();
                    break;

                case "0":
                    Console.Clear();
                    ExitScreen();
                    break;

                default:
                    Console.Clear();
                    Thread.Sleep(50);
                    Console.WriteLine("|====================================================================|");
                    Thread.Sleep(50);
                    Console.WriteLine("||                                                                  ||");
                    Thread.Sleep(50);
                    Console.WriteLine("||                        OPÇÃO INVÁLIDA!                           ||");
                    Thread.Sleep(50);
                    Console.WriteLine("||        APERTE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL.        ||");
                    Thread.Sleep(50);
                    Console.WriteLine("||                                                                  ||");
                    Thread.Sleep(50);
                    Console.WriteLine("|====================================================================|");
                    Thread.Sleep(50);
                    Console.Write("                                                             ----=> ");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        public static void ExitScreen()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||====================================================================|");
            Thread.Sleep(100);
            Console.WriteLine("||                        [LIGHT CONTROL 1.0]                        ||");
            Thread.Sleep(100);
            Console.WriteLine("||'If you can't make it good, at least make it look good.' Bill Gates||");
            Thread.Sleep(100);
            Console.WriteLine("||                                                                   ||");
            Thread.Sleep(100);
            Console.WriteLine("||                            ===========                            ||");
            Thread.Sleep(100);
            Console.WriteLine("||                       ====             ====                       ||");
            Thread.Sleep(100);
            Console.WriteLine("||                      ==                    ==                     ||");
            Thread.Sleep(100);
            Console.WriteLine("||                    ==                       ==                    ||");
            Thread.Sleep(100);
            Console.WriteLine("||                  ==                           ==                  ||");
            Thread.Sleep(100);
            Console.WriteLine("||                ==          DEVELOPED BY         ==                ||");
            Thread.Sleep(100);
            Console.WriteLine("||               ==                                 ==               ||");
            Thread.Sleep(100);
            Console.WriteLine("||              ==         ANDRÉ LUIZ COPELLI        ==              ||");
            Thread.Sleep(100);
            Console.WriteLine("||              ==                                   ==              ||");
            Thread.Sleep(100);
            Console.WriteLine("||               ==                                 ==               ||");
            Thread.Sleep(100);
            Console.WriteLine("||                 ==                              ==                ||");
            Thread.Sleep(100);
            Console.WriteLine("||                  ==             (V)            ==                 ||");
            Thread.Sleep(100);
            Console.WriteLine(@"||                   ==            \ /           ==                  ||");
            Thread.Sleep(100);
            Console.WriteLine("||                    ==           | |          ==                   ||");
            Thread.Sleep(100);
            Console.WriteLine("||                    ==           | |          ==                   ||");
            Thread.Sleep(100);
            Console.WriteLine("||                     ==          | |        ==                     ||");
            Thread.Sleep(100);
            Console.WriteLine("||                      ||====================||                     ||");
            Thread.Sleep(100);
            Console.WriteLine(@"||                        \\################//                       ||");
            Thread.Sleep(100);
            Console.WriteLine(@"||                         \\##############//                        ||");
            Thread.Sleep(100);
            Console.WriteLine(@"||                          \\############//                         ||");
            Thread.Sleep(100);
            Console.WriteLine(@"||                               \\___//                             ||");
            Thread.Sleep(100);
            Console.WriteLine("||                                                                   ||");
            Thread.Sleep(100);
            Console.WriteLine("||                                                                   ||");
            Thread.Sleep(100);
            Console.WriteLine("||                  APERTE QUALQUER TECLA PARA SAIR!                 ||");
            Thread.Sleep(100);
            Console.WriteLine("||===================================================================||");
            Console.ReadKey();
        }
    }
}