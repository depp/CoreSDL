# CoreSDL
Efficient, high quality SDL bindings for .Net Core

These bindings are as close as the C version as possible data-wise, but use all the C# conventions for naming. Nothing is marshalled or converted behind your back. However, a Utf8 class is provided to convert byte pointers to and from string as fast as possible. Everything else is completely unmanaged.

In order to take advantage of Pinvoke for speed, you need to define one of the following platforms in your program:
- PLATFORM_WINDOWS
- PLATFORM_LINUX
- PLATFORM_MACOS
