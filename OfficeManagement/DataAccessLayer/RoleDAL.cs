using OfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.DataAccessLayer
{
    public class RoleDAL
    {
        public bool Delete(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {

            bool isStatus = false;
            try
            {
                Role role = OfficeManagementDbContext.RoleDbSet.Where(x => x.Id == Id).FirstOrDefault();
                role.IsDeleted = true;
                role.ModifiedBy = 1;
                role.ModifiedDate = DateTime.Now;
                OfficeManagementDbContext.RoleDbSet.Update(role);
                OfficeManagementDbContext.SaveChanges();
                isStatus = true;
            }
            catch (Exception ex)
            {

            }
            return isStatus;
        }

        public IEnumerable<Role> GetAll(OfficeManagementDbContext OfficeManagementDbContext)
        {

            List<Role> listrole = new List<Role>();
            try
            {
                listrole = OfficeManagementDbContext.RoleDbSet.ToList<Role>();
            }
            catch (Exception ex)
            {

            }
            return listrole;
        }

        public Role GetById(int Id, OfficeManagementDbContext OfficeManagementDbContext)
        {
            Role role = new Role();
            try
            {
                role = OfficeManagementDbContext.RoleDbSet.Where(x => x.Id == Id).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return role;
        }

        public bool InsertUpdate(Role role, OfficeManagementDbContext OfficeManagementDbContext)
        {
            bool isStatus = false;
            try
            {
                if (role.Id > 0)
                {
                    Role roletemp = OfficeManagementDbContext.RoleDbSet.Where(x => x.Id == role.Id).FirstOrDefault();
                    if (roletemp != null)
                    {
                        roletemp.Id = role.Id;
                        roletemp.RoleName = role.RoleName;
                        roletemp.IsDeleted = role.IsDeleted;

                        roletemp.ModifiedBy = role.ModifiedBy;
                        roletemp.ModifiedDate = role.ModifiedDate;
                        OfficeManagementDbContext.RoleDbSet.Update(role);
                        OfficeManagementDbContext.SaveChanges();
                    }
                }
                else
                {
                    OfficeManagementDbContext.RoleDbSet.Add(role);
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
