using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.DataAccessLayer
{
    public class CashFlowDAL
    {
        public bool Delete(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                Cashflow cashflow = OfficeManagementDbContext.CashflowDbSet.Where(x => x.Id == Id).FirstOrDefault();
                cashflow.IsDeleted = true;
                cashflow.ModifiedBy = 1;
                cashflow.ModifiedDate = DateTime.Now;
                OfficeManagementDbContext.CashflowDbSet.Update(cashflow);
                OfficeManagementDbContext.SaveChanges();
                isStatus = true;
            }
            catch (Exception ex)
            {

            }
            return isStatus;
        }

        public IEnumerable<Cashflow> GetAll(OfficeManagementDbContext OfficeManagementDbContext)
        {
            List<Cashflow> listCashflow = new List<Cashflow>();
            try
            {
                listCashflow = OfficeManagementDbContext.CashflowDbSet.ToList<Cashflow>().ToList<Cashflow>();
            }
            catch (Exception ex)
            {

            }
            return listCashflow;
        }

        public Cashflow GetById(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            Cashflow cashflow = new Cashflow();
            try
            {
                cashflow = OfficeManagementDbContext.CashflowDbSet.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return cashflow;
        }

        public bool InsertUpdate(Cashflow cashflow, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                if (cashflow.Id > 0)
                {
                    Cashflow cashflowtemp = OfficeManagementDbContext.CashflowDbSet.Where(x => x.Id == cashflow.Id).FirstOrDefault();
                    if (cashflowtemp != null)
                    {
                        cashflowtemp.Direction = cashflow.Direction;
                        cashflowtemp.Description = cashflow.Description;
                        cashflowtemp.Amount = cashflow.Amount;
                        cashflowtemp.IsActive = cashflow.IsActive;
                        cashflowtemp.IsDeleted = cashflow.IsDeleted;
                        cashflowtemp.Loggeddatetime = cashflow.Loggeddatetime;
                        cashflowtemp.ModifiedBy = cashflow.ModifiedBy;
                        cashflowtemp.ModifiedDate = cashflow.ModifiedDate;
                        OfficeManagementDbContext.CashflowDbSet.Update(cashflowtemp);
                        OfficeManagementDbContext.SaveChanges();
                    }
                }
                else
                {
                    OfficeManagementDbContext.CashflowDbSet.Add(cashflow);
                    OfficeManagementDbContext.SaveChanges();
                }
                isStatus = true;
            }
            catch (Exception ex)
            {

            }
            return isStatus;
        }

    }
}
