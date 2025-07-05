using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_WEB_API_JWT.Data
{
    public class LoginAuthDbContext : IdentityDbContext
    {
        public LoginAuthDbContext(DbContextOptions<LoginAuthDbContext> options) : base(options)
        {
        }

 
    }
}
