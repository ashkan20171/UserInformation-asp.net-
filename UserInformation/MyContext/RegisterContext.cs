using Microsoft.EntityFrameworkCore;
using UserInformation.Identity.MyUsers;

namespace UserInformation.MyContext
{
    public class RegisterContext : DbContext
    {
        public RegisterContext(DbContextOptions<RegisterContext> options) : base(options)
        {
        }

        #region Users

        public DbSet<Users> Users { get; set; }

        #endregion Users
    }
}