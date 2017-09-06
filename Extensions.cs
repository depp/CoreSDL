using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SDL2
{
    public static unsafe class Extensions
    {
        [Conditional("DEBUG"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckError(this bool value)
        {
            Debug.Assert(value, Utf8.ToString(SDL.GetError()));
        }

        [Conditional("DEBUG"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckError(this int value)
        {
            Debug.Assert(value == 0, Utf8.ToString(SDL.GetError()));
        }

        [Conditional("DEBUG"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckError(this IntPtr value)
        {
            Debug.Assert(value != IntPtr.Zero, Utf8.ToString(SDL.GetError()));
        }

        [Conditional("DEBUG"), MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckError(this SDL.Window value)
        {
            Debug.Assert(value != IntPtr.Zero, Utf8.ToString(SDL.GetError()));
        }
    }
}