using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.DataAccessLayer
{
    public class UserDAL
    {
        public bool Delete(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool istatus = false;
            try
            {

                var usertemptemp = OfficeManagementDbContext.UserDbSet.Where(x => x.Id == Id).FirstOrDefault();

                if (usertemptemp != null)
                {
                    usertemptemp.IsDeleted = true;
                    usertemptemp.ModifiedBy = 1;
                    usertemptemp.ModifiedDate = DateTime.Now;
                    OfficeManagementDbContext.UserDbSet.Update(usertemptemp);
                    OfficeManagementDbContext.SaveChanges();
                    istatus = true;
                }
            }
            catch
            {

            }
            return istatus;
        }

        public IEnumerable<User> GetAll(OfficeManagementDbContext OfficeManagementDbContext)
        {
            List<User> listUserTable = new List<User>();
            try
            {
                listUserTable = OfficeManagementDbContext.UserDbSet.ToList<User>();
            }
            catch (Exception ex)
            {
            }
            return listUserTable;
        }

        public User GetById(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            User usertable = new User();
            try
            {
                usertable = OfficeManagementDbContext.UserDbSet.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
            }
            return usertable;
        }

        public bool InsertUpdate(User userTable, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool istatus = false;
            try
            {
                if (userTable.Id > 0)
                {
                    User usertemptemp = OfficeManagementDbContext.UserDbSet.Where(x => x.Id == userTable.Id).FirstOrDefault();

                    if (usertemptemp != null)
                    {
                        usertemptemp.Firstname = userTable.Firstname;
                        usertemptemp.Lastname = userTable.Lastname;
                        usertemptemp.Emailid = userTable.Emailid;
                        usertemptemp.Contactnumber = userTable.Contactnumber;
                        usertemptemp.IsActive = userTable.IsActive;
                        usertemptemp.IsDeleted = userTable.IsDeleted;
                        usertemptemp.Password = userTable.Password;
                        usertemptemp.ModifiedBy = userTable.ModifiedBy;
                        usertemptemp.ModifiedDate = userTable.ModifiedDate;
                        OfficeManagementDbContext.UserDbSet.Update(usertemptemp);
                        OfficeManagementDbContext.SaveChanges();
                        // istatus = true;
                    }
                }
                else
                {
                    //Usertable usertemptemp = null;

                    //usertemptemp.Firstname = userTable.Firstname;
                    //usertemptemp.Lastname = userTable.Lastname;
                    //usertemptemp.Emailid = userTable.Emailid;
                    //usertemptemp.Contactnumber = userTable.Contactnumber;
                    //usertemptemp.IsActive = userTable.IsActive;
                    //usertemptemp.IsDeleted = userTable.IsDeleted;
                    //usertemptemp.Password = userTable.Password;
                    //usertemptemp.ModifiedBy = 1;
                    //usertemptemp.ModifiedDate = userTable.ModifiedDate;
                    OfficeManagementDbContext.UserDbSet.Add(userTable);
                    OfficeManagementDbContext.SaveChanges();

                }
                istatus = true;
            }
            catch
            {

            }
            return istatus;

        }
    }
}
