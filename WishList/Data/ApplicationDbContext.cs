using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(ApplicationDbContext options) : base(options)
        {
        }
    }
}
