using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "25"
    // Initial Offset: "10"
    // Unique Id Formula: "{Id}|{Weapon_Type}"
    public struct CustomParts {
        public uint Id; // Offset: 0
        public uint Weapon_Type; // Offset: 4
        public uint Part_1_Id; // Offset: 8
        public byte Unk_uint8_; // Offset: 12
        public uint Craft_Cost; // Offset: 13
        public ushort Attack; // Offset: 17
        public ushort Defense; // Offset: 19
        public byte Affinity; // Offset: 21
        public ushort Element; // Offset: 22
        public byte Sharpness; // Offset: 24
    }
}