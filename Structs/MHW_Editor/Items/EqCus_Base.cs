using MHW_Template;

namespace MHW_Editor.Items {
    // Struct Size: "41"
    // Initial Offset: "10"
    // Unique Id Formula: "{Equipment_Category_Raw}|{Equipment_Index_Raw}"
    public struct EqCus_Base {
        public byte Equipment_Category_Raw; // Offset: 0
        public ushort Equipment_Index_Raw; // Offset: 1
        public ushort Needed_Item_Id_to_Unlock; // Offset: 3
        public int Monster_Unlock; // Offset: 5
        public uint Story_Unlock; // Offset: 9
        public uint Item_Rank; // Offset: 13
        public ushort Mat_1_Id; // Offset: 17
        public byte Mat_1_Count; // Offset: 19
        public ushort Mat_2_Id; // Offset: 20
        public byte Mat_2_Count; // Offset: 22
        public ushort Mat_3_Id; // Offset: 23
        public byte Mat_3_Count; // Offset: 25
        public ushort Mat_4_Id; // Offset: 26
        public byte Mat_4_Count; // Offset: 28
        public ushort Child_index_1; // Offset: 29
        public ushort Child_index_2; // Offset: 31
        public ushort Child_index_3; // Offset: 33
        public ushort Child_index_4; // Offset: 35
        public byte Unk_1; // Offset: 37
        public byte Unk_2; // Offset: 38
        public byte Unk_3; // Offset: 39
        public byte Unk_4; // Offset: 40
    }
}