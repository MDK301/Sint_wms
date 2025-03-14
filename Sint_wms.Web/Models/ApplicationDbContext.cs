using Microsoft.EntityFrameworkCore;

namespace Sint_wms.Web.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Định nghĩa các DbSet cho các bảng trong cơ sở dữ liệu
        public DbSet<StaffVM> Staffs { get; set; }
    }
}
