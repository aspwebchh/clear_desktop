﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GUI {
    class CFunction {
        [DllImport("clear_desktop.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr GetFileInfoList();

        [DllImport("clear_desktop.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr ClearItem( ref byte id );

        [DllImport("clear_desktop.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static int ComputeDirSize( ref byte id );
    }
}
