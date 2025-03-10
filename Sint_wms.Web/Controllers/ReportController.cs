using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Sint_wms.Web.Models;

namespace Sint_wms.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly ILogger<ReportController> _logger;

        public ReportController(ILogger<ReportController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index(string id)
        {
            using (StreamReader r = new StreamReader("TempData/staff_list.json"))
            {
                string staffJson = r.ReadToEnd();
                List<StaffVM>? staffLst = JsonSerializer.Deserialize<List<StaffVM>>(staffJson);
                return PartialView("_ReportPV", staffLst);
            }
        }
    }
}
