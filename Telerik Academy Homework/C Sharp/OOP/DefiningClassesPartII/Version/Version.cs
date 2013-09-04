using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Version
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class VersionAttribute: System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }

    [VersionAttribute(1, 0)]

    class Version
    {
        static void Main()
        {
            Type type = typeof(VersionAttribute);

            object allAttributes = type.GetCustomAttributes(false);

            Console.WriteLine("This is version {0}.{1}", VersionAttribute.Major, VersionAttribute.Minor);

        }
    }


}
