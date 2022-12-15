using LightControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.Infra.Data.DAO
{
    
    internal class ElectricityBillDAO
    {
        private string _connectionString = @"Data Source=.\SQLEXPRESS;initial catalog=LIGHTCONTROLDB;uid=sa;pwd=trop";

        internal void InsertBill(ElectricityBill newBill)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    var sql = @"INSERT INTO ELECTRICITY_BILL VALUES (@READ_NUMBER, @READ_DATE, @KW_SPENT,
                                @BILL_VALUE, @PAY_DATE, @AVG_CONSUMPTION, @MONTH, @YEAR);";
                    
                    command.Parameters.AddWithValue("@READ_NUMBER", newBill.ReadNumber);
                    command.Parameters.AddWithValue("@READ_DATE", newBill.ReadDate);
                    command.Parameters.AddWithValue("@KW_SPENT", newBill.KwMonthlySpent);
                    command.Parameters.AddWithValue("@BILL_VALUE",newBill.BillValue);
                    command.Parameters.AddWithValue("@PAY_DATE",newBill.PayDate);
                    command.Parameters.AddWithValue("@AVG_CONSUMPTION", newBill.AvgConsumption);
                    command.Parameters.AddWithValue("@MONTH", newBill.BillingMonth);
                    command.Parameters.AddWithValue("@YEAR",newBill.BillingYear);

                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
            }
        }

        internal List<ElectricityBill> ShowBills()
        {
            var billsList = new List<ElectricityBill>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string sql = @"SELECT * FROM ELECTRICITY_BILL;";
                    command.CommandText = sql;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ElectricityBill searchedBill = new ElectricityBill();

                        searchedBill.ReadNumber = Convert.ToInt32(reader["READ_NUMBER"].ToString());
                        searchedBill.ReadDate = Convert.ToDateTime(reader["READ_DATE"].ToString());
                        searchedBill.KwMonthlySpent = Convert.ToDecimal(reader["KW_MONTHLY_SPENT"].ToString());
                        searchedBill.BillValue = Convert.ToDecimal(reader["BILL_VALUE"].ToString());
                        searchedBill.PayDate = Convert.ToDateTime(reader["PAY_DATE"].ToString());
                        searchedBill.AvgConsumption = Convert.ToDecimal(reader["AVERAGE_CONSUMPTION"].ToString());
                        searchedBill.BillingMonth = Convert.ToInt32(reader["BILLING_MONTH"].ToString());
                        searchedBill.BillingYear = Convert.ToInt32(reader["BILLING_YEAR"].ToString());

                        billsList.Add(searchedBill);

                    }
                }
            }
            return billsList;
        }

        internal ElectricityBill SearchBill(int month, int year)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string sql = @"SELECT * FROM ELECTRICITY_BILL WHERE BILLING_MONTH = @SEARCHED_MONTH AND BILLING_YEAR = @SEARCHED_YEAR;";
                    command.Parameters.AddWithValue("@SEARCHED_MONTH", month);
                    command.Parameters.AddWithValue("@SEARCHED_YEAR", year);

                    command.CommandText = sql;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ElectricityBill searchedBill = new ElectricityBill();

                        searchedBill.ReadNumber = Convert.ToInt32(reader["READ_NUMBER"].ToString());
                        searchedBill.ReadDate = Convert.ToDateTime(reader["READ_DATE"].ToString());
                        searchedBill.KwMonthlySpent = Convert.ToDecimal(reader["KW_MONTHLY_SPENT"].ToString());
                        searchedBill.BillValue = Convert.ToDecimal(reader["BILL_VALUE"].ToString());
                        searchedBill.PayDate = Convert.ToDateTime(reader["PAY_DATE"].ToString());
                        searchedBill.AvgConsumption = Convert.ToDecimal(reader["AVERAGE_CONSUMPTION"].ToString());
                        searchedBill.BillingMonth = Convert.ToInt32(reader["BILLING_MONTH"].ToString());
                        searchedBill.BillingYear = Convert.ToInt32(reader["BILLING_YEAR"].ToString());

                        return searchedBill;

                    }
                }
            }
            return null;
        }

        internal void DeleteBill(ElectricityBill searchedBill)
        {
           
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    var sql = @"DELETE FROM ELECTRICITY_BILL WHERE BILLING_MONTH = @SEARCHED_MONTH AND BILLING_YEAR = @SEARCHED_YEAR;";
                    command.Parameters.AddWithValue("@SEARCHED_MONTH",searchedBill.BillingMonth);
                    command.Parameters.AddWithValue("@SEARCHED_YEAR", searchedBill.BillingYear);
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
