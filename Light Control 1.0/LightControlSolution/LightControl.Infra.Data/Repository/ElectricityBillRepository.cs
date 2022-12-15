using LightControl.Domain.Entities;
using LightControl.Domain.Interfaces;
using LightControl.Infra.Data.DAO;
using System.Collections.Generic;
using System.Linq;
using LightControl.Domain.Exceptions;

namespace LightControl.Infra.Data.Repository
{
    public class ElectricityBillRepository : IElectricityBillRepository
    {
        private readonly ElectricityBillDAO _electricityBillDAO = new ElectricityBillDAO();
        
        public void RegisterBill(ElectricityBill newBill)
        {
            _electricityBillDAO.InsertBill(newBill);
        }

        public ElectricityBill SearchBillForPeriod(int month, int year)
        {
            var searchedBill = _electricityBillDAO.SearchBill(month, year);
            if (searchedBill is null)
            {
                throw new BillNotFoundException();
            }
            else
            {
                return _electricityBillDAO.SearchBill(month, year);
            }
            
        }

        public List<ElectricityBill> ShowAllBills()
        {
            var billsList = _electricityBillDAO.ShowBills();
            if (billsList.Any())
            {
                return billsList;
            }
            else
            {
                throw new BillNotFoundException();
            }
        }

        public void DeleteBill(ElectricityBill searchedBill)
        {
            if (searchedBill is null)
            {
                throw new BillNotFoundException();
            }
            else
            {
                _electricityBillDAO.DeleteBill(searchedBill);
            }
            
        }

        public bool VerifyIfBillExists(int month, int year)
        {
            var searchedBill = _electricityBillDAO.SearchBill(month, year);

            if (searchedBill == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
