﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IMeterReadingService
    {
        List<Entities.MeterReading> GetMeterReadings();
        void ImportMeterReading(Entities.MeterReading meterReading);
    }
}
