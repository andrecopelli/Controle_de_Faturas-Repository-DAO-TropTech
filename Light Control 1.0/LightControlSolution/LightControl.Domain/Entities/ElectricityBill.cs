using System;

namespace LightControl.Domain.Entities
{
    public class ElectricityBill
    {
        public int ReadNumber { get; set; }
        public DateTime ReadDate { get; set; }
        public Decimal KwMonthlySpent { get; set; }
        public Decimal BillValue { get; set; }
        public DateTime PayDate { get; set; }
        public Decimal AvgConsumption { get; set; }
        public int BillingMonth { get; set; }
        public int BillingYear { get; set; }

        public ElectricityBill()
        {
            
        }
                
        public ElectricityBill(int readNumber, DateTime readDate, Decimal kwSpent, Decimal billValue, DateTime payDate, Decimal avgConsumption, int month, int year)
        {
            ReadNumber = readNumber;
            ReadDate = readDate;
            KwMonthlySpent = kwSpent;
            BillValue = billValue;
            PayDate = payDate;
            AvgConsumption = avgConsumption;
            BillingMonth = month;
            BillingYear = year;
        }

        public override string ToString()
        {
            return $"||NÚMERO: {ReadNumber} - LEITURA: {ReadDate.ToShortDateString()} - KW/MÊS: {KwMonthlySpent} - VALOR: R${BillValue}   ||\n||PAGAMENTO: {PayDate.ToShortDateString()} - CONSUMO MÉDIO: {AvgConsumption} - PERÍODO: {BillingMonth}/{BillingYear}   ||";
        }
    }
}
