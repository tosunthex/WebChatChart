using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebChatChart.Models;
using MongoDB.Bson;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebChatChart.Controller.API
{
    [Route("api/Metrics")]
    public class MetricsAPIController : Microsoft.AspNetCore.Mvc.Controller
    {
        private MetricsDataAccess objDataAccess;

        public MetricsAPIController()
        {
            objDataAccess = new MetricsDataAccess();
        }

        [HttpGet]
        public IEnumerable<Metrics> Get()
        {
            return objDataAccess.GetMetrics();
        }

        [HttpGet("{id:length(24)}")]
        public IActionResult Get(string id)
        {
            var metric = objDataAccess.GetMetric(new ObjectId(id));
            if (metric == null)
            {
                return NotFound();
            }
            return new ObjectResult(metric);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
