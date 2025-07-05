using Microsoft.EntityFrameworkCore;

namespace ASP.NET_WEB_API_JWT.Data
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        { 
        
        }
    }
}
