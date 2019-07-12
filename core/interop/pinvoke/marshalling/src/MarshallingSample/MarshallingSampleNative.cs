using System.Runtime.InteropServices;

namespace MarshallingSample
{
    internal static class MarshallingSampleNative
    {
        // Int32 marshalling APIs
        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void AcceptInt32Argument([In] int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void AcceptInt32ByRefArgument([In] ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void GetInt32OutArgument(out int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern void ModifyInt32InOutArgument(ref int value);

        [DllImport(nameof(MarshallingSampleNative))]
        internal static extern int ReturnInt32Argument(int value);
    }
}
