using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.DataAccessLayer
{
    public class InvoiceItemDAL
    {
        public bool Delete(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                //InvoiceItem invoiceItem = OfficeManagementDbContext.InvoiceItem.Where(x => x.Id == Id).ToList<InvoiceItem>();
                //invoiceItem.IsDeleted = true;
                //invoiceItem.ModifiedBy = 1;
                //invoiceItem.ModifiedDate = DateTime.Now;
                //OfficeManagementDbContext.Cashflow.Update(cashflow);
                //OfficeManagementDbContext.SaveChanges();
                isStatus = true;
            }
            catch (Exception ex)
            {

            }
            return isStatus;

        }

        public IEnumerable<InvoiceItem> GetAll(OfficeManagementDbContext OfficeManagementDbContext)
        {
            List<InvoiceItem> listInvoiceItem = new List<InvoiceItem>();
            try
            {
                listInvoiceItem = OfficeManagementDbContext.InvoiceItemDbSet.ToList<InvoiceItem>();
            }
            catch (Exception ex)
            {

            }
            return listInvoiceItem;
        }

        public InvoiceItem GetById(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            InvoiceItem invoiceItem = new InvoiceItem();
            try
            {
                invoiceItem = OfficeManagementDbContext.InvoiceItemDbSet.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return invoiceItem;
        }

        public bool InsertUpdate(InvoiceItem invoiceItem, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                if (invoiceItem.Id > 0)
                {
                    InvoiceItem invoiceItemtemp = OfficeManagementDbContext.InvoiceItemDbSet.Where(x => x.Id == invoiceItem.Id).FirstOrDefault();
                    if (invoiceItemtemp != null)
                    {
                        invoiceItemtemp.InvoiceId = invoiceItem.InvoiceId;
                        invoiceItemtemp.Quantity = invoiceItem.Quantity;
                        invoiceItemtemp.Rate = invoiceItem.Rate;
                        invoiceItemtemp.Total = invoiceItem.Total;
                        invoiceItemtemp.Description = invoiceItem.Description;
                        OfficeManagementDbContext.InvoiceItemDbSet.Update(invoiceItemtemp);
                        OfficeManagementDbContext.SaveChanges();
                    }
                }
                else
                {
                    OfficeManagementDbContext.InvoiceItemDbSet.Add(invoiceItem);
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
