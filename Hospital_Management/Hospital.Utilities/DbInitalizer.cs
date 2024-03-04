using Hospital.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Utilities
{
    public class DbInitalizer : IDbInitializer
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityUser> _roleManager;
        private ApplicationDbContext _context;

        public DbInitalizer(UserManager<IdentityUser> userManager, RoleManager<IdentityUser> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public void Initialize()
        {
            try 
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {

                }
            }
            catch (Exception){
                throw;
            }
        }
    }
}
