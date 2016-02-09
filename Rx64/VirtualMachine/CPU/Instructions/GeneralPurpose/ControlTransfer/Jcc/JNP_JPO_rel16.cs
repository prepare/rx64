﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void JNP_JPO_rel16()   // opcode: 0F 8B cw
        {
            short rel16 = (short)GetNextInstructionWord();

            if (!GetFlag(FlagsEnum.PF_ParityFlag))
            {
                InstructionPointerJumpRel16(rel16);
                jumpInstruction = true;
            }
        }
    }
}