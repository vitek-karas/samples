using System;
using System.Runtime.InteropServices;

namespace MarshallingSample
{
    public class MarshallingSample
    {
        [DllImport("MarshallingSampleNative")]
        private static extern int Marshal();

        public static int Main(string[] args)
        {
            Console.WriteLine(Marshal());
            return 0;
        }
    }
}