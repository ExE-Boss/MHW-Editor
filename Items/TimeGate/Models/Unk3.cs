﻿using System;
using System.ComponentModel;
using System.IO;
using MHW_Editor.Models;

namespace MHW_Editor.Items.TimeGate.Models {
    public class Unk3 : MhwStructItem {
        [SortOrder(25)]
        [DisplayName("Unlock Day")]
        [IsReadOnly]
        public DateTime unlockTime { get; set; }

        [SortOrder(50)]
        [DisplayName("Unk 1")]
        [IsReadOnly]
        public byte unk1 { get; set; }

        [SortOrder(100)]
        [DisplayName("Unk 2")]
        [IsReadOnly]
        public uint unk2 { get; set; }

        public override void WriteData(BinaryWriter writer) {
        }
    }
}