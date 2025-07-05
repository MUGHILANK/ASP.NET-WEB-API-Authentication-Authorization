using Microsoft.EntityFrameworkCore;

namespace ASP.NET_WEB_API_JWT.Data
{
    public class LoginDbcontext : DbContext
    {
        public LoginDbcontext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        { 
        
        }
                    
        
    }
}
