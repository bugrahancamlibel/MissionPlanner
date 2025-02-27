

using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN {




        public const int UAVCAN_EQUIPMENT_ESC_RPMCOMMAND_MAX_PACK_SIZE = 46;
        public const ulong UAVCAN_EQUIPMENT_ESC_RPMCOMMAND_DT_SIG = 0xCE0F9F621CF7E70B;

        public const int UAVCAN_EQUIPMENT_ESC_RPMCOMMAND_DT_ID = 1031;






        public partial class uavcan_equipment_esc_RPMCommand: IDroneCANSerialize {



            public uint8_t rpm_len; [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)] public int32_t[] rpm = Enumerable.Range(1, 20).Select(i => new int32_t()).ToArray();




            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_uavcan_equipment_esc_RPMCommand(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_uavcan_equipment_esc_RPMCommand(transfer, this);
            }
        }
    }
}
