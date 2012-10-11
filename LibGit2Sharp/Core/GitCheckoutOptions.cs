using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal class GitCheckoutOptions
    {
        public uint CheckoutStrategy;
        public int DisableFilters;
        public int DirMode;
        public int FileMode;
        public int FileOpenFlags;

        public IntPtr SkippedNotifyCallback;
        public IntPtr NotifyPayload;

        public IntPtr Paths;
    }
}