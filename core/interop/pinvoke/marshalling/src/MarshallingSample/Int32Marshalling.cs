using System;

namespace MarshallingSample
{
    class Int32Marshalling
    {
        public static void Run()
        {
            Console.WriteLine("----- Int32 marshalling samples -----");

            // Always start with the same value.
            const int initialValue = 7;
            int value;

            // Pass Int32 argument by value.
            value = initialValue;
            MarshallingSampleNative.AcceptInt32Argument(value);

            // Pass Int32 argument by refernece.
            value = initialValue;
            MarshallingSampleNative.AcceptInt32ByRefArgument(ref value);

            // Get Int32 out parameter.
            MarshallingSampleNative.GetInt32OutArgument(out value);

            // Pass Int32 in-out argument by reference.
            value = initialValue;
            MarshallingSampleNative.ModifyInt32InOutArgument(ref value);

            // Return Int32 value.
            value = MarshallingSampleNative.ReturnInt32Argument(initialValue);
        }
    }
}
