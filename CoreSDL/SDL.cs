﻿using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace SDL2
{
    [SuppressUnmanagedCodeSecurity]
    public static unsafe partial class SDL
    {
        public static class Hints
        {
            public const string FrameBufferAcceleration = "FRAMEBUFFER_ACCELERATION";
            public const string RenderDriver = "RENDER_DRIVER";
            public const string RenderOpenglShaders = "RENDER_OPENGL_SHADERS";
            public const string RenderDirect3DThreadsafe = "RENDER_DIRECT3D_THREADSAFE";
            public const string RenderDirect3D11Debug = "RENDER_DIRECT3D11_DEBUG";
            public const string RenderScaleQuality = "RENDER_SCALE_QUALITY";
            public const string RenderVsync = "RENDER_VSYNC";
            public const string VideoAllowScreensave = "VIDEO_ALLOW_SCREENSAVER";
            public const string VideoX11XvidMode = "VIDEO_X11_XVIDMODE";
            public const string VideoX11Xinerama = "VIDEO_X11_XINERAMA";
            public const string VideoX11XRandR = "VIDEO_X11_XRANDR";
            public const string VideoX11NetWMPing = "VIDEO_X11_NET_WM_PING";
            public const string WindowFrameUsableWhileCursorHidden = "WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN";
            public const string WindowsEnableMessageLoop = "WINDOWS_ENABLE_MESSAGELOOP";
            public const string GrabKeyboard = "GRAB_KEYBOARD";
            public const string MouseRelativeModeWarp = "MOUSE_RELATIVE_MODE_WARP";
            public const string MouseFocusClickThrough = "MOUSE_FOCUS_CLICKTHROUGH";
            public const string VideoMinimizeOnFocusLoss = "VIDEO_MINIMIZE_ON_FOCUS_LOSS";
            public const string IdleTimerDisabled = "IOS_IDLE_TIMER_DISABLED";
            public const string Orientations = "IOS_ORIENTATIONS";
            public const string AppleTVControllerUIEvents = "APPLE_TV_CONTROLLER_UI_EVENTS";
            public const string AppleTVRemoteAllowRotation = "APPLE_TV_REMOTE_ALLOW_ROTATION";
            public const string AccelerometerAsJoystick = "ACCELEROMETER_AS_JOYSTICK";
            public const string XInputEnabled = "XINPUT_ENABLED";
            public const string XInputUseOldJoystickMapping = "XINPUT_USE_OLD_JOYSTICK_MAPPING";
            public const string GameControllerConfig = "GAMECONTROLLERCONFIG";
            public const string JoystickAllowBackgroundEvents = "JOYSTICK_ALLOW_BACKGROUND_EVENTS";
            public const string AllowTopmost = "ALLOW_TOPMOST";
            public const string TimerResolution = "TIMER_RESOLUTION";
            public const string ThreadStackSize = "THREAD_STACK_SIZE";
            public const string VideoHighDPIDisabled = "VIDEO_HIGHDPI_DISABLED";
            public const string MacCtrlClickEmulateRightClick = "MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK";
            public const string VideoWinD3DCompiler = "VIDEO_WIN_D3DCOMPILER";
            public const string VideoWindowSharePixelFormat = "VIDEO_WINDOW_SHARE_PIXEL_FORMAT";
            public const string WinRTPrivacyPolicyURL = "WINRT_PRIVACY_POLICY_URL";
            public const string WinRTPrivacyPolicyLabel = "WINRT_PRIVACY_POLICY_LABEL";
            public const string WinRTHandleBackButton = "WINRT_HANDLE_BACK_BUTTON";
            public const string VideoMacFullscreenSpaces = "VIDEO_MAC_FULLSCREEN_SPACES";
            public const string MacBackgroundApp = "MAC_BACKGROUND_APP";
            public const string AndroidAPKExpansionMainFileVersion = "ANDROID_APK_EXPANSION_MAIN_FILE_VERSION";
            public const string AndroidAPKExpansionPatchFileVersion = "ANDROID_APK_EXPANSION_PATCH_FILE_VERSION";
            public const string IMEInternalEditing = "IME_INTERNAL_EDITING";
            public const string AndroidSeparateMouseAndTouch = "ANDROID_SEPARATE_MOUSE_AND_TOUCH";
            public const string EmscriptenKeyboardElement = "EMSCRIPTEN_KEYBOARD_ELEMENT";
            public const string NoSignalHandlers = "NO_SIGNAL_HANDLERS";
            public const string WindowsNoCloseOnAltF4 = "WINDOWS_NO_CLOSE_ON_ALT_F4";
            public const string BMPSaveLegacyFormat = "BMP_SAVE_LEGACY_FORMAT";
            public const string WindowsDisableThreadWarning = "WINDOWS_DISABLE_THREAD_NAMING";
            public const string RPIVideoLayer = "RPI_VIDEO_LAYER";
        }

        public static class PixelFormats
        {
            public static readonly uint Unknown = 0;
            public static readonly uint Index1LSB = DefinePixelFormat(PixelType.Index1, PixelOrder.Bitmap4321, 0, 1, 0);
            public static readonly uint Index1MSB = DefinePixelFormat(PixelType.Index1, PixelOrder.Bitmap1234, 0, 1, 0);
            public static readonly uint Index4LSB = DefinePixelFormat(PixelType.Index4, PixelOrder.Bitmap4321, 0, 4, 0);
            public static readonly uint Index4MSB = DefinePixelFormat(PixelType.Index4, PixelOrder.Bitmap1234, 0, 4, 0);
            public static readonly uint Index8 = DefinePixelFormat(PixelType.Index8, 0, 0, 8, 1);
            public static readonly uint RGB332 = DefinePixelFormat(PixelType.Packed8, PixelOrder.PackedXRGB, PackedLayout.Layout332, 8, 1);
            public static readonly uint RGB444 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedXRGB, PackedLayout.Layout4444, 12, 2);
            public static readonly uint RGB555 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedXRGB, PackedLayout.Layout1555, 15, 2);
            public static readonly uint BGR555 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedXBGR, PackedLayout.Layout1555, 15, 2);
            public static readonly uint ARGB4444 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedARGB, PackedLayout.Layout4444, 16, 2);
            public static readonly uint RGBA4444 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedRGBA, PackedLayout.Layout4444, 16, 2);
            public static readonly uint ABGR4444 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedABGR, PackedLayout.Layout4444, 16, 2);
            public static readonly uint BGRA4444 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedBGRA, PackedLayout.Layout4444, 16, 2);
            public static readonly uint ARGB1555 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedARGB, PackedLayout.Layout1555, 16, 2);
            public static readonly uint RGBA5551 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedRGBA, PackedLayout.Layout5551, 16, 2);
            public static readonly uint ABGR1555 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedABGR, PackedLayout.Layout1555, 16, 2);
            public static readonly uint BGRA5551 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedBGRA, PackedLayout.Layout5551, 16, 2);
            public static readonly uint RGB565 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedXRGB, PackedLayout.Layout565, 16, 2);
            public static readonly uint BGR565 = DefinePixelFormat(PixelType.Packed16, PixelOrder.PackedXBGR, PackedLayout.Layout565, 16, 2);
            public static readonly uint RGB24 = DefinePixelFormat(PixelType.ArrayU8, PixelOrder.ArrayRGB, 0, 24, 3);
            public static readonly uint BGR24 = DefinePixelFormat(PixelType.ArrayU8, PixelOrder.ArrayBGR, 0, 24, 3);
            public static readonly uint RGB888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedXRGB, PackedLayout.Layout8888, 24, 4);
            public static readonly uint RGBX8888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedRGBX, PackedLayout.Layout8888, 24, 4);
            public static readonly uint BGR888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedXBGR, PackedLayout.Layout8888, 24, 4);
            public static readonly uint BGRX8888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedBGRX, PackedLayout.Layout8888, 24, 4);
            public static readonly uint ARGB8888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedARGB, PackedLayout.Layout8888, 32, 4);
            public static readonly uint RGBA8888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedARGB, PackedLayout.Layout8888, 32, 4);
            public static readonly uint ABGR8888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedABGR, PackedLayout.Layout8888, 32, 4);
            public static readonly uint BGRA8888 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedBGRA, PackedLayout.Layout8888, 32, 4);
            public static readonly uint ARGB2101010 = DefinePixelFormat(PixelType.Packed32, PixelOrder.PackedARGB, 0, 32, 4);
            public static readonly uint YV12 = FourCharacterCode((byte)'Y', (byte)'V', (byte)'1', (byte)'2');
            public static readonly uint IYUV = FourCharacterCode((byte)'I', (byte)'Y', (byte)'U', (byte)'V');
            public static readonly uint YUY2 = FourCharacterCode((byte)'Y', (byte)'U', (byte)'Y', (byte)'2');
            public static readonly uint UYVY = FourCharacterCode((byte)'U', (byte)'Y', (byte)'V', (byte)'Y');
            public static readonly uint YVYU = FourCharacterCode((byte)'Y', (byte)'V', (byte)'Y', (byte)'U');
            public static readonly uint NV12 = FourCharacterCode((byte)'N', (byte)'V', (byte)'1', (byte)'2');
            public static readonly uint NV21 = FourCharacterCode((byte)'N', (byte)'V', (byte)'2', (byte)'1');

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint FourCharacterCode(byte a, byte b, byte c, byte d)
            {
                return (uint)(a | (b << 8) | (c << 16) | (d << 24));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint DefinePixelFormat(PixelType type, PixelOrder order, PackedLayout layout, byte bits, byte bytes)
            {
                return (uint)((1 << 28) | ((byte)type << 24) | ((byte)order << 20) | ((byte)layout << 16) | (bits << 8) | bytes);
            }
        }
        
        //
        // SDL.h
        //
        [Flags]
        public enum InitFlags : uint
        {
            Timer = 0x00000001,
            Audio = 0x00000010,
            Video = 0x00000020,
            Joystick = 0x00000200,
            Haptic = 0x00001000,
            GameController = 0x00002000,
            Events = 0x00004000,
            NoParachute = 0x00100000,
            Everything = Timer | Audio | Video | Joystick | Haptic | GameController | Events
        }

        [DllImport("SDL2", EntryPoint = "SDL_Init")]
        public static extern int Init(InitFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_InitSubSystem")]
        public static extern int InitSubSystem(InitFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_QuitSubSystem")]
        public static extern void QuitSubSystem(InitFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_WasInit")]
        public static extern InitFlags WasInit(InitFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_Quit")]
        public static extern void Quit();

        //
        // SDL_audio.h
        //
        public const int AudioCVTMaxFilters = 9;
        public const int MixMaxVolume = 128;

        public delegate void AudioCallback(void* userData, byte* stream, int length);
        public delegate void AudioFilter(ref AudioCVT cvt, AudioFormat format);

        [Flags]
        public enum AudioFormat : ushort
        {
            U8 = 0x0008,
            S8 = 0x8008,
            U16LSB = 0x0010,
            S16LSB = 0x8010,
            U16MSB = 0x1010,
            S16MSB = 0x9010,
            U16 = U16LSB,
            S16 = S16LSB,

            S32LSB = 0x8020,
            S32MSB = 0x9020,
            S32 = S32LSB,

            F32LSB = 0x8120,
            F32MSB = 0x9120,
            F32 = F32LSB
        }

        [Flags]
        public enum AudioAllowChangeFlags
        {
            Frequency = 1 << 0,
            Format = 1 << 1,
            Channels = 1 << 2,
            Any = Frequency | Format | Channels
        }

        public enum AudioStatus
        {
            Stopped = 0,
            Playing,
            Paused
        }

        public struct AudioDeviceID
        {
            public uint Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct AudioSpec
        {
            public int Frequency;
            public AudioFormat Format;
            public byte Channels;
            public byte Silence;
            public ushort Samples;
            public ushort Padding;
            public uint Size;
            public IntPtr Callback;
            public IntPtr UserData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct AudioCVT
        {
            public int Needed;
            public AudioFormat SrcFormat;
            public AudioFormat DstFormat;
            public double RateIncrement;
            public byte* Buffer;
            public int Length;
            public int LengthCVT;
            public int LengthMultiplier;
            public double LengthRatio;
            public IntPtr* Filters;
            public int FilterIndex;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetNumAudioDrivers")]
        public static extern int GetNumAudioDrivers();
        [DllImport("SDL2", EntryPoint = "SDL_GetAudioDriver")]
        public static extern byte* GetAudioDriver(int index);
        [DllImport("SDL2", EntryPoint = "SDL_AudioInit")]
        public static extern int AudioInit(byte* driverName);
        [DllImport("SDL2", EntryPoint = "SDL_AudioQuit")]
        public static extern void AudioQuit();
        [DllImport("SDL2", EntryPoint = "SDL_GetCurrentAudioDriver")]
        public static extern byte* GetCurrentAudioDriver();
        [DllImport("SDL2", EntryPoint = "SDL_OpenAudio")]
        public static extern int OpenAudio(ref AudioSpec desired, out AudioSpec obtained);
        [DllImport("SDL2", EntryPoint = "SDL_GetNumAudioDevices")]
        public static extern int GetNumAudioDevices(int isCapture);
        [DllImport("SDL2", EntryPoint = "SDL_GetAudioDeviceName")]
        public static extern byte* GetAudioDeviceName(int index, int isCapture);
        [DllImport("SDL2", EntryPoint = "SDL_OpenAudioDevice")]
        public static extern AudioDeviceID OpenAudioDevice(byte* device, int isCapture, ref AudioSpec desired, out AudioSpec obtained, AudioAllowChangeFlags allowedChanges);
        [DllImport("SDL2", EntryPoint = "SDL_GetAudioStatus")]
        public static extern AudioStatus GetAudioStatus();
        [DllImport("SDL2", EntryPoint = "SDL_GetAudioDeviceStatus")]
        public static extern AudioStatus GetAudioDeviceStatus(AudioDeviceID device);
        [DllImport("SDL2", EntryPoint = "SDL_PauseAudio")]
        public static extern void PauseAudio(int pauseOn);
        [DllImport("SDL2", EntryPoint = "SDL_PauseAudioDevice")]
        public static extern void PauseAudioDevice(AudioDeviceID device, int pauseOn);
        [DllImport("SDL2", EntryPoint = "SDL_LoadWAV_RW")]
        public static extern AudioSpec* LoadWavRW(RWops src, int freeSrc, out AudioSpec spec, out byte* audioBuffer, out uint audioLength);

        public static AudioSpec* LoadWav(byte* file, out AudioSpec spec, out byte* audioBuffer, out uint audioLength)
        {
            byte* rb = Utf8.AllocateFromString("rb");
            AudioSpec* result = LoadWavRW(RWFromFile(file, rb), 1, out spec, out audioBuffer, out audioLength);
            Utf8.Free(rb);
            return result;
        }

        [DllImport("SDL2", EntryPoint = "SDL_FreeWAV")]
        public static extern void FreeWav(byte* audioBuffer);
        [DllImport("SDL2", EntryPoint = "SDL_BuildAudioCVT")]
        public static extern int BuildAudioCVT(AudioCVT* cvt, AudioFormat srcFormat, byte srcChannels, int srcRate, AudioFormat dstFormat, byte dstChannels, int dstRate);
        [DllImport("SDL2", EntryPoint = "SDL_ConvertAudio")]
        public static extern int ConvertAudio(AudioCVT* cvt);
        [DllImport("SDL2", EntryPoint = "SDL_MixAudio")]
        public static extern void MixAudio(byte* dst, byte* src, uint length, int volume);
        [DllImport("SDL2", EntryPoint = "SDL_MixAudioFormat")]
        public static extern void MixAudioFormat(byte* dst, byte* src, AudioFormat format, uint length, int volume);
        [DllImport("SDL2", EntryPoint = "SDL_QueueAudio")]
        public static extern int QueueAudio(AudioDeviceID device, void* data, uint length);
        [DllImport("SDL2", EntryPoint = "SDL_DequeueAudio")]
        public static extern uint DequeueAudio(AudioDeviceID device, void* data, uint length);
        [DllImport("SDL2", EntryPoint = "SDL_GetQueuedAudioSize")]
        public static extern uint GetQueueAudioSize(AudioDeviceID device);
        [DllImport("SDL2", EntryPoint = "SDL_ClearQueuedAudio")]
        public static extern void ClearQueuedAudio(AudioDeviceID device);
        [DllImport("SDL2", EntryPoint = "SDL_LockAudio")]
        public static extern void LockAudio();
        [DllImport("SDL2", EntryPoint = "SDL_LockAudioDevice")]
        public static extern void LockAudioDevice(AudioDeviceID device);
        [DllImport("SDL2", EntryPoint = "SDL_UnlockAudio")]
        public static extern void UnlockAudio();
        [DllImport("SDL2", EntryPoint = "SDL_UnlockAudioDevice")]
        public static extern void UnlockAudioDevice(AudioDeviceID device);
        [DllImport("SDL2", EntryPoint = "SDL_CloseAudio")]
        public static extern void CloseAudio();
        [DllImport("SDL2", EntryPoint = "SDL_CloseAudioDevice")]
        public static extern void CloseAudioDevice(AudioDeviceID device);

        //
        // SDL_blendmode.h
        //
        [Flags]
        public enum BlendMode
        {
            None = 0,
            Blend = 1 << 0,
            Add = 1 << 1,
            Mod = 1 << 2
        }

        public enum BlendOperation
        {
            Add = 0x1,
            Subtract = 0x2,
            ReverseSubtract = 0x3,
            Minimum = 0x4,
            Maximum = 0x5
        }

        public enum BlendFactor
        {
            Zero = 0x1,
            One = 0x2,
            SrcColor = 0x3,
            OneMinusSrcColor = 0x4,
            SrcAlpha = 0x5,
            OneMinusSrcAlpha = 0x6,
            DstColor = 0x7,
            OneMinusDstColor = 0x8,
            DstAlpha = 0x9,
            OneMinusDstAlpha = 0xA,
        }

        [DllImport("SDL2", EntryPoint = "SDL_ComposeCustomBlendMode")]
        public static extern BlendMode ComposeCustomBlendMode(BlendFactor srcColorFactor, BlendFactor dstColorFactor, BlendOperation colorOperation, BlendFactor srcAlphaFactor, BlendFactor dstAlphaFactor, BlendOperation alphaOperation);

        //
        // SDL_clipboard.h
        //
        [DllImport("SDL2", EntryPoint = "SDL_SetClipboardText")]
        public static extern int SetClipboardText(byte* text);
        [DllImport("SDL2", EntryPoint = "SDL_GetClipboardText")]
        public static extern byte* GetClipboardText();
        [DllImport("SDL2", EntryPoint = "SDL_HasClipboardText")]
        public static extern bool HasClipboardText();

        //
        // SDL_cpuinfo.h
        //
        [DllImport("SDL2", EntryPoint = "SDL_GetCpuCount")]
        public static extern int GetCpuCount();
        [DllImport("SDL2", EntryPoint = "SDL_GetCpuCacheLineSize")]
        public static extern int GetCpuCacheLineSize();
        [DllImport("SDL2", EntryPoint = "SDL_HasRDTSC")]
        public static extern bool HasRdtsc();
        [DllImport("SDL2", EntryPoint = "SDL_HasAltiVec")]
        public static extern bool HasAltiVec();
        [DllImport("SDL2", EntryPoint = "SDL_HasMMX")]
        public static extern bool HasMmx();
        [DllImport("SDL2", EntryPoint = "SDL_Has3DNow")]
        public static extern bool Has3DNow();
        [DllImport("SDL2", EntryPoint = "SDL_HasSSE")]
        public static extern bool HasSse();
        [DllImport("SDL2", EntryPoint = "SDL_HasSSE2")]
        public static extern bool HasSse2();
        [DllImport("SDL2", EntryPoint = "SDL_HasSSE3")]
        public static extern bool HasSse3();
        [DllImport("SDL2", EntryPoint = "SDL_HasSSE41")]
        public static extern bool HasSse41();
        [DllImport("SDL2", EntryPoint = "SDL_HasSSE42")]
        public static extern bool HasSse42();
        [DllImport("SDL2", EntryPoint = "SDL_HasAVX")]
        public static extern bool HasAvx();
        [DllImport("SDL2", EntryPoint = "SDL_HasAVX2")]
        public static extern bool HasAvx2();
        [DllImport("SDL2", EntryPoint = "SDL_HasNeon")]
        public static extern bool HasNeon();
        [DllImport("SDL2", EntryPoint = "SDL_GetSystemRam")]
        public static extern int GetSystemRam();

        //
        // SDL_error.h
        //
        [DllImport("SDL2", EntryPoint = "SDL_GetError")]
        public static extern byte* GetError();
        [DllImport("SDL2", EntryPoint = "SDL_SetError")]
        public static extern int SetError(byte* format, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_ClearError")]
        public static extern void ClearError();

        //
        // SDL_events.h
        //
        public delegate int EventFilter(void* userdata, Event* sdlEvent);

        public enum EventType : uint
        {
            FirstEvent = 0,

            Quit = 0x100,

            AppTerminating,
            AppLowMemory,
            AppWillEnterBackground,
            AppDidEnterBackground,
            AppWillEnterForeground,
            AppDidEnterForeground,

            WindowEvent = 0x200,
            SysWMEvent,

            KeyDown = 0x300,
            KeyUp,
            TextEditing,
            TextInput,
            KeyMapChanged,

            MouseMotion = 0x400,
            MouseButtonDown,
            MouseButtonUp,
            MouseWheel,

            JoyAxisMotion = 0x600,
            JoyBallMotion,
            JoyHatMotion,
            JoyButtonDown,
            JoyButtonUp,
            JoyDeviceAdded,
            JoyDeviceRemoved,

            ControllerAxisMotion = 0x650,
            ControllerButtonDown,
            ControllerButtonUp,
            ControllerDeviceAdded,
            ControllerDeviceRemoved,
            ControllerDeviceMapped,

            FingerDown = 0x700,
            FingerUp,
            FingerMotion,

            DollarGesture = 0x800,
            DollarRecord,
            MultiGesture,

            ClipboardUpdate = 0x900,

            DropFile = 0x1000,
            DropText,
            DropBegin,
            DropComplete,

            AudioDeviceAdded = 0x1100,
            AudioDeviceRemoved,

            RenderTargetsReset = 0x2000,
            RenderDeviceReset,

            UserEvent = 0x8000,

            LastEvent = 0xFFFF
        }

        public enum EventAction
        {
            AddEvent,
            PeekEvent,
            GetEvent
        }

        public enum State : sbyte
        {
            Query = -1,
            Ignore = 0,
            Disable = 0,
            Enable = 1
        }

        public struct SysWMmsg
        {
            public IntPtr Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CommonEvent
        {
            public EventType Type;
            public uint TimeStamp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public WindowEventID Event;
            private byte Padding1;
            private byte Padding2;
            private byte Padding3;
            public int Data1;
            public int Data2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public ButtonState State;
            public byte Repeat;
            private byte Padding2;
            private byte Padding3;
            public KeySym KeySym;
        }

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct TextEditingEvent
        {
            public const int TextEditingEventTextSize = 32;

            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public fixed byte Text[TextEditingEventTextSize];
            public int Start;
            public int Length;
        }

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct TextInputEvent
        {
            public const int TextInputEventTextSize = 32;

            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public fixed byte Text[TextInputEventTextSize];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseMotionEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public uint Which;
            public uint State;
            public int X;
            public int Y;
            public int XRel;
            public int YRel;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseButtonEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public uint Which;
            public MouseButton Button;
            public ButtonState State;
            public byte Clicks;
            private byte Padding1;
            public int X;
            public int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseWheelEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public uint Which;
            public int X;
            public int Y;
            public uint Direction;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct JoyAxisEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
            public byte Axis;
            private byte Padding1;
            private byte Padding2;
            private byte Padding3;
            public short Value;
            public ushort Padding4;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct JoyBallEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
            public byte Ball;
            private byte Padding1;
            private byte Padding2;
            private byte Padding3;
            public short Xrel;
            public short Yrel;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct JoyHatEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
            public byte Hat;
            public byte Value;
            private byte Padding1;
            private byte Padding2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct JoyButtonEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
            public byte Button;
            public byte State;
            private byte Padding1;
            private byte Padding2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct JoyDeviceEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ControllerAxisEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
            public byte Axis;
            private byte Padding1;
            private byte Padding2;
            private byte Padding3;
            public short Value;
            public ushort Padding4;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ControllerButtonEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
            public byte Button;
            public byte State;
            private byte Padding1;
            private byte Padding2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ControllerDeviceEvent
        {
            public EventType Type;
            public uint Timestamp;
            public int Which;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct AudioDeviceEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint Which;
            public byte Iscapture;
            private byte Padding1;
            private byte Padding2;
            private byte Padding3;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TouchFingerEvent
        {
            public EventType Type;
            public uint Timestamp;
            public long TouchId;
            public long FingerId;
            public float X;
            public float Y;
            public float Dx;
            public float Dy;
            public float Pressure;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MultiGestureEvent
        {
            public EventType Type;
            public uint Timestamp;
            public long TouchId;
            public float DTheta;
            public float DDist;
            public float X;
            public float Y;
            public ushort NumFingers;
            public ushort Padding;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DollarGestureEvent
        {
            public EventType Type;
            public uint Timestamp;
            public long TouchId;
            public long GestureId;
            public uint NumFingers;
            public float Error;
            public float X;
            public float Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct DropEvent
        {
            public EventType Type;
            public uint Timestamp;
            public byte* File;
            public uint WindowID;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct QuitEvent
        {
            public EventType Type;
            public uint Timestamp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct OSEvent
        {
            public EventType Type;
            public uint Timestamp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct UserEvent
        {
            public EventType Type;
            public uint Timestamp;
            public uint WindowID;
            public int Code;
            public IntPtr Data1;
            public IntPtr Data2;
        }

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct SysWMEvent
        {
            public EventType Type;
            public uint Timestamp;
            public SysWMmsg* Msg;
        }

        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public struct Event
        {
            [FieldOffset(0)] public EventType Type;
            [FieldOffset(0)] public CommonEvent Common;
            [FieldOffset(0)] public WindowEvent Window;
            [FieldOffset(0)] public KeyboardEvent Key;
            [FieldOffset(0)] public TextEditingEvent Edit;
            [FieldOffset(0)] public TextInputEvent Text;
            [FieldOffset(0)] public MouseMotionEvent MouseMotion;
            [FieldOffset(0)] public MouseButtonEvent MouseButton;
            [FieldOffset(0)] public MouseWheelEvent MouseWheel;
            [FieldOffset(0)] public JoyAxisEvent Jaxis;
            [FieldOffset(0)] public JoyBallEvent Jball;
            [FieldOffset(0)] public JoyHatEvent Jhat;
            [FieldOffset(0)] public JoyButtonEvent Jbutton;
            [FieldOffset(0)] public JoyDeviceEvent Jdevice;
            [FieldOffset(0)] public ControllerAxisEvent Caxis;
            [FieldOffset(0)] public ControllerButtonEvent Cbutton;
            [FieldOffset(0)] public ControllerDeviceEvent Cdevice;
            [FieldOffset(0)] public AudioDeviceEvent Adevice;
            [FieldOffset(0)] public QuitEvent Quit;
            [FieldOffset(0)] public UserEvent User;
            [FieldOffset(0)] public SysWMEvent Syswm;
            [FieldOffset(0)] public TouchFingerEvent Tfinger;
            [FieldOffset(0)] public MultiGestureEvent Mgesture;
            [FieldOffset(0)] public DollarGestureEvent Dgesture;
            [FieldOffset(0)] public DropEvent Drop;
        }

        [DllImport("SDL2", EntryPoint = "SDL_PumpEvents")]
        public static extern void PumpEvents();
        [DllImport("SDL2", EntryPoint = "SDL_PeepEvents")]
        public static extern int PeepEvents(Event* events, int numEvents, EventAction action, EventType minType, EventType maxType);
        [DllImport("SDL2", EntryPoint = "SDL_HasEvent")]
        public static extern bool HasEvent(EventType type);
        [DllImport("SDL2", EntryPoint = "SDL_HasEvents")]
        public static extern bool HasEvents(EventType minType, EventType maxType);
        [DllImport("SDL2", EntryPoint = "SDL_FlushEvent")]
        public static extern void FlushEvent(EventType type);
        [DllImport("SDL2", EntryPoint = "SDL_FlushEvents")]
        public static extern void FlushEvents(EventType minType, EventType maxType);
        [DllImport("SDL2", EntryPoint = "SDL_PollEvent")]
        public static extern int PollEvent(out Event @event);
        [DllImport("SDL2", EntryPoint = "SDL_WaitEvent")]
        public static extern int WaitEvent(out Event @event);
        [DllImport("SDL2", EntryPoint = "SDL_WaitEventTimeout")]
        public static extern int WaitEventTimeout(out Event @event, int timeout);
        [DllImport("SDL2", EntryPoint = "SDL_PushEvent")]
        public static extern int PushEvent(ref Event @event);
        [DllImport("SDL2", EntryPoint = "SDL_SetEventFilter")]
        public static extern void SetEventFilter(EventFilter filter, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_GetEventFilter")]
        public static extern bool GetEventFilter(out EventFilter filter, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_AddEventWatch")]
        public static extern void AddEventWatch(EventFilter filter, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_DelEventWatch")]
        public static extern void DelEventWatch(EventFilter filter, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_FilterEvents")]
        public static extern void FilterEvents(EventFilter filter, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_EventState")]
        public static extern State EventState(EventType type, State state);
        public static State GetEventState(EventType type) => EventState(type, State.Query);
        [DllImport("SDL2", EntryPoint = "SDL_RegisterEvents")]
        public static extern uint RegisterEvents(int numEvents);

        //
        // SDL_filesystem.h
        //
        [DllImport("SDL2", EntryPoint = "SDL_GetBasePath")]
        public static extern byte* GetBasePath();
        [DllImport("SDL2", EntryPoint = "SDL_GetPrefPath")]
        public static extern byte* GetPrefPath(byte* org, byte* app);

        //
        // SDL_gamecontroller.h
        //
        public enum GameControllerBindType
        {
            None = 0,
            Button,
            Axis,
            Hat
        }

        public enum GameControllerAxis
        {
            Invalid = -1,
            LeftX,
            LeftY,
            RightX,
            RightY,
            TriggertLeft,
            TriggerRight,
            Max
        }

        public enum GameControllerButton
        {
            Invalid = -1,
            A,
            B,
            X,
            Y,
            Back,
            Guide,
            Start,
            LeftStick,
            RightStick,
            LeftShoulder,
            RightShoulder,
            DPadUp,
            DPadDown,
            DPadLeft,
            DPadRight,
            Max
        }

        public struct GameController
        {
            public IntPtr Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Hat
        {
            public int HatIndex;
            public int HatMask;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct GameControllerButtonBind
        {
            [FieldOffset(0)] public GameControllerBindType BindType;
            [FieldOffset(4)] public int Button;
            [FieldOffset(4)] public int Axis;
            [FieldOffset(4)] public Hat Hat;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GameControllerAddMappingsFromRW")]
        public static extern int GameControllerAddMappingsFromRW(RWops rwOps, int freeRW);

        public static int GameControllerAddMappingsFromFile(byte* file)
        {
            byte* rb = Utf8.AllocateFromString("rb");
            int result = GameControllerAddMappingsFromRW(RWFromFile(file, rb), 1);
            Utf8.Free(rb);
            return result;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GameControllerAddMapping")]
        public static extern int GameControllerAddMapping(byte* mappingText);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerNumMappings")]
        public static extern int GameControllerNumMappings();
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerMappingForIndex")]
        public static extern byte* GameControllerMappingForIndex(int mappingIndex);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerMappingForGuid")]
        public static extern byte* GameControllerMappingForGuid(Guid guid);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerMapping")]
        public static extern byte* GameControllerMapping(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_IsGameController")]
        public static extern bool IsGameController(int joystickIndex);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerNameForIndex")]
        public static extern byte* GameControllerNameForIndex(int joystickIndex);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerOpen")]
        public static extern GameController GameControllerOpen(int joystickIndex);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerFromInstanceID")]
        public static extern GameController GameControllerFromInstanceID(JoystickID joystickID);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerName")]
        public static extern byte* GameControllerName(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetVendor")]
        public static extern ushort GameControllerGetVendor(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetProduct")]
        public static extern ushort GameControllerGetProduct(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetProductVersion")]
        public static extern ushort GameControllerGetProductVersion(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetAttached")]
        public static extern bool GameControllerGetAttached(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetJoystick")]
        public static extern Joystick GameControllerGetJoystick(GameController gameController);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerEventState")]
        public static extern State GameControllerEventState(State state);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerUpdate")]
        public static extern void GameControllerUpdate();
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetAxisFromText")]
        public static extern GameControllerAxis GameControllerGetAxisFromText(byte* pchText);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetTextForAxis")]
        public static extern byte* GameControllerGetTextForAxis(GameControllerAxis axis);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetBindForAxis")]
        public static extern GameControllerButtonBind GameControllerGetBindForAxis(GameController gameController, GameControllerAxis axis);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetAxis")]
        public static extern short GameControllerGetAxis(GameController gameController, GameControllerAxis axis);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetButtonFromText")]
        public static extern GameControllerButton GameControllerGetButtonFromText(byte* pchText);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetTextForButton")]
        public static extern byte* GameControllerGetTextForButton(GameControllerButton button);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetBindForButton")]
        public static extern GameControllerButtonBind GameControllerGetBindForButton(GameController gameController, GameControllerButton button);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerGetButton")]
        public static extern byte GameControllerGetButton(GameController gameController, GameControllerButton button);
        [DllImport("SDL2", EntryPoint = "SDL_GameControllerClose")]
        public static extern void GameControllerClose(GameController gameController);

        //
        // SDL_gesture.h
        //
        public struct GestureID
        {
            public long Handle;
        }

        [DllImport("SDL2", EntryPoint = "SDL_RecordGesture")]
        public static extern int RecordGesture(TouchID touchId);
        [DllImport("SDL2", EntryPoint = "SDL_SaveAllDollarTemplates")]
        public static extern int SaveAllDollarTemplates(RWops dst);
        [DllImport("SDL2", EntryPoint = "SDL_SaveDollarTemplate")]
        public static extern int SaveDollarTemplate(GestureID gestureId, RWops dst);
        [DllImport("SDL2", EntryPoint = "SDL_LoadDollarTemplates")]
        public static extern int LoadDollarTemplates(TouchID touchId, RWops src);

        //
        // SDL_haptic.h
        //
        [Flags]
        public enum HapticEffectType : ushort
        {
            Constant = 1 << 0,
            Sine = 1 << 1,
            LeftRight = 1 << 2,
            Triangle = 1 << 3,
            SawtoothUp = 1 << 4,
            SawtoothDown = 1 << 5,
            Ramp = 1 << 6,
            Spring = 1 << 7,
            Damper = 1 << 8,
            Inertia = 1 << 9,
            Friction = 1 << 10,
            Custom = 1 << 11,
            Gain = 1 << 12,
            AutoCenter = 1 << 13,
            Status = 1 << 14,
            Pause = 1 << 15
        }

        public enum HapticDirectionType : byte
        {
            Polar = 0,
            Cartesian = 1,
            Spherical = 2
        }

        public struct Haptic
        {
            public IntPtr Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HapticDirection
        {
            public HapticDirectionType Type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HapticConstant
        {
            public HapticEffectType Type;
            public HapticDirection Direction;
            public uint Length;
            public ushort Delay;
            public ushort Button;
            public ushort Interval;
            public short Level;
            public ushort AttackLength;
            public ushort AttackLevel;
            public ushort FadeLength;
            public ushort FadeLevel;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HapticPeriodic
        {
            public HapticEffectType Type;
            public HapticDirection Direction;
            public uint Length;
            public ushort Delay;
            public ushort Button;
            public ushort Interval;
            public ushort Period;
            public short Magnitude;
            public short Offset;
            public ushort Phase;
            public ushort AttackLength;
            public ushort AttackLevel;
            public ushort FadeLength;
            public ushort FadeLevel;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct HapticCondition
        {
            public HapticEffectType Type;
            public HapticDirection Direction;
            public uint Length;
            public ushort Delay;
            public ushort Button;
            public ushort Interval;
            public fixed ushort RightSat[3];
            public fixed ushort LeftSat[3];
            public fixed short RightCoeff[3];
            public fixed short LeftCoeff[3];
            public fixed ushort Deadband[3];
            public fixed short Center[3];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HapticRamp
        {
            public HapticEffectType Type;
            public HapticDirection Direction;
            public uint Length;
            public ushort Delay;
            public ushort Button;
            public ushort Interval;
            public short Start;
            public short End;
            public ushort AttackLength;
            public ushort AttackLevel;
            public ushort FadeLength;
            public ushort FadeLevel;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HapticLeftRight
        {
            public HapticEffectType Type;
            public uint Length;
            public ushort LargeMagnitude;
            public ushort SmallMagnitude;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct HapticCustom
        {
            public HapticEffectType Type;
            public HapticDirection Direction;
            public uint Length;
            public ushort Delay;
            public ushort Button;
            public ushort Interval;
            public byte Channels;
            public ushort Period;
            public ushort Samples;
            public ushort* Data;
            public ushort AttackLength;
            public ushort AttackLevel;
            public ushort FadeLength;
            public ushort FadeLevel;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct HapticEffect
        {
            [FieldOffset(0)] public HapticEffectType Type;
            [FieldOffset(0)] public HapticConstant Constant;
            [FieldOffset(0)] public HapticPeriodic Periodic;
            [FieldOffset(0)] public HapticCondition Condition;
            [FieldOffset(0)] public HapticRamp Ramp;
            [FieldOffset(0)] public HapticLeftRight LeftRight;
            [FieldOffset(0)] public HapticCustom Custom;
        }

        [DllImport("SDL2", EntryPoint = "SDL_NumHaptics")]
        public static extern int NumHaptics();
        [DllImport("SDL2", EntryPoint = "SDL_HapticName")]
        public static extern byte* HapticName(int device_index);
        [DllImport("SDL2", EntryPoint = "SDL_HapticOpen")]
        public static extern Haptic* HapticOpen(int device_index);
        [DllImport("SDL2", EntryPoint = "SDL_HapticOpened")]
        public static extern int HapticOpened(int device_index);
        [DllImport("SDL2", EntryPoint = "SDL_HapticIndex")]
        public static extern int HapticIndex(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_MouseIsHaptic")]
        public static extern int MouseIsHaptic();
        [DllImport("SDL2", EntryPoint = "SDL_HapticOpenFromMouse")]
        public static extern Haptic* HapticOpenFromMouse();
        [DllImport("SDL2", EntryPoint = "SDL_JoystickIsHaptic")]
        public static extern int JoystickIsHaptic(Joystick* joystick);
        [DllImport("SDL2", EntryPoint = "SDL_HapticOpenFromJoystick")]
        public static extern Haptic* HapticOpenFromJoystick(Joystick* joystick);
        [DllImport("SDL2", EntryPoint = "SDL_HapticClose")]
        public static extern void HapticClose(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticNumEffects")]
        public static extern int HapticNumEffects(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticNumEffectsPlaying")]
        public static extern int HapticNumEffectsPlaying(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticQuery")]
        public static extern uint HapticQuery(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticNumAxes")]
        public static extern int HapticNumAxes(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticEffectSupported")]
        public static extern int HapticEffectSupported(Haptic* haptic, HapticEffect* effect);
        [DllImport("SDL2", EntryPoint = "SDL_HapticNewEffect")]
        public static extern int HapticNewEffect(Haptic* haptic, HapticEffect* effect);
        [DllImport("SDL2", EntryPoint = "SDL_HapticUpdateEffect")]
        public static extern int HapticUpdateEffect(Haptic* haptic, int effect, HapticEffect* data);
        [DllImport("SDL2", EntryPoint = "SDL_HapticRunEffect")]
        public static extern int HapticRunEffect(Haptic* haptic, int effect, uint iterations);
        [DllImport("SDL2", EntryPoint = "SDL_HapticStopEffect")]
        public static extern int HapticStopEffect(Haptic* haptic, int effect);
        [DllImport("SDL2", EntryPoint = "SDL_HapticDestroyEffect")]
        public static extern void HapticDestroyEffect(Haptic* haptic, int effect);
        [DllImport("SDL2", EntryPoint = "SDL_HapticGetEffectStatus")]
        public static extern int HapticGetEffectStatus(Haptic* haptic, int effect);
        [DllImport("SDL2", EntryPoint = "SDL_HapticSetGain")]
        public static extern int HapticSetGain(Haptic* haptic, int gain);
        [DllImport("SDL2", EntryPoint = "SDL_HapticSetAutocenter")]
        public static extern int HapticSetAutocenter(Haptic* haptic, int autocenter);
        [DllImport("SDL2", EntryPoint = "SDL_HapticPause")]
        public static extern int HapticPause(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticUnpause")]
        public static extern int HapticUnpause(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticStopAll")]
        public static extern int HapticStopAll(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticRumbleSupported")]
        public static extern int HapticRumbleSupported(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticRumbleInit")]
        public static extern int HapticRumbleInit(Haptic* haptic);
        [DllImport("SDL2", EntryPoint = "SDL_HapticRumblePlay")]
        public static extern int HapticRumblePlay(Haptic* haptic, float strength, uint length);
        [DllImport("SDL2", EntryPoint = "SDL_HapticRumbleStop")]
        public static extern int HapticRumbleStop(Haptic* haptic);

        //
        // SDL_hints.h
        //
        public delegate void HintCallback(void* userData, string name, string oldValue, string newValue);

        public enum HintPriority
        {
            Default,
            Normal,
            Override
        }

        [DllImport("SDL2", EntryPoint = "SDL_SetHintWithPriority")]
        public static extern bool SetHintWithPriority(byte* name, byte* value, HintPriority priority);
        [DllImport("SDL2", EntryPoint = "SDL_SetHint")]
        public static extern bool SetHint(byte* name, byte* value);
        [DllImport("SDL2", EntryPoint = "SDL_GetHint")]
        public static extern byte* GetHint(byte* name);
        [DllImport("SDL2", EntryPoint = "SDL_GetHintBoolean")]
        public static extern bool GetHintBoolean(byte* name, bool defaultValue);
        [DllImport("SDL2", EntryPoint = "SDL_AddHintCallback")]
        public static extern void AddHintCallback(byte* name, HintCallback callback, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_DelHintCallback")]
        public static extern void DelHintCallback(byte* name, HintCallback callback, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_ClearHints")]
        public static extern void ClearHints();

        //
        // SDL_joystick.h
        //
        public enum JoystickType
        {
            Unknown,
            GameController,
            Wheel,
            ArcadeStick,
            FlightStick,
            DancePad,
            Guitar,
            DrumKit,
            ArcadePad,
            Throttle
        }

        public enum JoystickPowerLevel
        {
            Unknown = -1,
            Empty,
            Low,
            Medium,
            Full,
            Wired,
            Max
        }

        public enum JoystickAxis
        {
            X = 0,
            Y = 1
        }

        public enum JoystickHat : byte
        {
            Centered = 0x00,
            Up = 0x01,
            Right = 0x02,
            Down = 0x04,
            Left = 0x08,
            RightUp = Right | Up,
            RightDown = Right | Down,
            LeftUp = Left | Up,
            LeftDown = Left | Down
        }

        public struct Joystick
        {
            public IntPtr Handle;
        }

        public struct JoystickID
        {
            public int Handle;
        }

        [DllImport("SDL2", EntryPoint = "SDL_NumJoysticks")]
        public static extern int NumJoysticks();
        [DllImport("SDL2", EntryPoint = "SDL_JoystickNameForIndex")]
        public static extern byte* JoystickNameForIndex(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetDeviceGuid")]
        public static extern Guid JoystickGetDeviceGUID(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetDeviceVendor")]
        public static extern ushort JoystickGetDeviceVendor(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetDeviceProduct")]
        public static extern ushort JoystickGetDeviceProduct(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetDeviceProductVersion")]
        public static extern ushort JoystickGetDeviceProductVersion(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetDeviceType")]
        public static extern JoystickType JoystickGetDeviceType(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetDeviceInstanceID")]
        public static extern JoystickID JoystickGetDeviceInstanceID(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickOpen")]
        public static extern Joystick JoystickOpen(int deviceIndex);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickFromInstanceID")]
        public static extern Joystick JoystickFromInstanceID(JoystickID joystickID);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickName")]
        public static extern byte* JoystickName(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetGuid")]
        public static extern Guid JoystickGetGUID(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetVendor")]
        public static extern ushort JoystickGetVendor(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetProduct")]
        public static extern ushort JoystickGetProduct(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetProductVersion")]
        public static extern ushort JoystickGetProductVersion(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetType")]
        public static extern JoystickType JoystickGetType(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetGuidText")]
        public static extern void JoystickGetGuidText(Guid guid, byte* pszGUID, int cbGUID);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetGuidFromText")]
        public static extern Guid JoystickGetGUIDFromText(byte* pchGUID);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetAttached")]
        public static extern bool JoystickGetAttached(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickInstanceID")]
        public static extern JoystickID JoystickInstanceID(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickNumAxes")]
        public static extern int JoystickNumAxes(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickNumBalls")]
        public static extern int JoystickNumBalls(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickNumHats")]
        public static extern int JoystickNumHats(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickNumButtons")]
        public static extern int JoystickNumButtons(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickUpdate")]
        public static extern void JoystickUpdate();
        [DllImport("SDL2", EntryPoint = "SDL_JoystickEventState")]
        public static extern State JoystickEventState(State state);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetAxis")]
        public static extern short JoystickGetAxis(Joystick joystick, JoystickAxis axis);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public static extern bool JoystickGetAxisInitialState(Joystick joystick, JoystickAxis axis, out short state);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetHat")]
        public static extern JoystickHat JoystickGetHat(Joystick joystick, int hat);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetBall")]
        public static extern int JoystickGetBall(Joystick joystick, int ball, out int dx, out int dy);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickGetButton")]
        public static extern byte JoystickGetButton(Joystick joystick, int button);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickClose")]
        public static extern void JoystickClose(Joystick joystick);
        [DllImport("SDL2", EntryPoint = "SDL_JoystickCurrentPowerLevel")]
        public static extern JoystickPowerLevel JoystickCurrentPowerLevel(Joystick joystick);

        //
        // SDL_keyboard.h
        //
        public enum ButtonState : byte
        {
            Released = 0,
            Pressed = 1
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KeySym
        {
            public Scancode ScanCode;
            public KeyCode Sym;
            public KeyMod Mod;
            private uint Unused;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetKeyboardFocus")]
        public static extern Window GetKeyboardFocus();
        [DllImport("SDL2", EntryPoint = "SDL_GetKeyboardState")]
        public static extern byte* GetKeyboardState(out int numkeys);
        [DllImport("SDL2", EntryPoint = "SDL_GetModState")]
        public static extern KeyMod GetModState();
        [DllImport("SDL2", EntryPoint = "SDL_SetModState")]
        public static extern void SetModState(KeyMod modState);
        [DllImport("SDL2", EntryPoint = "SDL_GetKeyFromScancode")]
        public static extern KeyCode GetKeyFromScancode(Scancode scancode);
        [DllImport("SDL2", EntryPoint = "SDL_GetScancodeFromKey")]
        public static extern Scancode GetScancodeFromKey(KeyCode key);
        [DllImport("SDL2", EntryPoint = "SDL_GetScancodeName")]
        public static extern byte* GetScancodeName(Scancode scancode);
        [DllImport("SDL2", EntryPoint = "SDL_GetScancodeFromName")]
        public static extern Scancode GetScancodeFromName(byte* name);
        [DllImport("SDL2", EntryPoint = "SDL_GetKeyName")]
        public static extern byte* GetKeyName(KeyCode key);
        [DllImport("SDL2", EntryPoint = "SDL_GetKeyFromName")]
        public static extern KeyCode GetKeyFromName(byte* name);
        [DllImport("SDL2", EntryPoint = "SDL_StartTextInput")]
        public static extern void StartTextInput();
        [DllImport("SDL2", EntryPoint = "SDL_IsTextInputActive")]
        public static extern bool IsTextInputActive();
        [DllImport("SDL2", EntryPoint = "SDL_StopTextInput")]
        public static extern void StopTextInput();
        [DllImport("SDL2", EntryPoint = "SDL_SetTextInputRect")]
        public static extern void SetTextInputRect(ref Rect rectangle);
        [DllImport("SDL2", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        public static extern bool HasScreenKeyboardSupport();
        [DllImport("SDL2", EntryPoint = "SDL_IsScreenKeyboardShown")]
        public static extern bool IsScreenKeyboardShown(Window window);

        //
        // SDL_keycode.h
        //
        public const int ScanCodeMask = (1 << 30);

        public enum KeyCode
        {
            Unknown = 0,

            Return = '\r',
            Escape = 27, // '\033'
            Backspace = '\b',
            Tab = '\t',
            Space = ' ',
            Exclaim = '!',
            QuoteDouble = '"',
            Hash = '#',
            Percent = '%',
            Dollar = '$',
            Ampersand = '&',
            Quote = '\'',
            LeftParenthesis = '(',
            RightParenthesis = ')',
            Asterisk = '*',
            Plus = '+',
            Comma = ',',
            Minus = '-',
            Period = '.',
            Slash = '/',
            Alpha0 = '0',
            Alpha1 = '1',
            Alpha2 = '2',
            Alpha3 = '3',
            Alpha4 = '4',
            Alpha5 = '5',
            Alpha6 = '6',
            Alpha7 = '7',
            Alpha8 = '8',
            Alpha9 = '9',
            Colon = ':',
            Semicolon = ';',
            Less = '<',
            Equals = '=',
            Greater = '>',
            Question = '?',
            At = '@',

            LeftBracket = '[',
            Backslash = '\\',
            RightBracket = ']',
            Caret = '^',
            Underscore = '_',
            Backquote = '`',
            A = 'a',
            B = 'b',
            C = 'c',
            D = 'd',
            E = 'e',
            F = 'f',
            G = 'g',
            H = 'h',
            I = 'i',
            J = 'j',
            K = 'k',
            L = 'l',
            M = 'm',
            N = 'n',
            O = 'o',
            P = 'p',
            Q = 'q',
            R = 'r',
            S = 's',
            T = 't',
            U = 'u',
            V = 'v',
            W = 'w',
            X = 'x',
            Y = 'y',
            Z = 'z',

            Capslock = Scancode.Capslock | ScanCodeMask,

            F1 = Scancode.F1 | ScanCodeMask,
            F2 = Scancode.F2 | ScanCodeMask,
            F3 = Scancode.F3 | ScanCodeMask,
            F4 = Scancode.F4 | ScanCodeMask,
            F5 = Scancode.F5 | ScanCodeMask,
            F6 = Scancode.F6 | ScanCodeMask,
            F7 = Scancode.F7 | ScanCodeMask,
            F8 = Scancode.F8 | ScanCodeMask,
            F9 = Scancode.F9 | ScanCodeMask,
            F10 = Scancode.F10 | ScanCodeMask,
            F11 = Scancode.F11 | ScanCodeMask,
            F12 = Scancode.F12 | ScanCodeMask,

            Printscreen = Scancode.Printscreen | ScanCodeMask,
            ScrollLock = Scancode.ScrollLock | ScanCodeMask,
            Pause = Scancode.Pause | ScanCodeMask,
            Insert = Scancode.Insert | ScanCodeMask,
            Home = Scancode.Home | ScanCodeMask,
            PageUp = Scancode.PageUp | ScanCodeMask,
            Delete = 127, // '\177',
            End = Scancode.End | ScanCodeMask,
            PageDown = Scancode.PageDown | ScanCodeMask,
            Right = Scancode.Right | ScanCodeMask,
            Left = Scancode.Left | ScanCodeMask,
            Down = Scancode.Down | ScanCodeMask,
            Up = Scancode.Up | ScanCodeMask,

            NumlockClear = Scancode.NumlockClear | ScanCodeMask,
            NumDivide = Scancode.NumDivide | ScanCodeMask,
            NumMultiply = Scancode.NumMultiply | ScanCodeMask,
            NumMinus = Scancode.NumMinus | ScanCodeMask,
            NumPlus = Scancode.NumPlus | ScanCodeMask,
            NumEnter = Scancode.NumEnter | ScanCodeMask,
            Num1 = Scancode.Num1 | ScanCodeMask,
            Num2 = Scancode.Num2 | ScanCodeMask,
            Num3 = Scancode.Num3 | ScanCodeMask,
            Num4 = Scancode.Num4 | ScanCodeMask,
            Num5 = Scancode.Num5 | ScanCodeMask,
            Num6 = Scancode.Num6 | ScanCodeMask,
            Num7 = Scancode.Num7 | ScanCodeMask,
            Num8 = Scancode.Num8 | ScanCodeMask,
            Num9 = Scancode.Num9 | ScanCodeMask,
            Num0 = Scancode.Num0 | ScanCodeMask,
            NumPeriod = Scancode.NumPeriod | ScanCodeMask,

            Application = Scancode.Application | ScanCodeMask,
            Power = Scancode.Power | ScanCodeMask,
            NumEquals = Scancode.NumEquals | ScanCodeMask,
            F13 = Scancode.F13 | ScanCodeMask,
            F14 = Scancode.F14 | ScanCodeMask,
            F15 = Scancode.F15 | ScanCodeMask,
            F16 = Scancode.F16 | ScanCodeMask,
            F17 = Scancode.F17 | ScanCodeMask,
            F18 = Scancode.F18 | ScanCodeMask,
            F19 = Scancode.F19 | ScanCodeMask,
            F20 = Scancode.F20 | ScanCodeMask,
            F21 = Scancode.F21 | ScanCodeMask,
            F22 = Scancode.F22 | ScanCodeMask,
            F23 = Scancode.F23 | ScanCodeMask,
            F24 = Scancode.F24 | ScanCodeMask,
            Execute = Scancode.Execute | ScanCodeMask,
            Help = Scancode.Help | ScanCodeMask,
            Menu = Scancode.Menu | ScanCodeMask,
            Select = Scancode.Select | ScanCodeMask,
            Stop = Scancode.Stop | ScanCodeMask,
            Again = Scancode.Again | ScanCodeMask,
            Undo = Scancode.Undo | ScanCodeMask,
            Cut = Scancode.Cut | ScanCodeMask,
            Copy = Scancode.Copy | ScanCodeMask,
            Paste = Scancode.Paste | ScanCodeMask,
            Find = Scancode.Find | ScanCodeMask,
            Mute = Scancode.Mute | ScanCodeMask,
            VolumeUp = Scancode.VolumeUp | ScanCodeMask,
            VolumeDown = Scancode.VolumeDown | ScanCodeMask,
            NumComma = Scancode.NumComma | ScanCodeMask,
            NumEqualsAs400 = Scancode.NumEqualsAs400 | ScanCodeMask,

            AltErase = Scancode.AltErase | ScanCodeMask,
            SysReq = Scancode.SysReq | ScanCodeMask,
            Cancel = Scancode.Cancel | ScanCodeMask,
            Clear = Scancode.Clear | ScanCodeMask,
            Prior = Scancode.Prior | ScanCodeMask,
            Return2 = Scancode.Return2 | ScanCodeMask,
            Separator = Scancode.Separator | ScanCodeMask,
            Out = Scancode.Out | ScanCodeMask,
            Oper = Scancode.Oper | ScanCodeMask,
            ClearAgain = Scancode.ClearAgain | ScanCodeMask,
            CRSel = Scancode.CRSel | ScanCodeMask,
            EXSel = Scancode.EXSel | ScanCodeMask,

            Num00 = Scancode.Num00 | ScanCodeMask,
            Num000 = Scancode.Num000 | ScanCodeMask,
            ThousandsSeparator = Scancode.ThousandsSeparator | ScanCodeMask,
            DecimalSeparator = Scancode.DecimalSeparator | ScanCodeMask,
            CurrencyUnit = Scancode.CurrencyUnit | ScanCodeMask,
            CurrencySubUnit = Scancode.CurrencySubUnit | ScanCodeMask,
            NumLeftParen = Scancode.NumLeftParen | ScanCodeMask,
            NumRightParen = Scancode.NumRightParen | ScanCodeMask,
            NumLeftBrace = Scancode.NumLeftBrace | ScanCodeMask,
            NumRightBrace = Scancode.NumRightBrace | ScanCodeMask,
            NumTab = Scancode.NumTab | ScanCodeMask,
            NumBackspace = Scancode.NumBackspace | ScanCodeMask,
            NumA = Scancode.NumA | ScanCodeMask,
            NumB = Scancode.NumB | ScanCodeMask,
            NumC = Scancode.NumC | ScanCodeMask,
            NumD = Scancode.NumD | ScanCodeMask,
            NumE = Scancode.NumE | ScanCodeMask,
            NumF = Scancode.NumF | ScanCodeMask,
            NumXor = Scancode.NumXor | ScanCodeMask,
            NumPower = Scancode.NumPower | ScanCodeMask,
            NumPercent = Scancode.NumPercent | ScanCodeMask,
            NumLess = Scancode.NumLess | ScanCodeMask,
            NumGreater = Scancode.NumGreater | ScanCodeMask,
            NumAmpersand = Scancode.NumAmpersand | ScanCodeMask,
            NumDoubleAmpersand = Scancode.NumDoubleAmpersand | ScanCodeMask,
            NumVerticalBar = Scancode.NumVerticalBar | ScanCodeMask,
            NumDoubleVerticalBar = Scancode.NumDoubleVerticalBar | ScanCodeMask,
            NumColon = Scancode.NumColon | ScanCodeMask,
            NumHash = Scancode.NumHash | ScanCodeMask,
            NumSpace = Scancode.NumSpace | ScanCodeMask,
            NumAt = Scancode.NumAt | ScanCodeMask,
            NumExclam = Scancode.NumExclam | ScanCodeMask,
            NumMemStore = Scancode.NumMemStore | ScanCodeMask,
            NumMemRecall = Scancode.NumMemRecall | ScanCodeMask,
            NumMemClear = Scancode.NumMemClear | ScanCodeMask,
            NumMemAdd = Scancode.NumMemAdd | ScanCodeMask,
            NumMemSubtract = Scancode.NumMemSubtract | ScanCodeMask,
            NumMemMultiply = Scancode.NumMemMultiply | ScanCodeMask,
            NumMemDivide = Scancode.NumMemDivide | ScanCodeMask,
            NumPlusMinus = Scancode.NumPlusMinus | ScanCodeMask,
            NumClear = Scancode.NumClear | ScanCodeMask,
            NumClearEntry = Scancode.NumClearEntry | ScanCodeMask,
            NumBinary = Scancode.NumBinary | ScanCodeMask,
            NumOctal = Scancode.NumOctal | ScanCodeMask,
            NumDecimal = Scancode.NumDecimal | ScanCodeMask,
            NumHexadecimal = Scancode.NumHexadecimal | ScanCodeMask,

            LeftControl = Scancode.LeftControl | ScanCodeMask,
            LeftShift = Scancode.LeftShift | ScanCodeMask,
            LeftAlt = Scancode.LeftAlt | ScanCodeMask,
            LeftGUI = Scancode.LeftGUI | ScanCodeMask,
            RightControl = Scancode.RightControl | ScanCodeMask,
            RightShift = Scancode.RightShift | ScanCodeMask,
            RightAlt = Scancode.RightAlt | ScanCodeMask,
            RightGUI = Scancode.RightGUI | ScanCodeMask,

            Mode = Scancode.Mode | ScanCodeMask,

            AudioNext = Scancode.AudioNext | ScanCodeMask,
            AudioPrevious = Scancode.AudioPrevious | ScanCodeMask,
            AudioStop = Scancode.AudioStop | ScanCodeMask,
            AudioPlay = Scancode.AudioPlay | ScanCodeMask,
            AudioMute = Scancode.AudioMute | ScanCodeMask,
            MediaSelect = Scancode.MediaSelect | ScanCodeMask,
            WWW = Scancode.WWW | ScanCodeMask,
            Mail = Scancode.Mail | ScanCodeMask,
            Calculator = Scancode.Calculator | ScanCodeMask,
            Computer = Scancode.Computer | ScanCodeMask,
            ACSearch = Scancode.ACSearch | ScanCodeMask,
            ACHome = Scancode.ACHome | ScanCodeMask,
            ACBack = Scancode.ACBack | ScanCodeMask,
            ACForward = Scancode.ACForward | ScanCodeMask,
            ACStop = Scancode.ACStop | ScanCodeMask,
            ACRefresh = Scancode.ACRefresh | ScanCodeMask,
            ACBookmark = Scancode.ACBookmark | ScanCodeMask,

            BrightnessDown = Scancode.BrightnessDown | ScanCodeMask,
            BrightnessUp = Scancode.BrightnessUp | ScanCodeMask,
            DisplaySwitch = Scancode.DisplaySwitch | ScanCodeMask,
            KeyboardLightToggle = Scancode.KeyboardLightToggle | ScanCodeMask,
            KeyboardLightDown = Scancode.KeyboardLightDown | ScanCodeMask,
            KeyboardLightUp = Scancode.KeyboardLightUp | ScanCodeMask,
            Eject = Scancode.Eject | ScanCodeMask,
            Sleep = Scancode.Sleep | ScanCodeMask
        }

        public enum KeyMod : ushort
        {
            None = 0x0000,
            LeftShift = 0x0001,
            RightShift = 0x0002,
            LeftControl = 0x0040,
            RightControl = 0x0080,
            LeftAlt = 0x0100,
            RightAlt = 0x0200,
            LeftGUI = 0x0400,
            RightGUI = 0x0800,
            Num = 0x1000,
            Caps = 0x2000,
            Mode = 0x4000,
            Reserved = 0x8000,
            Control = LeftControl | RightControl,
            Shift = LeftShift | RightShift,
            Alt = LeftAlt | RightAlt,
            GUI = LeftGUI | RightGUI
        }

        //
        // SDL_loadso.h
        //
        [DllImport("SDL2", EntryPoint = "SDL_LoadObject")]
        public static extern IntPtr LoadObject(byte* file);
        [DllImport("SDL2", EntryPoint = "SDL_LoadFunction")]
        public static extern IntPtr LoadFunction(IntPtr handle, byte* name);
        [DllImport("SDL2", EntryPoint = "SDL_UnloadObject")]
        public static extern void UnloadObject(IntPtr handle);

        //
        // SDL_log.h
        //
        public delegate void LogOutputFunction(void* userData, LogCategory category, LogPriority priority, string message);

        public enum LogCategory
        {
            Application,
            Error,
            Assert,
            System,
            Audio,
            Video,
            Render,
            Input,
            Test,

            Reserved1,
            Reserved2,
            Reserved3,
            Reserved4,
            Reserved5,
            Reserved6,
            Reserved7,
            Reserved8,
            Reserved9,
            Reserved10,

            Custom,
        }

        public enum LogPriority
        {
            Verbose = 1,
            Debug,
            Info,
            Warn,
            Error,
            Critical,
        }

        [DllImport("SDL2", EntryPoint = "SDL_LogSetAllPriority")]
        public static extern void LogSetAllPriority(LogPriority priority);
        [DllImport("SDL2", EntryPoint = "SDL_LogSetPriority")]
        public static extern void LogSetPriority(LogCategory category, LogPriority priority);
        [DllImport("SDL2", EntryPoint = "SDL_LogGetPriority")]
        public static extern LogPriority LogGetPriority(LogCategory category);
        [DllImport("SDL2", EntryPoint = "SDL_LogResetPriorities")]
        public static extern void LogResetPriorities();
        [DllImport("SDL2", EntryPoint = "SDL_Log")]
        public static extern void Log(byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogVerbose")]
        public static extern void LogVerbose(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogDebug")]
        public static extern void LogDebug(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogInfo")]
        public static extern void LogInfo(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogWarn")]
        public static extern void LogWarn(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogError")]
        public static extern void LogError(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogCritical")]
        public static extern void LogCritical(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogMessage")]
        public static extern void LogMessage(LogCategory category, byte* fmt, params object[] objects);
        [DllImport("SDL2", EntryPoint = "SDL_LogGetOutputFunction")]
        public static extern void LogGetOutputFunction(LogOutputFunction callback, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_LogSetOutputFunction")]
        public static extern void LogSetOutputFunction(LogOutputFunction callback, IntPtr userData);

        //
        // SDL_messagebox.h
        //
        [Flags]
        public enum MessageBoxFlags : uint
        {
            Error = 1 << 4,
            Warning = 1 << 5,
            Information = 1 << 6
        }

        [Flags]
        public enum MessageBoxButtonFlags : uint
        {
            ReturnKeyDefault = 1 << 0,
            EscapeKeyDefault = 1 << 1
        }

        public enum MessageBoxColorType
        {
            Background,
            Text,
            ButtonBorder,
            ButtonBackground,
            ButtonSelected,
            Max
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct MessageBoxButtonData
        {
            public MessageBoxButtonFlags Flags;
            public int ButtonID;
            public byte* Text;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MessageBoxColor
        {
            public byte R;
            public byte G;
            public byte B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MessageBoxColorScheme
        {
            public MessageBoxColor* Colors;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct MessageBoxData
        {
            public MessageBoxFlags Flags;
            public Window Window;
            public byte* Title;
            public byte* Message;
            public int NumButtons;
            public MessageBoxButtonData* Buttons;
            public MessageBoxColorScheme* ColorScheme;
        }

        [DllImport("SDL2", EntryPoint = "SDL_ShowMessageBox")]
        public static extern int ShowMessageBox(ref MessageBoxData messageBoxData, out int buttonID);
        [DllImport("SDL2", EntryPoint = "SDL_ShowSimpleMessageBox")]
        public static extern int ShowSimpleMessageBox(MessageBoxFlags flags, byte* title, byte* message, Window window);

        //
        // SDL_mouse.h
        //
        public enum SystemCursor
        {
            Arrow,
            IBeam,
            Wait,
            Crosshair,
            WaitArrow,
            SizeNWSE,
            SizeNESW,
            SizeWE,
            SizeNS,
            SizeAll,
            No,
            Hand,
            Count
        }

        public enum MouseWheelDirection
        {
            Normal,
            Flipped
        }

        public enum MouseButton : byte
        {
            Left = 1,
            Middle = 2,
            Right = 3,
            X1 = 4,
            X2 = 5,
        }

        [Flags]
        public enum MouseButtonState : uint
        {
            Left = 1 << 0,
            Middle = 1 << 1,
            Right = 1 << 2,
            X1 = 1 << 3,
            X2 = 1 << 4
        }

        public struct Cursor
        {
            public IntPtr Handle;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetMouseFocus")]
        public static extern Window GetMouseFocus();
        [DllImport("SDL2", EntryPoint = "SDL_GetMouseState")]
        public static extern MouseButtonState GetMouseState(out int x, out int y);
        [DllImport("SDL2", EntryPoint = "SDL_GetGlobalMouseState")]
        public static extern MouseButtonState GetGlobalMouseState(out int x, out int y);
        [DllImport("SDL2", EntryPoint = "SDL_GetRelativeMouseState")]
        public static extern MouseButtonState GetRelativeMouseState(out int x, out int y);
        [DllImport("SDL2", EntryPoint = "SDL_WarpMouseInWindow")]
        public static extern void WarpMouseInWindow(Window window, int x, int y);
        [DllImport("SDL2", EntryPoint = "SDL_WarpMouseGlobal")]
        public static extern int WarpMouseGlobal(int x, int y);
        [DllImport("SDL2", EntryPoint = "SDL_SetRelativeMouseMode")]
        public static extern int SetRelativeMouseMode(bool enabled);
        [DllImport("SDL2", EntryPoint = "SDL_CaptureMouse")]
        public static extern int CaptureMouse(bool enabled);
        [DllImport("SDL2", EntryPoint = "SDL_GetRelativeMouseMode")]
        public static extern bool GetRelativeMouseMode();
        [DllImport("SDL2", EntryPoint = "SDL_CreateCursor")]
        public static extern Cursor CreateCursor(byte* data, byte* mask, int w, int h, int hotX, int hotY);
        [DllImport("SDL2", EntryPoint = "SDL_CreateColorCursor")]
        public static extern Cursor CreateColorCursor(Surface surface, int hotX, int hotY);
        [DllImport("SDL2", EntryPoint = "SDL_CreateSystemCursor")]
        public static extern Cursor CreateSystemCursor(SystemCursor id);
        [DllImport("SDL2", EntryPoint = "SDL_SetCursor")]
        public static extern void SetCursor(Cursor cursor);
        [DllImport("SDL2", EntryPoint = "SDL_GetCursor")]
        public static extern Cursor GetCursor();
        [DllImport("SDL2", EntryPoint = "SDL_GetDefaultCursor")]
        public static extern Cursor GetDefaultCursor();
        [DllImport("SDL2", EntryPoint = "SDL_FreeCursor")]
        public static extern void FreeCursor(Cursor cursor);
        [DllImport("SDL2", EntryPoint = "SDL_ShowCursor")]
        public static extern State ShowCursor(State toggle);

        //
        // SDL_pixels.h
        //
        public enum PixelType : uint
        {
            Unknown,
            Index1,
            Index4,
            Index8,
            Packed8,
            Packed16,
            Packed32,
            ArrayU8,
            ArrayU16,
            ArrayU32,
            ArrayF16,
            ArrayF32
        }

        public enum PixelOrder : uint
        {
            BitmapNone = 0,
            Bitmap4321,
            Bitmap1234,

            PackedNone = 0,
            PackedXRGB,
            PackedRGBX,
            PackedARGB,
            PackedRGBA,
            PackedXBGR,
            PackedBGRX,
            PackedABGR,
            PackedBGRA,

            ArrayNone = 0,
            ArrayRGB,
            ArrayRGBA,
            ArrayARGB,
            ArrayBGR,
            ArrayBGRA,
            ArrayABGR
        }

        public enum PackedLayout : uint
        {
            None,
            Layout332,
            Layout4444,
            Layout1555,
            Layout5551,
            Layout565,
            Layout8888,
            Layout2101010,
            Layout1010102
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Color
        {
            public byte R;
            public byte G;
            public byte B;
            public byte A;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Palette
        {
            public int NumColors;
            public Color* Colors;
            public uint Version;
            public int RefCount;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct PixelFormat
        {
            public uint Format;
            public IntPtr Palette;
            public byte BitsPerPixel;
            public byte BytesPerPixel;
            public fixed byte Padding[2];
            public uint RMask;
            public uint GMask;
            public uint BMask;
            public uint AMask;
            public byte RLoss;
            public byte GLoss;
            public byte BLoss;
            public byte ALoss;
            public byte RShift;
            public byte GShift;
            public byte BShift;
            public byte AShift;
            public int RefCount;
            public IntPtr Next;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetPixelFormatName")]
        public static extern byte* GetPixelFormatName(uint format);
        [DllImport("SDL2", EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public static extern bool PixelFormatEnumToMasks(uint format, out int bpp, out uint rMask, out uint gMask, out uint bMask, out uint aMask);
        [DllImport("SDL2", EntryPoint = "SDL_MasksToPixelFormatEnum")]
        public static extern uint MasksToPixelFormatEnum(int bpp, uint rMask, uint gMask, uint bMask, uint aMask);
        [DllImport("SDL2", EntryPoint = "SDL_AllocFormat")]
        public static extern PixelFormat* AllocFormat(uint pixelFormat);
        [DllImport("SDL2", EntryPoint = "SDL_FreeFormat")]
        public static extern void FreeFormat(ref PixelFormat pixelFormat);
        [DllImport("SDL2", EntryPoint = "SDL_AllocPalette")]
        public static extern IntPtr AllocPalette(int numColors);
        [DllImport("SDL2", EntryPoint = "SDL_SetPixelFormatPalette")]
        public static extern int SetPixelFormatPalette(ref PixelFormat format, ref Palette palette);
        [DllImport("SDL2", EntryPoint = "SDL_SetPaletteColors")]
        public static extern int SetPaletteColors(Palette palette, Color* colors, int firstColor, int numColors);
        [DllImport("SDL2", EntryPoint = "SDL_FreePalette")]
        public static extern void FreePalette(Palette palette);
        [DllImport("SDL2", EntryPoint = "SDL_MapRgb")]
        public static extern uint MapRgb(ref PixelFormat format, byte r, byte g, byte b);
        [DllImport("SDL2", EntryPoint = "SDL_MapRgba")]
        public static extern uint MapRgba(ref PixelFormat format, byte r, byte g, byte b, byte a);
        [DllImport("SDL2", EntryPoint = "SDL_GetRgb")]
        public static extern void GetRgb(uint pixel, ref PixelFormat format, out byte r, out byte g, out byte b);
        [DllImport("SDL2", EntryPoint = "SDL_GetRgba")]
        public static extern void GetRgba(uint pixel, ref PixelFormat format, out byte r, out byte g, out byte b, out byte a);
        [DllImport("SDL2", EntryPoint = "SDL_CalculateGammaRamp")]
        public static extern void CalculateGammaRamp(float gamma, out ushort* ramp);

        //
        // SDL_platform.h
        //
        [DllImport("SDL2", EntryPoint = "SDL_GetPlatform")]
        public static extern byte* GetPlatform();

        //
        // SDL_power.h
        //
        public enum PowerState
        {
            Unknown,
            OnBattery,
            NoBattery,
            Charging,
            Charged
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetPowerInfo")]
        public static extern PowerState GetPowerInfo(out int seconds, out int percentage);

        //
        // SDL_rect.h
        //
        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public int X;
            public int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int X;
            public int Y;
            public int W;
            public int H;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool PointInRect(ref Point p, ref Rect r)
        {
            return ((p.X >= r.X) && (p.X < (r.X + r.W)) &&
                    (p.Y >= r.Y) && (p.Y < (r.Y + r.H))) ? true : false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool RectEmpty(ref Rect r)
        {
            return ((r.W <= 0) || (r.H <= 0)) ? true : false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool RectEquals(ref Rect a, ref Rect b)
        {
            return ((a.X == b.X) && (a.Y == b.Y) &&
                    (a.W == b.W) && (a.H == b.H)) ? true : false;
        }

        [DllImport("SDL2", EntryPoint = "SDL_HasIntersection")]
        public static extern bool HasIntersection(ref Rect a, ref Rect b);
        [DllImport("SDL2", EntryPoint = "SDL_IntersectRect")]
        public static extern bool IntersectRect(ref Rect a, ref Rect b, out Rect result);
        [DllImport("SDL2", EntryPoint = "SDL_UnionRect")]
        public static extern void UnionRect(ref Rect a, ref Rect b, out Rect result);
        [DllImport("SDL2", EntryPoint = "SDL_EnclosePoints")]
        public static extern bool EnclosePoints(Point* points, int count, ref Rect clip, out Rect result);
        [DllImport("SDL2", EntryPoint = "SDL_IntersectRectAndLine")]
        public static extern bool IntersectRectAndLine(ref Rect rectangle, ref int x1, ref int y1, ref int x2, ref int y2);

        //
        // SDL_render.h
        //
        [Flags]
        public enum RendererFlags
        {
            Software = 1 << 0,
            Accelerated = 1 << 1,
            PresentVSync = 1 << 2,
            TargetTexture = 1 << 3
        }

        public enum TextureAccess
        {
            Static,
            Streaming,
            Target
        }

        [Flags]
        public enum TextureModulate
        {
            None = 0,
            Horizontal = 1 << 0,
            Vertical = 1 << 1
        }

        [Flags]
        public enum RendererFlip
        {
            None = 0,
            Horizontal = 1 << 0,
            Vertical = 1 << 1
        }

        public struct Renderer
        {
            public IntPtr Handle;
        }

        public struct Texture
        {
            public IntPtr Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct RendererInfo
        {
            public byte* Name;
            public RendererFlags Flags;
            public uint NumTextureFormats;
            public fixed uint TextureFormats[16];
            public int MaxTextureWidth;
            public int MaxTextureHeight;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetNumRenderDrivers")]
        public static extern int GetNumRenderDrivers();
        [DllImport("SDL2", EntryPoint = "SDL_GetRenderDriverInfo")]
        public static extern int GetRenderDriverInfo(int index, out RendererInfo info);
        [DllImport("SDL2", EntryPoint = "SDL_CreateWindowAndRenderer")]
        public static extern int CreateWindowAndRenderer(int width, int height, WindowFlags windowFlags, out Window window, out Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_CreateRenderer")]
        public static extern Renderer CreateRenderer(Window window, int index, RendererFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_CreateSoftwareRenderer")]
        public static extern Renderer CreateSoftwareRenderer(Surface surface);
        [DllImport("SDL2", EntryPoint = "SDL_GetRenderer")]
        public static extern Renderer GetRenderer(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_GetRendererInfo")]
        public static extern int GetRendererInfo(Renderer renderer, out RendererInfo info);
        [DllImport("SDL2", EntryPoint = "SDL_GetRendererOutputSize")]
        public static extern int GetRendererOutputSize(Renderer renderer, out int w, out int h);
        [DllImport("SDL2", EntryPoint = "SDL_CreateTexture")]
        public static extern Texture CreateTexture(Renderer renderer, uint format, int access, int w, int h);
        [DllImport("SDL2", EntryPoint = "SDL_CreateTextureFromSurface")]
        public static extern Texture CreateTextureFromSurface(Renderer renderer, Surface surface);
        [DllImport("SDL2", EntryPoint = "SDL_QueryTexture")]
        public static extern int QueryTexture(Texture texture, out uint format, out int access, out int w, out int h);
        [DllImport("SDL2", EntryPoint = "SDL_SetTextureColorMod")]
        public static extern int SetTextureColorMod(Texture texture, byte r, byte g, byte b);
        [DllImport("SDL2", EntryPoint = "SDL_GetTextureColorMod")]
        public static extern int GetTextureColorMod(Texture texture, out byte r, out byte g, out byte b);
        [DllImport("SDL2", EntryPoint = "SDL_SetTextureAlphaMod")]
        public static extern int SetTextureAlphaMod(Texture texture, byte alpha);
        [DllImport("SDL2", EntryPoint = "SDL_GetTextureAlphaMod")]
        public static extern int GetTextureAlphaMod(Texture texture, out byte alpha);
        [DllImport("SDL2", EntryPoint = "SDL_SetTextureBlendMode")]
        public static extern int SetTextureBlendMode(Texture texture, BlendMode blendMode);
        [DllImport("SDL2", EntryPoint = "SDL_GetTextureBlendMode")]
        public static extern int GetTextureBlendMode(Texture texture, out BlendMode blendMode);
        [DllImport("SDL2", EntryPoint = "SDL_UpdateTexture")]
        public static extern int UpdateTexture(Texture texture, ref Rect rect, IntPtr pixels, int pitch);
        [DllImport("SDL2", EntryPoint = "SDL_UpdateYUVTexture")]
        public static extern int UpdateYUVTexture(Texture texture, ref Rect rect, byte* yPlane, int yPitch, byte* uPlane, int uPitch, byte* vPlane, int vPitch);
        [DllImport("SDL2", EntryPoint = "SDL_LockTexture")]
        public static extern int LockTexture(Texture texture, ref Rect rect, out IntPtr pixels, out int pitch);
        [DllImport("SDL2", EntryPoint = "SDL_UnlockTexture")]
        public static extern void UnlockTexture(Texture texture);
        [DllImport("SDL2", EntryPoint = "SDL_RenderTargetSupported")]
        public static extern bool RenderTargetSupported(Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_SetRenderTarget")]
        public static extern int SetRenderTarget(Renderer renderer, Texture texture);
        [DllImport("SDL2", EntryPoint = "SDL_GetRenderTarget")]
        public static extern Texture GetRenderTarget(Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_RenderSetLogicalSize")]
        public static extern int RenderSetLogicalSize(Renderer renderer, int w, int h);
        [DllImport("SDL2", EntryPoint = "SDL_RenderGetLogicalSize")]
        public static extern void RenderGetLogicalSize(Renderer renderer, out int w, out int h);
        [DllImport("SDL2", EntryPoint = "SDL_RenderSetIntegerScale")]
        public static extern int RenderSetIntegerScale(Renderer renderer, bool enable);
        [DllImport("SDL2", EntryPoint = "SDL_RenderGetIntegerScale")]
        public static extern bool RenderGetIntegerScale(Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_RenderSetViewport")]
        public static extern int RenderSetViewport(Renderer renderer, ref Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderGetViewport")]
        public static extern void RenderGetViewport(Renderer renderer, out Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderSetClipRect")]
        public static extern int RenderSetClipRect(Renderer renderer, ref Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderGetClipRect")]
        public static extern void RenderGetClipRect(Renderer renderer, out Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderIsClipEnabled")]
        public static extern bool RenderIsClipEnabled(Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_RenderSetScale")]
        public static extern int RenderSetScale(Renderer renderer, float scaleX, float scaleY);
        [DllImport("SDL2", EntryPoint = "SDL_RenderGetScale")]
        public static extern void RenderGetScale(Renderer renderer, out float scaleX, out float scaleY);
        [DllImport("SDL2", EntryPoint = "SDL_SetRenderDrawColor")]
        public static extern int SetRenderDrawColor(Renderer renderer, byte r, byte g, byte b, byte a);
        [DllImport("SDL2", EntryPoint = "SDL_GetRenderDrawColor")]
        public static extern int GetRenderDrawColor(Renderer renderer, out byte r, out byte g, out byte b, out byte a);
        [DllImport("SDL2", EntryPoint = "SDL_SetRenderDrawBlendMode")]
        public static extern int SetRenderDrawBlendMode(Renderer renderer, BlendMode blendMode);
        [DllImport("SDL2", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public static extern int GetRenderDrawBlendMode(Renderer renderer, out BlendMode blendMode);
        [DllImport("SDL2", EntryPoint = "SDL_RenderClear")]
        public static extern int RenderClear(Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_RenderDrawPoint")]
        public static extern int RenderDrawPoint(Renderer renderer, int x, int y);
        [DllImport("SDL2", EntryPoint = "SDL_RenderDrawPoints")]
        public static extern int RenderDrawPoints(Renderer renderer, Point* points, int count);
        [DllImport("SDL2", EntryPoint = "SDL_RenderDrawLine")]
        public static extern int RenderDrawLine(Renderer renderer, int x1, int y1, int x2, int y2);
        [DllImport("SDL2", EntryPoint = "SDL_RenderDrawLines")]
        public static extern int RenderDrawLines(Renderer renderer, Point* points, int count);
        [DllImport("SDL2", EntryPoint = "SDL_RenderDrawRect")]
        public static extern int RenderDrawRect(Renderer renderer, ref Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderDrawRects")]
        public static extern int RenderDrawRects(Renderer renderer, Rect* rects, int count);
        [DllImport("SDL2", EntryPoint = "SDL_RenderFillRect")]
        public static extern int RenderFillRect(Renderer renderer, ref Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderFillRects")]
        public static extern int RenderFillRects(Renderer renderer, Rect* rects, int count);
        [DllImport("SDL2", EntryPoint = "SDL_RenderCopy")]
        public static extern int RenderCopy(Renderer renderer, Texture texture, ref Rect srcRect, ref Rect dstRect);
        [DllImport("SDL2", EntryPoint = "SDL_RenderCopyEx")]
        public static extern int RenderCopyEx(Renderer renderer, Texture texture, ref Rect srcRect, ref Rect dstRect, double angle, ref Point center, RendererFlip flip);
        [DllImport("SDL2", EntryPoint = "SDL_RenderReadPixels")]
        public static extern int RenderReadPixels(Renderer renderer, ref Rect rect, uint format, IntPtr pixels, int pitch);
        [DllImport("SDL2", EntryPoint = "SDL_RenderPresent")]
        public static extern void RenderPresent(Renderer renderer);
        [DllImport("SDL2", EntryPoint = "SDL_DestroyTexture")]
        public static extern void DestroyTexture(Texture texture);
        [DllImport("SDL2", EntryPoint = "SDL_DestroyRenderer")]
        public static extern void DestroyRenderer(Renderer renderer);

        //
        // SDL_rwops.h
        //
        public struct RWops
        {
            public IntPtr Handle;
        }

        [DllImport("SDL2", EntryPoint = "SDL_RWFromFile")]
        public static extern RWops RWFromFile(byte* file, byte* mode);

        //
        // SDL_scancode.h
        //
        public enum Scancode
        {
            Unknown = 0,

            A = 4,
            B = 5,
            C = 6,
            D = 7,
            E = 8,
            F = 9,
            G = 10,
            H = 11,
            I = 12,
            J = 13,
            K = 14,
            L = 15,
            M = 16,
            N = 17,
            O = 18,
            P = 19,
            Q = 20,
            R = 21,
            S = 22,
            T = 23,
            U = 24,
            V = 25,
            W = 26,
            X = 27,
            Y = 28,
            Z = 29,

            Alpha1 = 30,
            Alpha2 = 31,
            Alpha3 = 32,
            Alpha4 = 33,
            Alpha5 = 34,
            Alpha6 = 35,
            Alpha7 = 36,
            Alpha8 = 37,
            Alpha9 = 38,
            Alpha0 = 39,

            Return = 40,
            Escape = 41,
            Backspace = 42,
            Tab = 43,
            Space = 44,

            Minus = 45,
            Equals = 46,
            LeftBracket = 47,
            RightBracket = 48,
            Backslash = 49,
            NonUSHash = 50,
            Semicolon = 51,
            Apostrophe = 52,
            Grave = 53,
            Comma = 54,
            Period = 55,
            Slash = 56,

            Capslock = 57,

            F1 = 58,
            F2 = 59,
            F3 = 60,
            F4 = 61,
            F5 = 62,
            F6 = 63,
            F7 = 64,
            F8 = 65,
            F9 = 66,
            F10 = 67,
            F11 = 68,
            F12 = 69,

            Printscreen = 70,
            ScrollLock = 71,
            Pause = 72,
            Insert = 73,
            Home = 74,
            PageUp = 75,
            Delete = 76,
            End = 77,
            PageDown = 78,
            Right = 79,
            Left = 80,
            Down = 81,
            Up = 82,

            NumlockClear = 83,
            NumDivide = 84,
            NumMultiply = 85,
            NumMinus = 86,
            NumPlus = 87,
            NumEnter = 88,
            Num1 = 89,
            Num2 = 90,
            Num3 = 91,
            Num4 = 92,
            Num5 = 93,
            Num6 = 94,
            Num7 = 95,
            Num8 = 96,
            Num9 = 97,
            Num0 = 98,
            NumPeriod = 99,

            NonUSBackslash = 100,
            Application = 101,
            Power = 102,
            NumEquals = 103,
            F13 = 104,
            F14 = 105,
            F15 = 106,
            F16 = 107,
            F17 = 108,
            F18 = 109,
            F19 = 110,
            F20 = 111,
            F21 = 112,
            F22 = 113,
            F23 = 114,
            F24 = 115,
            Execute = 116,
            Help = 117,
            Menu = 118,
            Select = 119,
            Stop = 120,
            Again = 121,
            Undo = 122,
            Cut = 123,
            Copy = 124,
            Paste = 125,
            Find = 126,
            Mute = 127,
            VolumeUp = 128,
            VolumeDown = 129,
            NumComma = 133,
            NumEqualsAs400 = 134,

            International1 = 135,
            International2 = 136,
            International3 = 137,
            International4 = 138,
            International5 = 139,
            International6 = 140,
            International7 = 141,
            International8 = 142,
            International9 = 143,
            Lang1 = 144,
            Lang2 = 145,
            Lang3 = 146,
            Lang4 = 147,
            Lang5 = 148,
            Lang6 = 149,
            Lang7 = 150,
            Lang8 = 151,
            Lang9 = 152,

            AltErase = 153,
            SysReq = 154,
            Cancel = 155,
            Clear = 156,
            Prior = 157,
            Return2 = 158,
            Separator = 159,
            Out = 160,
            Oper = 161,
            ClearAgain = 162,
            CRSel = 163,
            EXSel = 164,

            Num00 = 176,
            Num000 = 177,
            ThousandsSeparator = 178,
            DecimalSeparator = 179,
            CurrencyUnit = 180,
            CurrencySubUnit = 181,
            NumLeftParen = 182,
            NumRightParen = 183,
            NumLeftBrace = 184,
            NumRightBrace = 185,
            NumTab = 186,
            NumBackspace = 187,
            NumA = 188,
            NumB = 189,
            NumC = 190,
            NumD = 191,
            NumE = 192,
            NumF = 193,
            NumXor = 194,
            NumPower = 195,
            NumPercent = 196,
            NumLess = 197,
            NumGreater = 198,
            NumAmpersand = 199,
            NumDoubleAmpersand = 200,
            NumVerticalBar = 201,
            NumDoubleVerticalBar = 202,
            NumColon = 203,
            NumHash = 204,
            NumSpace = 205,
            NumAt = 206,
            NumExclam = 207,
            NumMemStore = 208,
            NumMemRecall = 209,
            NumMemClear = 210,
            NumMemAdd = 211,
            NumMemSubtract = 212,
            NumMemMultiply = 213,
            NumMemDivide = 214,
            NumPlusMinus = 215,
            NumClear = 216,
            NumClearEntry = 217,
            NumBinary = 218,
            NumOctal = 219,
            NumDecimal = 220,
            NumHexadecimal = 221,

            LeftControl = 224,
            LeftShift = 225,
            LeftAlt = 226,
            LeftGUI = 227,
            RightControl = 228,
            RightShift = 229,
            RightAlt = 230,
            RightGUI = 231,

            Mode = 257,

            AudioNext = 258,
            AudioPrevious = 259,
            AudioStop = 260,
            AudioPlay = 261,
            AudioMute = 262,
            MediaSelect = 263,
            WWW = 264,
            Mail = 265,
            Calculator = 266,
            Computer = 267,
            ACSearch = 268,
            ACHome = 269,
            ACBack = 270,
            ACForward = 271,
            ACStop = 272,
            ACRefresh = 273,
            ACBookmark = 274,

            BrightnessDown = 275,
            BrightnessUp = 276,
            DisplaySwitch = 277,
            KeyboardLightToggle = 278,
            KeyboardLightDown = 279,
            KeyboardLightUp = 280,
            Eject = 281,
            Sleep = 282,

            App1 = 283,
            App2 = 284,

            NumScancodes = 512
        }

        //
        // SDL_shape.h
        //
        public enum WindowShapeMode
        {
            Default,
            BinarizeAlpha,
            ReverseBinarizeAlpha,
            ColorKey
        }

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public struct WindowShapeParams
        {
            [FieldOffset(0)] public byte BinarizationCutoff;
            [FieldOffset(0)] public Color ColorKey;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowShape
        {
            public WindowShapeMode Mode;
            public WindowShapeParams Parameters;
        }

        [DllImport("SDL2", EntryPoint = "SDL_CreateShapedWindow")]
        public static extern Window CreateShapedWindow(byte* title, uint x, uint y, uint w, uint h, WindowFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_IsShapedWindow")]
        public static extern bool IsShapedWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowShape")]
        public static extern int SetWindowShape(Window window, ref Surface shape, ref WindowShape shapeMode);
        [DllImport("SDL2", EntryPoint = "SDL_GetShapedWindowMode")]
        public static extern int GetShapedWindowMode(Window window, out WindowShape shapeMode);

        //
        // SDL_stdinc.h
        // 
        [DllImport("SDL2", EntryPoint = "SDL_malloc")]
        public static extern void* Malloc(ulong size);
        [DllImport("SDL2", EntryPoint = "SDL_calloc")]
        public static extern void* Calloc(ulong nmemb, ulong size);
        [DllImport("SDL2", EntryPoint = "SDL_realloc")]
        public static extern void* Realloc(void* memory, ulong size);
        [DllImport("SDL2", EntryPoint = "SDL_free")]
        public static extern void Free(void* memory);

        //
        // SDL_surface.h
        //
        public delegate int Blit(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect);

        [Flags]
        public enum SurfaceFlags : uint
        {
            Software = 0,
            PreAllocated = 1 << 0,
            EncodedRLE = 1 << 1,
            DontFree = 1 << 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct Surface
        {
            public uint Flags;
            public PixelFormat* Format;
            public int W;
            public int H;
            public int Pitch;
            public void* Pixels;
            public void* UserData;
            public int Locked;
            public void* LockData;
            public Rect ClipRect;
            private IntPtr Map;
            public int RefCount;
        }

        [DllImport("SDL2", EntryPoint = "SDL_CreateRGBSurface")]
        public static extern Surface* CreateRGBSurface(uint flags, int width, int height, int depth, uint rMask, uint gMask, uint bMask, uint aMask);
        [DllImport("SDL2", EntryPoint = "SDL_CreateRGBSurfaceWithFormat")]
        public static extern Surface* CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);
        [DllImport("SDL2", EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public static extern Surface* CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint rMask, uint gMask, uint bMask, uint aMask);
        [DllImport("SDL2", EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom")]
        public static extern Surface* CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format);
        [DllImport("SDL2", EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public static extern void FreeSurface(Surface* surface);
        [DllImport("SDL2", EntryPoint = "SDL_SetSurfacePalette")]
        public static extern int SetSurfacePalette(Surface* surface, Palette* palette);
        [DllImport("SDL2", EntryPoint = "SDL_LockSurface")]
        public static extern int LockSurface(Surface* surface);
        [DllImport("SDL2", EntryPoint = "SDL_UnlockSurface")]
        public static extern void UnlockSurface(Surface* surface);
        [DllImport("SDL2", EntryPoint = "SDL_LoadBMP_RW")]
        public static extern Surface* LoadBmpRW(RWops src, int freeSrc);

        public static Surface* LoadBmp(byte* file)
        {
            byte* rb = Utf8.AllocateFromString("rb");
            Surface* result = LoadBmpRW(RWFromFile(file, rb), 1);
            Utf8.Free(rb);
            return result;
        }

        [DllImport("SDL2", EntryPoint = "SDL_SaveBMP_RW")]
        public static extern int SaveBmpRW(Surface* surface, RWops dst, int freeDst);

        public static int SaveBmp(Surface* surface, byte* file)
        {
            byte* wb = Utf8.AllocateFromString("wb");
            int result = SaveBmpRW(surface, RWFromFile(file, wb), 1);
            Utf8.Free(wb);
            return result;
        }

        [DllImport("SDL2", EntryPoint = "SDL_SetSurfaceRLE")]
        public static extern int SetSurfaceRLE(Surface* surface, int flag);
        [DllImport("SDL2", EntryPoint = "SDL_SetColorKey")]
        public static extern int SetColorKey(Surface* surface, int flag, uint key);
        [DllImport("SDL2", EntryPoint = "SDL_GetColorKey")]
        public static extern int GetColorKey(Surface* surface, out uint key);
        [DllImport("SDL2", EntryPoint = "SDL_SetSurfaceColorMod")]
        public static extern int SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);
        [DllImport("SDL2", EntryPoint = "SDL_GetSurfaceColorMod")]
        public static extern int GetSurfaceColorMod(Surface* surface, out byte r, out byte g, out byte b);
        [DllImport("SDL2", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        public static extern int SetSurfaceAlphaMod(Surface* surface, byte alpha);
        [DllImport("SDL2", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public static extern int GetSurfaceAlphaMod(Surface* surface, out byte alpha);
        [DllImport("SDL2", EntryPoint = "SDL_SetSurfaceBlendMode")]
        public static extern int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);
        [DllImport("SDL2", EntryPoint = "SDL_GetSurfaceBlendMode")]
        public static extern int GetSurfaceBlendMode(Surface* surface, out BlendMode blendMode);
        [DllImport("SDL2", EntryPoint = "SDL_SetClipRect")]
        public static extern bool SetClipRect(Surface* surface, ref Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_GetClipRect")]
        public static extern void GetClipRect(Surface* surface, out Rect rect);
        [DllImport("SDL2", EntryPoint = "SDL_DuplicateSurface")]
        public static extern Surface* DuplicateSurface(Surface* surface);
        [DllImport("SDL2", EntryPoint = "SDL_ConvertSurface")]
        public static extern Surface* ConvertSurface(Surface* src, PixelFormat* format, uint flags);
        [DllImport("SDL2", EntryPoint = "SDL_ConvertSurfaceFormat")]
        public static extern Surface* ConvertSurfaceFormat(Surface* src, uint pixel_format, uint flags);
        [DllImport("SDL2", EntryPoint = "SDL_ConvertPixels")]
        public static extern int ConvertPixels(int width, int height, uint srcFormat, Surface* src, int srcPitch, uint dstFormat, Surface* dst, int dstPitch);
        [DllImport("SDL2", EntryPoint = "SDL_FillRect")]
        public static extern int FillRect(Surface* dst, ref Rect rect, uint color);
        [DllImport("SDL2", EntryPoint = "SDL_FillRects")]
        public static extern int FillRects(Surface* dst, Rect* rects, int count, uint color);

        public static int BlitSurface(Surface* src, ref Rect srcRect, Surface* dst, Rect* dstRect) => UpperBlit(src, ref srcRect, dst, dstRect);

        [DllImport("SDL2", EntryPoint = "SDL_UpperBlit")]
        public static extern int UpperBlit(Surface* src, ref Rect srcRect, Surface* dst, Rect* dstRect);
        [DllImport("SDL2", EntryPoint = "SDL_LowerBlit")]
        public static extern int LowerBlit(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect);
        [DllImport("SDL2", EntryPoint = "SDL_SoftStretch")]
        public static extern int SoftStretch(Surface* src, ref Rect srcRect, Surface* dst, ref Rect dstRect);

        public static int BlitScaled(Surface* src, ref Rect srcRect, Surface* dst, Rect* dstRect) => UpperBlitScaled(src, ref srcRect, dst, dstRect);

        [DllImport("SDL2", EntryPoint = "SDL_UpperBlitScaled")]
        public static extern int UpperBlitScaled(Surface* src, ref Rect srcRect, Surface* dst, Rect* dstRect);
        [DllImport("SDL2", EntryPoint = "SDL_LowerBlitScaled")]
        public static extern int LowerBlitScaled(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect);

        //
        // SDL_syswm.h
        //
        public enum SysWMType
        {
            Unknown,
            Windows,
            X11,
            DirectFB,
            Cocoa,
            UIKit,
            Wayland,
            Mir,
            WinRT,
            Android,
            Vivante,
            OS2
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SysWMInfo
        {
            [StructLayout(LayoutKind.Explicit)]
            public struct InfoUnion
            {
                [StructLayout(LayoutKind.Sequential)]
                public struct WindowsInfo
                {
                    public IntPtr Window;
                    public IntPtr Hdc;
                    public IntPtr HInstance;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct WinRTInfo
                {
                    public IntPtr Window;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct X11Info
                {
                    public IntPtr Display;
                    public IntPtr Window;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct DirectFBInfo
                {
                    public IntPtr DirectFB;
                    public IntPtr Window;
                    public IntPtr Surface;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct CocoaInfo
                {
                    public IntPtr Window;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct UIKitInfo
                {
                    public IntPtr Window;
                    public uint FrameBuffer;
                    public uint ColorBuffer;
                    public uint ResolveFrameBuffer;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct WaylandInfo
                {
                    public IntPtr Display;
                    public IntPtr Surface;
                    public IntPtr ShellSurface;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct MirInfo
                {
                    public IntPtr Connection;
                    public IntPtr Surface;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct AndroidInfo
                {
                    public IntPtr Window;
                    public IntPtr Surface;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct VivanteInfo
                {
                    public IntPtr Display;
                    public IntPtr Window;
                }

                [FieldOffset(0)] public WindowsInfo Windows;
                [FieldOffset(0)] public WinRTInfo WinRT;
                [FieldOffset(0)] public X11Info X11;
                [FieldOffset(0)] public DirectFBInfo DirectFB;
                [FieldOffset(0)] public CocoaInfo Cocoa;
                [FieldOffset(0)] public UIKitInfo UIKit;
                [FieldOffset(0)] public WaylandInfo Wayland;
                [FieldOffset(0)] public MirInfo Mir;
                [FieldOffset(0)] public AndroidInfo Android;
                [FieldOffset(0)] public VivanteInfo Vivante;
            }

            public Version Version;
            public SysWMType SubSystem;
            public InfoUnion Info;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetWindowWMInfo")]
        public static extern bool GetWindowWMInfo(Window window, ref SysWMInfo info);

        //
        // SDL_timer.h
        //
        public delegate TimerID TimerCallback(uint interval, IntPtr param);

        [StructLayout(LayoutKind.Sequential)]
        public struct TimerID
        {
            public int ID;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetTicks")]
        public static extern uint GetTicks();

        public static bool TicksPassed(uint a, uint b) => ((int)(b - a) <= 0);

        [DllImport("SDL2", EntryPoint = "SDL_GetPerformanceCounter")]
        public static extern ulong GetPerformanceCounter();
        [DllImport("SDL2", EntryPoint = "SDL_GetPerformanceFrequency")]
        public static extern ulong GetPerformanceFrequency();
        [DllImport("SDL2", EntryPoint = "SDL_Delay")]
        public static extern void Delay(uint ms);
        [DllImport("SDL2", EntryPoint = "SDL_AddTimer")]
        public static extern TimerID AddTimer(uint interval, TimerCallback callback, IntPtr param);
        [DllImport("SDL2", EntryPoint = "SDL_RemoveTimer")]
        public static extern bool RemoveTimer(TimerID id);

        //
        // SDL_touch.h
        //
        public static uint TouchMouseID
        {
            get
            {
                unchecked
                {
                    return (uint)-1;
                }
            }
        }

        public struct TouchID
        {
            public long Handle;
        }

        public struct FingerID
        {
            public long Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Finger
        {
            public FingerID Id;
            public float X;
            public float Y;
            public float Pressure;
        }

        [DllImport("SDL2", EntryPoint = "SDL_GetNumTouchDevices")]
        public static extern int GetNumTouchDevices();
        [DllImport("SDL2", EntryPoint = "SDL_GetTouchDevice")]
        public static extern TouchID GetTouchDevice(int index);
        [DllImport("SDL2", EntryPoint = "SDL_GetNumTouchFingers")]
        public static extern int GetNumTouchFingers(TouchID touchID);
        [DllImport("SDL2", EntryPoint = "SDL_GetTouchFinger")]
        public static extern Finger* GetTouchFinger(TouchID touchID, int index);

        //
        // SDL_version.h
        //
        [StructLayout(LayoutKind.Sequential)]
        public struct Version
        {
            public byte Major;
            public byte Minor;
            public byte Patch;

            public const int MajorVersion = 2;
            public const int MinorVersion = 0;
            public const int PatchLevel = 6;

            public static Version Current => new Version(MajorVersion, MinorVersion, PatchLevel);

            public Version(byte major, byte minor, byte patch)
            {
                Major = major;
                Minor = minor;
                Patch = patch;
            }
        }

        public static int VersionNum(int x, int y, int z) => x * 1000 + y * 100 + z;
        public static int CompiledVersion() => VersionNum(Version.MajorVersion, Version.MinorVersion, Version.PatchLevel);
        public static bool VersionAtLeast(int x, int y, int z) => CompiledVersion() >= VersionNum(x, y, z);
        [DllImport("SDL2", EntryPoint = "SDL_GetVersion")]
        public static extern void GetVersion(out Version version);
        [DllImport("SDL2", EntryPoint = "SDL_GetRevision")]
        public static extern byte* GetRevision();
        [DllImport("SDL2", EntryPoint = "SDL_GetRevisionNumber")]
        public static extern int GetRevisionNumber();

        //
        // SDL_video.h
        //
        public delegate HitTestResult HitTest(Window window, Point* area, void* data);

        [Flags]
        public enum WindowFlags : uint
        {
            Fullscreen = 1 << 0,
            OpenGL = 1 << 1,
            Shown = 1 << 2,
            Hidden = 1 << 3,
            Borderless = 1 << 4,
            Resizable = 1 << 5,
            Minimized = 1 << 6,
            Maximized = 1 << 7,
            InputGrabbed = 1 << 8,
            InputFocus = 1 << 9,
            MouseFocus = 1 << 10,
            FullscreenDeskTop = (Fullscreen | 1 << 12),
            Foreign = 1 << 11,
            AllowHighDPI = 1 << 13,
            MouseCapture = 1 << 14,
            AlwaysOnTop = 1 << 15,
            SkipTaskbar = 1 << 16,
            Utility = 1 << 17,
            Tooltip = 1 << 18,
            PopupMenu = 1 << 19,
            Vulkan = 0x10000000,
        }

        public enum WindowEventID : byte
        {
            None,
            Shown,
            Hidden,
            Exposed,
            Moved,
            Resized,
            SizeChanged,
            Minimized,
            Maximized,
            Restored,
            Enter,
            Leave,
            FocusGained,
            FocusLost,
            Close,
            TakeFocus,
            HitTest
        }

        public enum HitTestResult
        {
            Normal,
            Draggable,
            ResizeTopLeft,
            ResizeTop,
            ResizeTopRight,
            ResizeRight,
            ResizeBottomRight,
            ResizeBottom,
            ResizeBottomLeft,
            ResizeLeft
        }

        public struct Window
        {
            public IntPtr Handle;

            public Window(IntPtr handle)
            {
                Handle = handle;
            }

            public static implicit operator IntPtr(Window window) => window.Handle;
            public static implicit operator Window(IntPtr handle) => new Window(handle);
        }

        public struct WindowID
        {
            public uint Handle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct DisplayMode
        {
            public uint Format;
            public int Width;
            public int Height;
            public int RefreshRate;
            public void* DriverData;
        }

        public const int WindowPositionUndefinedMask = 0x1FFF0000;
        public const int WindowPositionCenteredMask = 0x2FFF0000;
        public const int WindowPositionUndefined = 0x1FFF0000;
        public const int WindowPositionCentered = 0x2FFF0000;

        public static int WindowPositionUndefinedDisplay(int x) => WindowPositionUndefinedMask | x;
        public static bool WindowPositionIsUndefined(int x) => (x & 0xFFFF0000) == WindowPositionUndefinedMask;
        public static int WindowPositionCenteredDisplay(int x) => WindowPositionCenteredMask | x;
        public static bool WindowPositionIsCentered(int x) => (x & 0xFFFF0000) == WindowPositionCenteredMask;

        [DllImport("SDL2", EntryPoint = "SDL_GetNumVideoDrivers")]
        public static extern int GetNumVideoDrivers();
        [DllImport("SDL2", EntryPoint = "SDL_GetVideoDriver")]
        public static extern byte* GetVideoDriver(int index);
        [DllImport("SDL2", EntryPoint = "SDL_VideoInit")]
        public static extern int VideoInit(byte* driverName);
        [DllImport("SDL2", EntryPoint = "SDL_VideoQuit")]
        public static extern void VideoQuit();
        [DllImport("SDL2", EntryPoint = "SDL_GetCurrentVideoDriver")]
        public static extern byte* GetCurrentVideoDriver();
        [DllImport("SDL2", EntryPoint = "SDL_GetNumVideoDisplays")]
        public static extern int GetNumVideoDisplays();
        [DllImport("SDL2", EntryPoint = "SDL_GetDisplayName")]
        public static extern byte* GetDisplayName(int displayIndex);
        [DllImport("SDL2", EntryPoint = "SDL_GetDisplayBounds")]
        public static extern int GetDisplayBounds(int displayIndex, out Rect rectangle);
        [DllImport("SDL2", EntryPoint = "SDL_GetDisplayDpi")]
        public static extern int GetDisplayDpi(int displayIndex, out float ddpi, out float hdpi, out float vdpi);
        [DllImport("SDL2", EntryPoint = "SDL_GetDisplayUsableBounds")]
        public static extern int GetDisplayUsableBounds(int displayIndex, out Rect rectangle);
        [DllImport("SDL2", EntryPoint = "SDL_GetNumDisplayModes")]
        public static extern int GetNumDisplayModes(int displayIndex);
        [DllImport("SDL2", EntryPoint = "SDL_GetDisplayMode")]
        public static extern int GetDisplayMode(int displayIndex, int modeIndex, out DisplayMode mode);
        [DllImport("SDL2", EntryPoint = "SDL_GetDesktopDisplayMode")]
        public static extern int GetDesktopDisplayMode(int displayIndex, out DisplayMode mode);
        [DllImport("SDL2", EntryPoint = "SDL_GetCurrentDisplayMode")]
        public static extern int GetCurrentDisplayMode(int displayIndex, out DisplayMode mode);
        [DllImport("SDL2", EntryPoint = "SDL_GetClosestDisplayMode")]
        public static extern DisplayMode GetClosestDisplayMode(int displayIndex, ref DisplayMode mode, out DisplayMode closest);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowDisplayIndex")]
        public static extern int GetWindowDisplayIndex(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowDisplayMode")]
        public static extern int SetWindowDisplayMode(Window window, ref DisplayMode mode);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowDisplayMode")]
        public static extern int GetWindowDisplayMode(Window window, out DisplayMode mode);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowPixelFormat")]
        public static extern uint GetWindowPixelFormat(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_CreateWindow")]
        public static extern Window CreateWindow(byte* title, int x, int y, int width, int height, WindowFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_CreateWindowFrom")]
        public static extern Window CreateWindowFrom(IntPtr data);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowID")]
        public static extern WindowID GetWindowID(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowFromID")]
        public static extern Window GetWindowFromID(WindowID id);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowFlags")]
        public static extern WindowFlags GetWindowFlags(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowTitle")]
        public static extern void SetWindowTitle(Window window, byte* title);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowTitle")]
        public static extern byte* GetWindowTitle(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowIcon")]
        public static extern void SetWindowIcon(Window window, Surface icon);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowData")]
        public static extern IntPtr SetWindowData(Window window, byte* name, IntPtr userData);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowData")]
        public static extern IntPtr GetWindowData(Window window, byte* name);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowPosition")]
        public static extern void SetWindowPosition(Window window, int x, int y);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowPosition")]
        public static extern void GetWindowPosition(Window window, out int x, out int y);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowSize")]
        public static extern void SetWindowSize(Window window, int width, int height);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowSize")]
        public static extern void GetWindowSize(Window window, out int width, out int height);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowBordersSize")]
        public static extern int GetWindowBordersSize(Window window, out int top, out int left, out int bottom, out int right);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowMinimumSize")]
        public static extern void SetWindowMinimumSize(Window window, int minWidth, int minHeight);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowMinimumSize")]
        public static extern void GetWindowMinimumSize(Window window, out int width, out int height);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowMaximumSize")]
        public static extern void SetWindowMaximumSize(Window window, int maxWidth, int maxHeight);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowMaximumSize")]
        public static extern void GetWindowMaximumSize(Window window, out int width, out int height);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowBordered")]
        public static extern void SetWindowBordered(Window window, bool bordered);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowResizable")]
        public static extern void SetWindowResizable(Window window, bool resizable);
        [DllImport("SDL2", EntryPoint = "SDL_ShowWindow")]
        public static extern void ShowWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_HideWindow")]
        public static extern void HideWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_RaiseWindow")]
        public static extern void RaiseWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_MaximizeWindow")]
        public static extern void MaximizeWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_MinimizeWindow")]
        public static extern void MinimizeWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_RestoreWindow")]
        public static extern void RestoreWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowFullscreen")]
        public static extern int SetWindowFullscreen(Window window, WindowFlags flags);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowSurface")]
        public static extern Surface GetWindowSurface(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_UpdateWindowSurface")]
        public static extern int UpdateWindowSurface(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public static extern int UpdateWindowSurfaceRects(Window window, Rect* rectangles, int numRectangles);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowGrab")]
        public static extern void SetWindowGrab(Window window, bool grabbed);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowGrab")]
        public static extern bool GetWindowGrab(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_GetGrabbedWindow")]
        public static extern Window GetGrabbedWindow();
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowBrightness")]
        public static extern int SetWindowBrightness(Window window, float brightness);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowBrightness")]
        public static extern float GetWindowBrightness(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowOpacity")]
        public static extern int SetWindowOpacity(Window window, float opacity);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowOpacity")]
        public static extern int GetWindowOpacity(Window window, out float opacity);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowModalFor")]
        public static extern int SetWindowModalFor(Window modalWindow, Window parentWindow);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowInputFocus")]
        public static extern int SetWindowInputFocus(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowGammaRamp")]
        public static extern int SetWindowGammaRamp(Window window, ushort* red, ushort* green, ushort* blue);
        [DllImport("SDL2", EntryPoint = "SDL_GetWindowGammaRamp")]
        public static extern int GetWindowGammaRamp(Window window, ushort* red, ushort* green, ushort* blue);
        [DllImport("SDL2", EntryPoint = "SDL_SetWindowHitTest")]
        public static extern int SetWindowHitTest(Window window, HitTest callback, IntPtr callbackData);
        [DllImport("SDL2", EntryPoint = "SDL_DestroyWindow")]
        public static extern void DestroyWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_IsScreenSaverEnabled")]
        public static extern bool IsScreenSaverEnabled();
        [DllImport("SDL2", EntryPoint = "SDL_EnableScreenSaver")]
        public static extern void EnableScreenSaver();
        [DllImport("SDL2", EntryPoint = "SDL_DisableScreenSaver")]
        public static extern void DisableScreenSaver();

        public enum GLAttribute
        {
            RedSize,
            GreenSize,
            BlueSize,
            AlphaSize,
            BufferSize,
            DoubleBuffer,
            DepthSize,
            StencilSize,
            AccumRedSize,
            AccumGreenSize,
            AccumBlueSize,
            AccumAlphaSize,
            Stereo,
            MultisampleBuffers,
            MultisampleSamples,
            AcceleratedVisual,
            RetainedBacking,
            ContextMajorVersion,
            ContextMinorVersion,
            ContextEGL,
            ContextFlags,
            ContextProfileMask,
            ShareWithCurrentContext,
            FramebufferSRGBCapable,
            ContextReleaseBehavior,
            ContextResetNotification,
            ContextNoError
        }

        public enum GLProfile
        {
            ContextProfileCore           = 0x0001,
            ContextProfileCompatibility  = 0x0002,
            ContextProfileES             = 0x0004 /**< GLX_CONTEXT_ES2_PROFILE_BIT_EXT */
        }

        public enum GLContextFlag
        {
            DebugFlag             = 0x0001,
            ForwardCompatibleFlag = 0x0002,
            RobustAccessFlag      = 0x0004,
            ResetIsolationFlag    = 0x0008
        }

        public enum GLContextReleaseFlag
        {
            None   = 0x0000,
            Flush  = 0x0001
        }

        public enum GLContextResetNotification
        {
            NoNotification = 0x0000,
            LostContext    = 0x0001
        }

        public struct GLContext
        {
            public IntPtr Handle;

            public GLContext(IntPtr handle)
            {
                Handle = handle;
            }

            public static implicit operator IntPtr(GLContext context) => context.Handle;
            public static implicit operator GLContext(IntPtr handle) => new GLContext(handle);
        }

        [DllImport("SDL2", EntryPoint = "SDL_GL_LoadLibrary")]
        public static extern int GL_LoadLibrary(byte* path);
        [DllImport("SDL2", EntryPoint = "SDL_GL_GetProcAddress")]
        public static extern void* GL_GetProcAddress(byte* proc);
        [DllImport("SDL2", EntryPoint = "SDL_GL_UnloadLibrary")]
        public static extern void GL_UnloadLibrary();
        [DllImport("SDL2", EntryPoint = "SDL_GL_ExtensionSupported")]
        public static extern bool GL_ExtensionSupported(byte* extension);
        [DllImport("SDL2", EntryPoint = "SDL_GL_ResetAttributes")]
        public static extern void GL_ResetAttributes();
        [DllImport("SDL2", EntryPoint = "SDL_GL_SetAttribute")]
        public static extern int GL_SetAttribute(GLAttribute attr, int value);
        [DllImport("SDL2", EntryPoint = "SDL_GL_GetAttribute")]
        public static extern int GL_GetAttribute(GLAttribute attr, out int value);
        [DllImport("SDL2", EntryPoint = "SDL_GL_CreateContext")]
        public static extern GLContext GL_CreateContext(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_GL_MakeCurrent")]
        public static extern int GL_MakeCurrent(Window window, GLContext context);
        [DllImport("SDL2", EntryPoint = "SDL_GL_GetCurrentWindow")]
        public static extern void* GL_GetCurrentWindow();
        [DllImport("SDL2", EntryPoint = "SDL_GL_GetCurrentContext")]
        public static extern void* GL_GetCurrentContext();
        [DllImport("SDL2", EntryPoint = "SDL_GL_GetDrawableSize")]
        public static extern void GL_GetDrawableSize(Window window, out int w, out int h);
        [DllImport("SDL2", EntryPoint = "SDL_GL_SetSwapInterval")]
        public static extern int GL_SetSwapInterval(int interval);
        [DllImport("SDL2", EntryPoint = "SDL_GL_GetSwapInterval")]
        public static extern int GL_GetSwapInterval();
        [DllImport("SDL2", EntryPoint = "SDL_GL_SwapWindow")]
        public static extern void GL_SwapWindow(Window window);
        [DllImport("SDL2", EntryPoint = "SDL_GL_DeleteContext")]
        public static extern void GL_DeleteContext(GLContext context);

        //
        // SDL_vulkan.h
        //
        public struct VkInstance : IEquatable<VkInstance>
        {
            public IntPtr Handle;

            public static readonly VkInstance Null;

            public bool Equals(VkInstance other) => Handle == other.Handle;
            public override bool Equals(object obj) => obj is VkInstance && this == (VkInstance)obj;
            public override int GetHashCode() => Handle.GetHashCode();
            public override string ToString() => Handle.ToString();

            public static bool operator ==(VkInstance left, VkInstance right) => left.Equals(right);
            public static bool operator !=(VkInstance left, VkInstance right) => !left.Equals(right);

            public static implicit operator IntPtr(VkInstance instance) => instance.Handle;
            public static implicit operator VkInstance(IntPtr handle) => new VkInstance() { Handle = handle };
        }

        public struct VkSurfaceKHR : IEquatable<VkSurfaceKHR>
        {
            public ulong Handle;

            public static readonly VkSurfaceKHR Null;

            public bool Equals(VkSurfaceKHR other) => Handle == other.Handle;
            public override bool Equals(object obj) => obj is VkSurfaceKHR && this == (VkSurfaceKHR)obj;
            public override int GetHashCode() => Handle.GetHashCode();
            public override string ToString() => Handle.ToString();

            public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) => left.Equals(right);
            public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) => !left.Equals(right);

            public static implicit operator ulong(VkSurfaceKHR instance) => instance.Handle;
            public static implicit operator VkSurfaceKHR(ulong handle) => new VkSurfaceKHR() { Handle = handle };
        }

        [DllImport("SDL2", EntryPoint = "SDL_Vulkan_LoadLibrary")]
        public static extern int VulkanLoadLibrary(byte* path);
        [DllImport("SDL2", EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
        public static extern IntPtr VulkanGetVkGetInstanceProcAddr();
        [DllImport("SDL2", EntryPoint = "SDL_Vulkan_UnloadLibrary")]
        public static extern void VulkanUnloadLibrary();
        [DllImport("SDL2", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public static extern bool VulkanGetInstanceExtensions(Window window, ref uint count, byte** names);
        [DllImport("SDL2", EntryPoint = "SDL_Vulkan_CreateSurface")]
        public static extern bool VulkanCreateSurface(Window window, VkInstance instance, out VkSurfaceKHR surface);
        [DllImport("SDL2", EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public static extern void VulkanGetDrawableSize(Window window, out int w, out int h);
    }
}
