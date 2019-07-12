using System;
using System.Runtime.InteropServices;

namespace MarshallingSample
{
    public class MarshallingSample
    {
        public static int Main(string[] args)
        {
            Int32Marshalling.Run();
            BooleanMarshalling.Run();

            return 0;
        }
    }
}
