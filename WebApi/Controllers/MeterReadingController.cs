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
        public JsonResult Post([FromBody] string value)
        {
            int successful = 0;
            int failed = 0;
            var meterReadings = new List<Data.Entities.MeterReading>();

            // convert the value into DTO
            var rows = value.Split(Environment.NewLine);

            foreach (var row in rows)
            {
                var csv = row.Split(",");

                if (csv.Count() < 3)// we need to have at least 3 columns in the CSV
                {
                    // TODO: log the failure
                    failed++;
                }
                else
                {
                    try
                    {
                        var meterReading = new Data.Entities.MeterReading
                        {
                            AccountID = Convert.ToInt32(csv[0]),
                            MeterReadingDateTime = Convert.ToDateTime(csv[1]),
                            MeterReadValue = Convert.ToInt32(csv[2]),
                        };

                        meterReadings.Add(meterReading);
                    }
                    catch
                    {
                        // TODO: log the failure
                        failed++;
                    }
                }
            }

            // retrieve all Accounts
            var accounts = _accountService.GetAccounts();

            var validMeterReadings = new List<Data.Entities.MeterReading>();

            // validate that the DTO (Meter Reading) matches an existing Account
            foreach (var meterReading in meterReadings)
            {
                var account = accounts.Where(a => a.AccountID == meterReading.AccountID).FirstOrDefault();
                if (account == null)
                {
                    failed++;
                }
                else
                {
                    validMeterReadings.Add(meterReading);
                    successful++;
                }
            }

            // check meter reading doesn't already exist
            var existingMeterReadings = _meterReadingService.GetMeterReadings();

            foreach (var meterReading in validMeterReadings)
            {
                var existingMeterReading = existingMeterReadings.Where(mr =>
                    mr.AccountID == meterReading.AccountID
                    && mr.MeterReadingDateTime == meterReading.MeterReadingDateTime
                ).FirstOrDefault();

                if (existingMeterReading != null)
                {
                    // the meter reading is valid, but we've already captured it
                    failed++;
                    successful--;
                }
                else
                {
                    // pass valid DTO to EF for inserting into DB - reading must be NNNNN
                    _meterReadingService.ImportMeterReading(meterReading);
                }
            }
            
            // return number of successful + failed results
            var response = new
            {
                Successful = successful,
                Failed = failed,
            };

            return new JsonResult(response);
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
