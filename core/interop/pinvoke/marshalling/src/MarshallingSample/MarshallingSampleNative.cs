using System.Runtime.InteropServices;

namespace MarshallingSample
{
    internal static class MarshallingSampleNative
    {
        // Int32 marshalling APIs
        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern int AcceptInt32Argument([In] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern int AcceptInt32ByRefArgument([In] ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void GetInt32OutArgument(out int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void ModifyInt32InOutArgument(ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern int ReturnInt32Argument(int value);


        // Boolean marshalling APIs
        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern int AcceptBOOLArgument([In] bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern int AcceptBOOLByRefArgument([In] ref bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void GetBOOLOutArgument(out bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void ModifyBOOLInOutArgument(ref bool value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern bool ReturnBOOLArgument(bool value);
    }
}
