using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/meter-reading")]
    [ApiController]
    public class MeterReadingController : ControllerBase
    {
        // GET: api/<MeterReadingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // TODO: retrieve all MeterReadings
            return new string[] { "value1", "value2" };
        }

        // GET api/<MeterReadingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            // TODO: retrieve all MeterReadings for a given AccountID (id)
            return "value";
        }

        // POST api/<MeterReadingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // TODO: convert the value into DTO
            // TODO: retrieve all Accounts
            // TODO: validate that the DTO (Meter Reading) matches an existing Account
            // TODO: pass DTO to EF for inserting into DB
            // TODO: return number of successful results
        }

        // PUT api/<MeterReadingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MeterReadingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
