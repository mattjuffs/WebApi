using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class MeterReading
    {
        public int MeterReadingID { get; set; }
        public int AccountID { get; set; }
        public DateTime MeterReadingDateTime { get; set; }
        public int MeterReadValue { get; set; }
    }
}
