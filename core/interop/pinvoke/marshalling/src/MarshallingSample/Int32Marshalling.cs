using System;
using System.Runtime.InteropServices;

namespace MarshallingSample
{
    class Int32Marshalling
    {
        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByValIn([In] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByValOut([Out] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByValInOut([In, Out] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByRefIn([In] ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByRefOut(out int value);

        [DllImport(nameof(MarshallingSampleNative))]
        private static extern void Marshal_Int32_ByRefInOut(ref int value);

        public static void Run()
        {
            Console.WriteLine("----- Int32 marshalling samples -----");

            int value;

            Console.Write("Int32_ByValIn in: ");
            value = 7;
            Marshal_Int32_ByValIn(value);
            Console.WriteLine();

            Console.Write("Int32_ByValOut ");
            value = 7;
            Marshal_Int32_ByValOut(value);
            Console.WriteLine($"out: {value}");

            Console.Write("Int32_ByValInOut in: ");
            value = 7;
            Marshal_Int32_ByValInOut(value);
            Console.WriteLine($" out: {value}");

            Console.Write("Int32_ByRefIn in: ");
            value = 7;
            Marshal_Int32_ByRefIn(ref value);
            Console.WriteLine();

            Console.Write("Int32_ByRefOut ");
            value = 7;
            Marshal_Int32_ByRefOut(out value);
            Console.WriteLine($"out: {value}");

            Console.Write("Int32_ByRefInOut in: ");
            value = 7;
            Marshal_Int32_ByRefInOut(ref value);
            Console.WriteLine($" out: {value}");
        }
    }
}
