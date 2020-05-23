using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Classes
{
    public static class TESTModule
    {
        public static object Module(object testObject)
        {
            switch (testObject)
            {
                case 1:
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3:
                    return tripler(value);
                case float floatValue when floatValue == 1.0f:
                    return leveler(floatValue);
                default:
                    return testObject;
            }


            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;

            // double leveler(double amount) => amount - 0.1f * 10f; - Original line of code.
            // If you do not put the brackets arount the first operation the return value is 0
            double leveler(double amount) => (amount - 0.1f) * 10f;
        }
    }

}
