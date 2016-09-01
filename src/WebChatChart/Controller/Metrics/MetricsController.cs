using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebChatChart.Controller.Metrics
{
    public class MetricsController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: /<controller>/
        [Route("metrics/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
