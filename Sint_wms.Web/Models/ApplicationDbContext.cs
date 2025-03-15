using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sint_wms.Web.Models
{
    // Kế thừa từ IdentityDbContext<IdentityUser> thay vì chỉ DbContext
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Định nghĩa các DbSet cho các bảng trong cơ sở dữ liệu
        public DbSet<StaffVM> Staffs { get; set; }

        // Cấu hình Fluent API cho StaffVM nếu cần (nếu StaffVM chưa có khóa chính)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Đảm bảo rằng StaffVM có khóa chính nếu chưa khai báo trong model
            builder.Entity<StaffVM>()
                .HasKey(s => s.Id); // Thay 'Id' bằng thuộc tính khóa chính thực tế trong StaffVM
        }
    }
}
