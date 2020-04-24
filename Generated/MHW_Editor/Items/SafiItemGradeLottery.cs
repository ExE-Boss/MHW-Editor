using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class SafiItemGradeLottery {
        public const uint StructSize = 68;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Item_Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        [IsReadOnly]
        public virtual uint Index {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Index));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Index));
            }
        }

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 100;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [IsReadOnly]
        public virtual uint Item_Id {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id));
            }
        }

        public const string Grade_1_displayName = "Grade 1";
        public const int Grade_1_sortIndex = 150;
        [SortOrder(Grade_1_sortIndex)]
        [DisplayName(Grade_1_displayName)]
        public virtual uint Grade_1 {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Grade_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_1));
            }
        }

        private float _Grade_1Percent;
        [SortOrder(Grade_1_sortIndex + 1)]
        [DisplayName(Grade_1_displayName + "%")]
        public float Grade_1_percent {
            get => _Grade_1Percent;
            set {
                _Grade_1Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_1_percent));
            }
        }

        public const string Grade_2_displayName = "Grade 2";
        public const int Grade_2_sortIndex = 200;
        [SortOrder(Grade_2_sortIndex)]
        [DisplayName(Grade_2_displayName)]
        public virtual uint Grade_2 {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Grade_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_2));
            }
        }

        private float _Grade_2Percent;
        [SortOrder(Grade_2_sortIndex + 1)]
        [DisplayName(Grade_2_displayName + "%")]
        public float Grade_2_percent {
            get => _Grade_2Percent;
            set {
                _Grade_2Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_2_percent));
            }
        }

        public const string Grade_3_displayName = "Grade 3";
        public const int Grade_3_sortIndex = 250;
        [SortOrder(Grade_3_sortIndex)]
        [DisplayName(Grade_3_displayName)]
        public virtual uint Grade_3 {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Grade_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_3));
            }
        }

        private float _Grade_3Percent;
        [SortOrder(Grade_3_sortIndex + 1)]
        [DisplayName(Grade_3_displayName + "%")]
        public float Grade_3_percent {
            get => _Grade_3Percent;
            set {
                _Grade_3Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_3_percent));
            }
        }

        public const string Grade_4_displayName = "Grade 4";
        public const int Grade_4_sortIndex = 300;
        [SortOrder(Grade_4_sortIndex)]
        [DisplayName(Grade_4_displayName)]
        public virtual uint Grade_4 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Grade_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_4));
            }
        }

        private float _Grade_4Percent;
        [SortOrder(Grade_4_sortIndex + 1)]
        [DisplayName(Grade_4_displayName + "%")]
        public float Grade_4_percent {
            get => _Grade_4Percent;
            set {
                _Grade_4Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_4_percent));
            }
        }

        public const string Grade_5_displayName = "Grade 5";
        public const int Grade_5_sortIndex = 350;
        [SortOrder(Grade_5_sortIndex)]
        [DisplayName(Grade_5_displayName)]
        public virtual uint Grade_5 {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Grade_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_5));
            }
        }

        private float _Grade_5Percent;
        [SortOrder(Grade_5_sortIndex + 1)]
        [DisplayName(Grade_5_displayName + "%")]
        public float Grade_5_percent {
            get => _Grade_5Percent;
            set {
                _Grade_5Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_5_percent));
            }
        }

        public const string Grade_6_displayName = "Grade 6";
        public const int Grade_6_sortIndex = 400;
        [SortOrder(Grade_6_sortIndex)]
        [DisplayName(Grade_6_displayName)]
        public virtual uint Grade_6 {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Grade_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_6));
            }
        }

        private float _Grade_6Percent;
        [SortOrder(Grade_6_sortIndex + 1)]
        [DisplayName(Grade_6_displayName + "%")]
        public float Grade_6_percent {
            get => _Grade_6Percent;
            set {
                _Grade_6Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_6_percent));
            }
        }

        public const string Grade_7_displayName = "Grade 7";
        public const int Grade_7_sortIndex = 450;
        [SortOrder(Grade_7_sortIndex)]
        [DisplayName(Grade_7_displayName)]
        public virtual uint Grade_7 {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(Grade_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_7));
            }
        }

        private float _Grade_7Percent;
        [SortOrder(Grade_7_sortIndex + 1)]
        [DisplayName(Grade_7_displayName + "%")]
        public float Grade_7_percent {
            get => _Grade_7Percent;
            set {
                _Grade_7Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_7_percent));
            }
        }

        public const string Grade_8_displayName = "Grade 8";
        public const int Grade_8_sortIndex = 500;
        [SortOrder(Grade_8_sortIndex)]
        [DisplayName(Grade_8_displayName)]
        public virtual uint Grade_8 {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(Grade_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_8));
            }
        }

        private float _Grade_8Percent;
        [SortOrder(Grade_8_sortIndex + 1)]
        [DisplayName(Grade_8_displayName + "%")]
        public float Grade_8_percent {
            get => _Grade_8Percent;
            set {
                _Grade_8Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_8_percent));
            }
        }

        public const string Grade_9_displayName = "Grade 9";
        public const int Grade_9_sortIndex = 550;
        [SortOrder(Grade_9_sortIndex)]
        [DisplayName(Grade_9_displayName)]
        public virtual uint Grade_9 {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Grade_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_9));
            }
        }

        private float _Grade_9Percent;
        [SortOrder(Grade_9_sortIndex + 1)]
        [DisplayName(Grade_9_displayName + "%")]
        public float Grade_9_percent {
            get => _Grade_9Percent;
            set {
                _Grade_9Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_9_percent));
            }
        }

        public const string Grade_10_displayName = "Grade 10";
        public const int Grade_10_sortIndex = 600;
        [SortOrder(Grade_10_sortIndex)]
        [DisplayName(Grade_10_displayName)]
        public virtual uint Grade_10 {
            get => GetData<uint>(44);
            set {
                if (GetData<uint>(44) == value) return;
                SetData(44, value, nameof(Grade_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_10));
            }
        }

        private float _Grade_10Percent;
        [SortOrder(Grade_10_sortIndex + 1)]
        [DisplayName(Grade_10_displayName + "%")]
        public float Grade_10_percent {
            get => _Grade_10Percent;
            set {
                _Grade_10Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_10_percent));
            }
        }

        public const string Grade_11_displayName = "Grade 11";
        public const int Grade_11_sortIndex = 650;
        [SortOrder(Grade_11_sortIndex)]
        [DisplayName(Grade_11_displayName)]
        public virtual uint Grade_11 {
            get => GetData<uint>(48);
            set {
                if (GetData<uint>(48) == value) return;
                SetData(48, value, nameof(Grade_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_11));
            }
        }

        private float _Grade_11Percent;
        [SortOrder(Grade_11_sortIndex + 1)]
        [DisplayName(Grade_11_displayName + "%")]
        public float Grade_11_percent {
            get => _Grade_11Percent;
            set {
                _Grade_11Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_11_percent));
            }
        }

        public const string Grade_12_displayName = "Grade 12";
        public const int Grade_12_sortIndex = 700;
        [SortOrder(Grade_12_sortIndex)]
        [DisplayName(Grade_12_displayName)]
        public virtual uint Grade_12 {
            get => GetData<uint>(52);
            set {
                if (GetData<uint>(52) == value) return;
                SetData(52, value, nameof(Grade_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_12));
            }
        }

        private float _Grade_12Percent;
        [SortOrder(Grade_12_sortIndex + 1)]
        [DisplayName(Grade_12_displayName + "%")]
        public float Grade_12_percent {
            get => _Grade_12Percent;
            set {
                _Grade_12Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_12_percent));
            }
        }

        public const string Grade_13_displayName = "Grade 13";
        public const int Grade_13_sortIndex = 750;
        [SortOrder(Grade_13_sortIndex)]
        [DisplayName(Grade_13_displayName)]
        public virtual uint Grade_13 {
            get => GetData<uint>(56);
            set {
                if (GetData<uint>(56) == value) return;
                SetData(56, value, nameof(Grade_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_13));
            }
        }

        private float _Grade_13Percent;
        [SortOrder(Grade_13_sortIndex + 1)]
        [DisplayName(Grade_13_displayName + "%")]
        public float Grade_13_percent {
            get => _Grade_13Percent;
            set {
                _Grade_13Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_13_percent));
            }
        }

        public const string Grade_14_displayName = "Grade 14";
        public const int Grade_14_sortIndex = 800;
        [SortOrder(Grade_14_sortIndex)]
        [DisplayName(Grade_14_displayName)]
        public virtual uint Grade_14 {
            get => GetData<uint>(60);
            set {
                if (GetData<uint>(60) == value) return;
                SetData(60, value, nameof(Grade_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_14));
            }
        }

        private float _Grade_14Percent;
        [SortOrder(Grade_14_sortIndex + 1)]
        [DisplayName(Grade_14_displayName + "%")]
        public float Grade_14_percent {
            get => _Grade_14Percent;
            set {
                _Grade_14Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_14_percent));
            }
        }

        public const string Grade_15_displayName = "Grade 15";
        public const int Grade_15_sortIndex = 850;
        [SortOrder(Grade_15_sortIndex)]
        [DisplayName(Grade_15_displayName)]
        public virtual uint Grade_15 {
            get => GetData<uint>(64);
            set {
                if (GetData<uint>(64) == value) return;
                SetData(64, value, nameof(Grade_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_15));
            }
        }

        private float _Grade_15Percent;
        [SortOrder(Grade_15_sortIndex + 1)]
        [DisplayName(Grade_15_displayName + "%")]
        public float Grade_15_percent {
            get => _Grade_15Percent;
            set {
                _Grade_15Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_15_percent));
            }
        }

        public const int lastSortIndex = 900;
    }
}