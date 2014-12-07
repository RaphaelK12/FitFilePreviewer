// Stephen Toub

using System;
using System.Runtime.InteropServices;

namespace FitFilePreviewer.Handler.COMInterop
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("fec87aaf-35f9-447a-adb7-20234491401a")]
    interface IPreviewHandlerFrame
    {
        void GetWindowContext(IntPtr pinfo);
        [PreserveSig]
        uint TranslateAccelerator(ref MSG pmsg);
    };
}