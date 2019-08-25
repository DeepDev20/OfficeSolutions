using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.DataAccessLayer
{
    public class InvoiceDAL
    {
        public bool Delete(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                Invoice invoice = OfficeManagementDbContext.InvoiceDbSet.Where(x => x.Id == Id).FirstOrDefault();
                invoice.IsDeleted = true;
                invoice.ModifiedBy = 1;
                invoice.ModifiedDate = DateTime.Now;
                OfficeManagementDbContext.InvoiceDbSet.Update(invoice);
                OfficeManagementDbContext.SaveChanges();
                isStatus = true;
            }
            catch (Exception ex)
            {

            }
            return isStatus;
        }

        public IEnumerable<Invoice> GetAll(OfficeManagementDbContext OfficeManagementDbContext)
        {
            List<Invoice> listInvoice = new List<Invoice>();
            try
            {
                listInvoice = OfficeManagementDbContext.InvoiceDbSet.ToList<Invoice>();
            }
            catch (Exception ex)
            {

            }
            return listInvoice;
        }

        public Invoice GetById(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            Invoice invoice = new Invoice();
            try
            {
                invoice = OfficeManagementDbContext.InvoiceDbSet.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return invoice;
        }

        public bool InsertUpdate(Invoice invoice, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                if (invoice.Id > 0)
                {
                    Invoice invoicetemp = OfficeManagementDbContext.InvoiceDbSet.Where(x => x.Id == invoice.Id).FirstOrDefault();
                    if (invoicetemp != null)
                    {
                        invoicetemp.Fromcompanyid = invoice.Fromcompanyid;
                        invoicetemp.Tocompanyid = invoice.Tocompanyid;
                        invoicetemp.IsActive = invoice.IsActive;
                        invoicetemp.IsDeleted = invoice.IsDeleted;
                        invoicetemp.Tax = invoice.Tax;
                        invoicetemp.Total = invoice.Total;
                        invoicetemp.ModifiedBy = invoice.ModifiedBy;
                        invoicetemp.ModifiedDate = invoice.ModifiedDate;
                        OfficeManagementDbContext.InvoiceDbSet.Update(invoicetemp);
                        OfficeManagementDbContext.SaveChanges();
                    }
                }
                else
                {
                    OfficeManagementDbContext.InvoiceDbSet.Add(invoice);
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
