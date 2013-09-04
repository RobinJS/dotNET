using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class Call
    {
        private string date;
        private string time;
        private sbyte dialedNumber;
        private uint callDurationSec;

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public sbyte DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public uint CallDurationSec
        {
            get { return this.callDurationSec; }
            set { this.callDurationSec = value; }
        }


    }
}
