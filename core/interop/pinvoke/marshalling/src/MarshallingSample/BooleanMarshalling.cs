using System;

namespace MarshallingSample
{
    class BooleanMarshalling
    {
        public static void Run()
        {
            Console.WriteLine("----- Boolean marshalling as BOOL samples -----");

            const bool initialValue = true;
            bool value;

            // Pass boolean by value and masrshal it as "Windows" BOOL - which is 32bit int.
            value = initialValue;
            MarshallingSampleNative.AcceptBOOLArgument(value);  // returns 1
            MarshallingSampleNative.AcceptBOOLArgument(false);  // returns 0

            // Pass boolean by reference
            value = initialValue;
            MarshallingSampleNative.AcceptBOOLByRefArgument(ref value);

            // Get boolean out parameter
            MarshallingSampleNative.GetBOOLOutArgument(out value); // sets value to false

            // Pass boolean in-out argument by reference.
            value = initialValue;
            MarshallingSampleNative.ModifyBOOLInOutArgument(ref value); // sets value to false

            // Return boolean value.
            value = MarshallingSampleNative.ReturnBOOLArgument(value);
        }
    }
}
