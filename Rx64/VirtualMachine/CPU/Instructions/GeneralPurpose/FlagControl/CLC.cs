﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void CLC()   // opcode: 0xf8
        {
            ClearFlag(FlagsEnum.CF_CarryFlag);
        }
    }
}