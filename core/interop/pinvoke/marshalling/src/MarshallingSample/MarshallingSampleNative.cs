using System.Runtime.InteropServices;

namespace MarshallingSample
{
    internal static class MarshallingSampleNative
    {
        // Int32 marshalling APIs
        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int AcceptInt32Argument([In] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int AcceptInt32ByRefArgument([In] ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern void GetInt32OutArgument(out int value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern void ModifyInt32InOutArgument(ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int ReturnInt32Argument(int value);


        // Boolean marshalling APIs
        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int AcceptBOOLArgument([In] bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int AcceptBOOLByRefArgument([In] ref bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern void GetBOOLOutArgument(out bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern void ModifyBOOLInOutArgument(ref bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern bool ReturnBOOLArgument(bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int CountTrueValues(bool value1, [MarshalAs(UnmanagedType.U1)] bool value2, [MarshalAs(UnmanagedType.I1)] bool value3);

        // Marshalling as VariantBool is only supported on Windows
        [DllImport(nameof(MarshallingSampleNative))]
        public static extern int CountTrueValuesWindows(bool value1, [MarshalAs(UnmanagedType.U1)] bool value2, [MarshalAs(UnmanagedType.I1)] bool value3, [MarshalAs(UnmanagedType.VariantBool)] bool value4);
    }
}
