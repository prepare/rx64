﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void POP_DS_o16()   // opcode: 1F
        {
            ushort value = GetWord(SegmentEnum.SS, GetStackPointer());
            IncrementStackPointerByWord();
            ds = value;
        }
    }
}