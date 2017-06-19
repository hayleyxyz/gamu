using System;
using System.Runtime.InteropServices;

namespace YuiGameLib {
    internal static unsafe class NativeMethods {

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern int SetDllDirectory(string NewDirectory);

    }
}
