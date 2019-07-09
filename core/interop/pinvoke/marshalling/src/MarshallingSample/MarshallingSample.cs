using System;
using System.Runtime.InteropServices;

namespace MarshallingSample
{
    internal class MarshallingSampleNative { }

    public class MarshallingSample
    {
        [DllImport("MarshallingSampleNative")]
        private static extern int Marshal();

        public static int Main(string[] args)
        {
            Int32Marshalling.Run();

            return 0;
        }
    }
}
