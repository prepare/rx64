﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void JECXZ_rel8()   // opcode: E3 cb
        {
            sbyte rel8 = (sbyte)GetNextInstructionByte();

            if (ecx == 0)
            {
                InstructionPointerJumpShort(rel8);
                jumpInstruction = true;
            }
        }
    }
}