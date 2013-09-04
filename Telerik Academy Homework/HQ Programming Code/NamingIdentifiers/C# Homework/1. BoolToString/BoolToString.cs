using System;
using System.Collections.Generic;
using System.Text;

namespace _1.BoolToStringRefactoring
{
    class BoolToString
    {
        const int maxCount = 6;

        class BoolToStringInner
        {
            public void ToString(bool variable)
            {
                string variableAsString = variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
        public static void Main()
        {
            BoolToString.BoolToStringInner newVariable = new BoolToString.BoolToStringInner();
            newVariable.ToString(true);
        }
    }
}
