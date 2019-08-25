using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.DataAccessLayer
{
    public class CompanyDAL
    {
        public bool Delete(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                Company company = OfficeManagementDbContext.CompanyDbSet.Where(x => x.Id == Id).FirstOrDefault();
                company.IsDeleted = true;
                company.ModifiedBy = 1;
                company.ModifiedDate = DateTime.Now;
                OfficeManagementDbContext.CompanyDbSet.Update(company);
                OfficeManagementDbContext.SaveChanges();
                isStatus = true;
            }
            catch (Exception ex)
            {

            }
            return isStatus;
        }

        public IEnumerable<Company> GetAll(OfficeManagementDbContext OfficeManagementDbContext)
        {
            List<Company> listCompany = new List<Company>();
            try
            {
                listCompany = OfficeManagementDbContext.CompanyDbSet.ToList<Company>();
            }
            catch (Exception ex)
            {

            }
            return listCompany;
        }

        public Company GetById(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            Company company = new Company();
            try
            {
                company = OfficeManagementDbContext.CompanyDbSet.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return company;
        }

        public bool InsertUpdate(Company company, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                if (company.Id > 0)
                {
                    Company companytemp = OfficeManagementDbContext.CompanyDbSet.Where(x => x.Id == company.Id).FirstOrDefault();
                    if (companytemp != null)
                    {
                        companytemp.CompanyName = company.CompanyName;
                        companytemp.Contactnumber = company.Contactnumber;
                        companytemp.IsActive = company.IsActive;
                        companytemp.IsDeleted = company.IsDeleted;
                        companytemp.State = company.State;
                        companytemp.City = company.City;
                        companytemp.ModifiedBy = company.ModifiedBy;
                        companytemp.ModifiedDate = company.ModifiedDate;
                        OfficeManagementDbContext.CompanyDbSet.Update(companytemp);
                        OfficeManagementDbContext.SaveChanges();
                    }
                }
                else
                {
                    OfficeManagementDbContext.CompanyDbSet.Add(company);
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
