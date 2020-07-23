using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    interface IMeterReading
    {
        List<Entities.MeterReading> GetMeterReadings();
        void ImportMeterReading(Entities.MeterReading meterReading);
    }
}
