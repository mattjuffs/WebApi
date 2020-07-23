using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Data.Interfaces;
using Data.Entities;
using Data.Services;

namespace WebApi.Controllers
{
    [Route("api/meter-reading")]
    [ApiController]
    public class MeterReadingController : ControllerBase
    {
        private readonly IDbContext _dbContext;
        private readonly IAccountService _accountService;
        private readonly IMeterReadingService _meterReadingService;
        public MeterReadingController(IDbContext dbContext, IAccountService accountService, IMeterReadingService meterReadingService)
        {
            _dbContext = dbContext;
            _accountService = accountService;
            _meterReadingService = meterReadingService;
        }

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
            // convert the value into DTO
            var rows = value.Split(Environment.NewLine);

            foreach (var row in rows)
            {
                var csv = row.Split(",");

            }            

            // retrieve all Accounts
            var accounts = _accountService.GetAccounts();

            // TODO: validate that the DTO (Meter Reading) matches an existing Account
            // TODO: check meter reading doesn't already exist
            // TODO: pass valid DTO to EF for inserting into DB - reading must be NNNNN
            // TODO: return number of successful + failed results
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
