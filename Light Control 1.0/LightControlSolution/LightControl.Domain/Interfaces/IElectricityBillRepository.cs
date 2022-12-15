using LightControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.Domain.Interfaces
{
    public interface IElectricityBillRepository
    {
        void RegisterBill(ElectricityBill newBill);
        List<ElectricityBill> ShowAllBills();
        ElectricityBill SearchBillForPeriod(int month, int year);
        void DeleteBill(ElectricityBill searchedBill);
        bool VerifyIfBillExists(int month, int year);
    }
}
