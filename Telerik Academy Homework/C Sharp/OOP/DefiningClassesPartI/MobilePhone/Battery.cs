using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    public class Battery
    {
        private string batteryModel;
        private uint batteryIdle;
        private uint batteryTalk;
        private BatteryType batteryType;

        public Battery()
        {
            this.batteryModel = null;
            this.batteryIdle = 0;
            this.batteryTalk = 0;
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public uint BatteryIdle
        {
            get { return this.batteryIdle; }
            set { this.batteryIdle = value; }
        }

        public uint BatteryTalk
        {
            get { return this.batteryTalk; }
            set { this.batteryTalk = value; }
        }
    }
}
