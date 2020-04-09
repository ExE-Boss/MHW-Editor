using MHW_Template;

namespace MHW_Editor.Gems {
    // Struct Size: "28"
    // Initial Offset: "10"
    // Unique Id Formula: "{Id}"
    public struct Gem {
        public ushort Index; // Offset: 4
        public ushort Id; // Offset: 0
        public byte Size; // Offset: 8
        public ushort Skill_1; // Offset: 12
        public byte Skill_1_Level; // Offset: 16
        public ushort Skill_2; // Offset: 20
        public byte Skill_2_Level; // Offset: 24
    }
}