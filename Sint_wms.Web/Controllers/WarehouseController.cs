using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Sint_wms.Web.Models;

namespace Sint_wms.Web.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly ILogger<WarehouseController> _logger;

        public WarehouseController(ILogger<WarehouseController> logger)
        {
            _logger = logger;
        }

        public IActionResult Warehouse1()
        {
            using (StreamReader r = new StreamReader("TempData/staff_list.json"))
            {
                string staffJson = r.ReadToEnd();
                List<StaffVM>? staffLst = JsonSerializer.Deserialize<List<StaffVM>>(staffJson);
                return PartialView("_Warehouse1PV", staffLst);
            }
        }

        public IActionResult Warehouse2()
        {
            using (StreamReader r = new StreamReader("TempData/staff_list.json"))
            {
                string staffJson = r.ReadToEnd();
                List<StaffVM>? staffLst = JsonSerializer.Deserialize<List<StaffVM>>(staffJson);
                return PartialView("_Warehouse2PV", staffLst);
            }
        }

        public IActionResult Warehouse3()
        {
            using (StreamReader r = new StreamReader("TempData/staff_list.json"))
            {
                string staffJson = r.ReadToEnd();
                List<StaffVM>? staffLst = JsonSerializer.Deserialize<List<StaffVM>>(staffJson);
                return PartialView("_Warehouse3PV", staffLst);
            }
        }

        public IActionResult SearchStaff(SearchStaffRequestModel req)
        {
            using (StreamReader r = new StreamReader("TempData/staff_list.json"))
            {
                string staffJson = r.ReadToEnd();
                List<StaffVM>? staffLst = JsonSerializer.Deserialize<List<StaffVM>>(staffJson);
                var staff = staffLst.FirstOrDefault(f => f.Name == req.Name);
                return PartialView("_StaffCardPV", staff);
            }
        }
    }
}
