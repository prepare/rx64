﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void AND_r8_rm8()   // opcode: 22 /r
        {
            byte result;
            ModRM_Byte ModRM = GetModRM();

            if (ModRM.RegMemType == RegMemTypeEnum.Memory)
            {
                result = GetByteInEffectiveSegment(ModRM.DefaultSegment, ModRM.EffectiveAddress);
                result &= GetReg8(ModRM.RegOpValue);
                SetReg8(ModRM.RegOpValue, result);
            }
            else
            {
                result = GetReg8(ModRM.RegMemValue);
                result &= GetReg8(ModRM.RegOpValue);
                SetReg8(ModRM.RegOpValue, result);
            }

            ClearFlag(FlagsEnum.OF_OverflowFlag | FlagsEnum.CF_CarryFlag);
            SetSignFlagByByte(result);
            SetZeroFlagByByte(result);
            SetParityFlagByByte(result);
        }
    }
}