using System;
using System.Runtime.InteropServices;

namespace MarshallingSample
{
    class Int32Marshalling
    {
        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void PrintInt32Argument([In] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void PrintInt32ByRefArgument([In] ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void GetInt32OutArgument(out int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void ModifyInt32InOutArgument(ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern int ReturnInt32Argument(int value);

        public static void Run()
        {
            Console.WriteLine("----- Int32 marshalling samples -----");

            const int initialValue = 7;
            int value;

            Console.WriteLine($"Starting value is always {initialValue}");

            Console.Write("Pass Int32 argument by value. Argument value: ");
            value = initialValue;
            PrintInt32Argument(value);
            Console.WriteLine();

            Console.Write("Pass Int32 argument by refernece. Argument value: ");
            value = initialValue;
            PrintInt32ByRefArgument(ref value);
            Console.WriteLine();

            Console.Write("Get Int32 out parameter. ");
            value = initialValue;
            GetInt32OutArgument(out value);
            Console.WriteLine($"Value of out parameter: {value}");

            Console.Write("Pass Int32 in-out argument by reference. Argument value: "); 
            value = initialValue;
            ModifyInt32InOutArgument(ref value);
            Console.WriteLine($" Value after call: {value}");

            Console.Write("Return Int32 value. Passed in value: ");
            value = initialValue;
            ReturnInt32Argument(value);
            Console.WriteLine($" Returned value: {value}");
        }
    }
}
