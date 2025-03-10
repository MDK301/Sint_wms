using Microsoft.AspNetCore.Mvc;
using Sint_wms.Web.Models;
using System.Text.Json;

namespace Sint_wms.Web.Controllers
{
    public class InboundController : Controller
    {
        private readonly ILogger<InboundController> _logger;

        public InboundController(ILogger<InboundController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            using (StreamReader r = new StreamReader("TempData/staff_list.json"))
            {
                string staffJson = r.ReadToEnd();
                List<StaffVM>? staffLst = JsonSerializer.Deserialize<List<StaffVM>>(staffJson);
                return PartialView("_Inbound", staffLst);
            }
        }
    }
}
