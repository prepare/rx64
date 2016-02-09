﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void SBB_rm16_r16()   // opcode: 19 /r
        {
            ushort result;
            ModRM_Byte ModRM = GetModRM();

            if (ModRM.RegMemType == RegMemTypeEnum.Memory)
            {
                result = GetWordInEffectiveSegment(ModRM.DefaultSegment, ModRM.EffectiveAddress);
                result = SubTwoWordsWithBorrowAndSetFlags(result, GetReg16(ModRM.RegOpValue));
                SetWordInEffectiveSegment(ModRM.DefaultSegment, ModRM.EffectiveAddress, result);
            }
            else
            {
                result = GetReg16(ModRM.RegMemValue);
                result = SubTwoWordsWithBorrowAndSetFlags(result, GetReg16(ModRM.RegOpValue));
                SetReg16(ModRM.RegMemValue, result);
            }
        }
    }
}