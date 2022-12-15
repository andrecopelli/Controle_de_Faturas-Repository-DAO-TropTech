using LightControl.Domain.Entities;
using LightControl.Domain.Exceptions;
using LightControl.Infra.Data.Repository;
using System;
using System.Threading;



namespace LightControl
{
    public class SystemActions
    {
        private static ElectricityBillRepository _electricityBillRepository = new ElectricityBillRepository();
        private static ElectricityBill _searchedBill = new ElectricityBill();

        internal static void AddBill()
        {
            Console.Clear();
            var newBill = new ElectricityBill();
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
            Console.WriteLine("||                        [CADASTRO DE FATURA]                      ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||          TODOS OS CAMPOS SÃO DE PREENCHIMENTO OBRIGATÓRIO        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||==================================================================||");
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O NÚMERO DA LEITURA:                                  ||");
            Console.CursorLeft = 7;
            newBill.ReadNumber = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE A DATA DA LEITURA:                                    ||");
            Console.CursorLeft = 7;
            newBill.ReadDate = Convert.ToDateTime(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE A QUANTIDADE DE kW GASTOS NO MÊS:                     ||");
            Console.CursorLeft = 7;
            newBill.KwMonthlySpent = Convert.ToDecimal(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O VALOR DA FATURA:                                    ||");
            Console.CursorLeft = 7;
            newBill.BillValue = Convert.ToDecimal(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE A DATA DE PAGAMENTO:                                  ||");
            Console.CursorLeft = 7;
            newBill.PayDate = Convert.ToDateTime(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O CONSUMO MÉDIO:                                      ||");
            Console.CursorLeft = 7;
            newBill.AvgConsumption = Convert.ToDecimal(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O MÊS DA COMPETÊNCIA DA FATURA:                       ||");
            Console.CursorLeft = 7;
            newBill.BillingMonth = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O ANO DA COMPETÊNCIA DA FATURA:                       ||");
            Console.CursorLeft = 7;
            newBill.BillingYear = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            System.Console.WriteLine("======================================================================");

            if (_electricityBillRepository.VerifyIfBillExists(newBill.BillingMonth, newBill.BillingYear))
            {
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Thread.Sleep(50);
                Console.WriteLine("||                                                                  ||");
                Thread.Sleep(50);
                Console.WriteLine($"||               [FATURA {newBill.BillingMonth}/{newBill.BillingYear} JÁ FOI CADASTRADA]                  ||");
                Thread.Sleep(50);
                Console.WriteLine("||              APERTE QUALQUER TECLA PARA AVANÇAR                  ||");
                Thread.Sleep(50);
                Console.WriteLine("||                                                                  ||");
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Console.ReadKey();
                Console.Clear();
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Thread.Sleep(50);
                Console.WriteLine("||==================================================================||");
                Thread.Sleep(50);
                Console.WriteLine("||                                                [Cliente: Antônio]||");
                Thread.Sleep(50);
                Console.WriteLine("||                         LIGHT CONTROL 1.0                        ||");
                Thread.Sleep(50);
                Console.WriteLine("||       DESEJA CADASTRAR OUTRA FATURA? [1 - SIM | 2 - NÃO]         ||");
                Thread.Sleep(50);
                Console.WriteLine("||==================================================================||");
                System.Console.Write("=>");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        AddBill();
                        break;

                    case "2":
                        Console.Clear();
                        Program.MainMenu();
                        break;

                    default:
                        Console.Clear();
                        System.Console.WriteLine("OPÇÃO INVÁLIDA, APERTE QUALQUER TECLA PARA VOLTAR.");
                        Console.ReadKey();
                        Program.MainMenu();
                        break;
                }
            }
            else
            {
                _electricityBillRepository.RegisterBill(newBill);
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Thread.Sleep(50);
                Console.WriteLine("||                                                                  ||");
                Thread.Sleep(50);
                Console.WriteLine($"||              [FATURA {newBill.BillingMonth}/{newBill.BillingYear} CADASTRADA COM SUCESSO]              ||");
                Thread.Sleep(50);
                Console.WriteLine("||                APERTE QUALQUER TECLA PARA AVANÇAR                ||");
                Thread.Sleep(50);
                Console.WriteLine("||                                                                  ||");
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Console.ReadKey();
                Console.Clear();
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Thread.Sleep(50);
                Console.WriteLine("||==================================================================||");
                Thread.Sleep(50);
                Console.WriteLine("||                                                [Cliente: Antônio]||");
                Thread.Sleep(50);
                Console.WriteLine("||                         LIGHT CONTROL 1.0                        ||");
                Thread.Sleep(50);
                Console.WriteLine("||       DESEJA CADASTRAR OUTRA FATURA? [1 - SIM | 2 - NÃO]         ||");
                Thread.Sleep(50);
                Console.WriteLine("||==================================================================||");
                System.Console.Write("=>");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        AddBill();
                        break;

                    case "2":
                        Console.Clear();
                        Program.MainMenu();
                        break;

                    default:
                        Console.Clear();
                        System.Console.WriteLine("OPÇÃO INVÁLIDA, APERTE QUALQUER TECLA PARA VOLTAR.");
                        Console.ReadKey();
                        Program.MainMenu();
                        break;
                }
                Program.MainMenu();
            }
        }

        public static void ShowAllBills()
        {
            Console.Clear();
            var newBill = new ElectricityBill();
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
            Console.WriteLine("||                       [RELATÓRIO DE FATURAS]                     ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");

            var billsList = _electricityBillRepository.ShowAllBills();

            foreach (var item in billsList)
            {
                Thread.Sleep(200);
                Console.WriteLine(item);
                Console.WriteLine("||------------------------------------------------------------------||");
                Thread.Sleep(200);
            }

            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||        APERTE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL.        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.Write("                                                             ----=> ");
            Console.ReadKey();
            Console.Clear();
            Program.MainMenu();
        }

        public static void SearchBill()
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
            Console.WriteLine("||                         [BUSCA DE FATURA]                        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O MÊS DA COMPETÊNCIA DA FATURA:                       ||");
            Console.CursorLeft = 7;
            var month = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O ANO DA COMPETÊNCIA DA FATURA:                       ||");
            Console.CursorLeft = 7;
            var year = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||                        [FATURA BUSCADA]                          ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");

            try
            {
                _searchedBill = _electricityBillRepository.SearchBillForPeriod(month, year);
                Console.WriteLine(_searchedBill);
                
            }
            catch (BillNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||        APERTE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL.        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.Write("                                                             ----=> ");
            Console.ReadKey();
            Console.Clear();
            Program.MainMenu();
        }

        public static void DeleteBill()
        {

            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||==================================================== [_] [O] [X] =||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                [Cliente: Antônio]||");
            Thread.Sleep(50);
            Console.WriteLine("||                         LIGHT CONTROL 1.0                        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                        [EXCLUIR DE FATURA]                       ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O MÊS DA COMPETÊNCIA DA FATURA:                       ||");
            Console.CursorLeft = 7;
            var month = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("||     DIGITE O ANO DA COMPETÊNCIA DA FATURA:                       ||");
            Console.CursorLeft = 7;
            var year = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");

            try
            {
                
                _searchedBill = _electricityBillRepository.SearchBillForPeriod(month, year);
                _electricityBillRepository.DeleteBill(_searchedBill);
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Thread.Sleep(50);
                Console.WriteLine("||                                                                  ||");
                Thread.Sleep(50);
                Console.WriteLine($"||               [FATURA DELETADA {month}/{year} COM SUCESSO]               ||");
                Thread.Sleep(50);
                Console.WriteLine("||                                                                  ||");
                Thread.Sleep(50);
                Console.WriteLine("|====================================================================|");
                Console.ReadKey();
                Console.Clear();
                Program.MainMenu();
                
            }
            catch (BillNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("||        APERTE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL.        ||");
            Thread.Sleep(50);
            Console.WriteLine("||                                                                  ||");
            Thread.Sleep(50);
            Console.WriteLine("|====================================================================|");
            Thread.Sleep(50);
            Console.Write("                                                             ----=> ");
            Console.ReadKey();
            Console.Clear();
            Program.MainMenu();

        }

    }
}