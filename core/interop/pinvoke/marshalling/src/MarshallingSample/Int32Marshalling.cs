using System;
using System.Runtime.InteropServices;

namespace MarshallingSample
{
    class Int32Marshalling
    {
        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByValue_In([In] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByValue_Out([Out] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByValue_InOut([In, Out] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByRef_In([In] ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByRef_Out(out int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByRef_InOut(ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern int Marshal_Int32_Ret(int value);

        public static void Run()
        {
            Console.WriteLine("----- Int32 marshalling samples -----");

            const int initialValue = 7;
            int value;

            Console.WriteLine($"Starting value is always {initialValue}");

            Console.Write("Int32 ByValue In ");
            value = initialValue;
            Marshal_Int32_ByValue_In(value);
            Console.WriteLine();

            Console.Write("Int32 ByValue Out ");
            value = initialValue;
            Marshal_Int32_ByValue_Out(value);
            Console.WriteLine($"out: {value}");

            Console.Write("Int32 ByValue InOut ");
            value = initialValue;
            Marshal_Int32_ByValue_InOut(value);
            Console.WriteLine($" out: {value}");

            Console.Write("Int32 ByRef In ");
            value = initialValue;
            Marshal_Int32_ByRef_In(ref value);
            Console.WriteLine();

            Console.Write("Int32 ByRef Out ");
            value = initialValue;
            Marshal_Int32_ByRef_Out(out value);
            Console.WriteLine($"out: {value}");

            Console.Write("Int32 ByRef InOut "); 
            value = initialValue;
            Marshal_Int32_ByRef_InOut(ref value);
            Console.WriteLine($" out: {value}");

            Console.Write("Int32 Ret ");
            value = initialValue;
            Marshal_Int32_Ret(value);
            Console.WriteLine($" ret: {value}");
        }
    }
}
