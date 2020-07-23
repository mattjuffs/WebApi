using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Services
{
    public class MeterReadingService
    {
        private IDbContext _dbContext;

        public MeterReadingService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Entities.MeterReading> GetMeterReadings()
        {
            // using lambda expression
            return _dbContext.Set<Entities.MeterReading>().ToList();
        }

        public void ImportMeterReading(Entities.MeterReading meterReading)
        {
            _dbContext.Set<Entities.MeterReading>().Add(meterReading);
            _dbContext.SaveChanges();
        }
    }
}
