using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class Display
    {
        private uint displaySize;
        private uint displayColors;

        public Display()
        {
            this.displaySize = 0;
            this.displayColors = 0;
        }

        public uint DisplaySize
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }

        public uint DisplayColors
        {
            get { return this.displayColors; }
            set { this.displayColors = value; }
        }
    }
}
