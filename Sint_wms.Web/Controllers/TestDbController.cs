using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sint_wms.Web.Models;

namespace Sint_wms.Web.Controllers
{
    public class TestDbController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var canConnect = await _context.Database.CanConnectAsync();
                if (canConnect)
                {
                    return Content("✅ Kết nối thành công với SQL Server!");
                }
                else
                {
                    return Content("❌ Kết nối thất bại với SQL Server!");
                }
            }
            catch (Exception ex)
            {
                return Content($"❌ Lỗi khi kết nối với SQL Server: {ex.Message}");
            }
        }
    }
}
