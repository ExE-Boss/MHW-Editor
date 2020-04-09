using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlPlayerParam {
        public const uint StructSize = 20640;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public override string UniqueId => $"0";

        public const string Gravity_displayName = "Gravity";
        public const int Gravity_sortIndex = 50;
        [SortOrder(Gravity_sortIndex)]
        [DisplayName(Gravity_displayName)]
        public virtual float Gravity {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(Gravity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gravity));
            }
        }

        public const string Gravity_Speed_Rate_displayName = "Gravity Speed Rate";
        public const int Gravity_Speed_Rate_sortIndex = 100;
        [SortOrder(Gravity_Speed_Rate_sortIndex)]
        [DisplayName(Gravity_Speed_Rate_displayName)]
        public virtual float Gravity_Speed_Rate {
            get => GetData<float>(12);
            set {
                if (GetData<float>(12) == value) return;
                SetData(12, value, nameof(Gravity_Speed_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gravity_Speed_Rate));
            }
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 150;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual float Unk1 {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 200;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual float Unk2 {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 250;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual float Unk3 {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 300;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual float Unk4 {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 350;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual float Unk5 {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 400;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual float Unk6 {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 450;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual float Unk7 {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 500;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual float Unk8 {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 550;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual float Unk9 {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 600;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual float Unk10 {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 650;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual float Unk11 {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 700;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual float Unk12 {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 750;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual float Unk13 {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 800;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual float Unk14 {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 850;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual float Unk15 {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 900;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual float Unk16 {
            get => GetData<float>(76);
            set {
                if (GetData<float>(76) == value) return;
                SetData(76, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 950;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual float Unk17 {
            get => GetData<float>(80);
            set {
                if (GetData<float>(80) == value) return;
                SetData(80, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 1000;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual float Unk18 {
            get => GetData<float>(84);
            set {
                if (GetData<float>(84) == value) return;
                SetData(84, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 1050;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual float Unk19 {
            get => GetData<float>(88);
            set {
                if (GetData<float>(88) == value) return;
                SetData(88, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk20_displayName = "Unk20";
        public const int Unk20_sortIndex = 1100;
        [SortOrder(Unk20_sortIndex)]
        [DisplayName(Unk20_displayName)]
        public virtual float Unk20 {
            get => GetData<float>(92);
            set {
                if (GetData<float>(92) == value) return;
                SetData(92, value, nameof(Unk20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk20));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 1150;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual float Unk21 {
            get => GetData<float>(96);
            set {
                if (GetData<float>(96) == value) return;
                SetData(96, value, nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const string Unk22_displayName = "Unk22";
        public const int Unk22_sortIndex = 1200;
        [SortOrder(Unk22_sortIndex)]
        [DisplayName(Unk22_displayName)]
        public virtual float Unk22 {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(Unk22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk22));
            }
        }

        public const string Unk23_displayName = "Unk23";
        public const int Unk23_sortIndex = 1250;
        [SortOrder(Unk23_sortIndex)]
        [DisplayName(Unk23_displayName)]
        public virtual float Unk23 {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(Unk23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk23));
            }
        }

        public const string Unk24_displayName = "Unk24";
        public const int Unk24_sortIndex = 1300;
        [SortOrder(Unk24_sortIndex)]
        [DisplayName(Unk24_displayName)]
        public virtual float Unk24 {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(Unk24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk24));
            }
        }

        public const string Unk25_displayName = "Unk25";
        public const int Unk25_sortIndex = 1350;
        [SortOrder(Unk25_sortIndex)]
        [DisplayName(Unk25_displayName)]
        public virtual float Unk25 {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(Unk25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk25));
            }
        }

        public const string Unk26_displayName = "Unk26";
        public const int Unk26_sortIndex = 1400;
        [SortOrder(Unk26_sortIndex)]
        [DisplayName(Unk26_displayName)]
        public virtual float Unk26 {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(Unk26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk26));
            }
        }

        public const string Unk27_displayName = "Unk27";
        public const int Unk27_sortIndex = 1450;
        [SortOrder(Unk27_sortIndex)]
        [DisplayName(Unk27_displayName)]
        public virtual float Unk27 {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(Unk27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk27));
            }
        }

        public const string Unk28_displayName = "Unk28";
        public const int Unk28_sortIndex = 1500;
        [SortOrder(Unk28_sortIndex)]
        [DisplayName(Unk28_displayName)]
        public virtual float Unk28 {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(Unk28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk28));
            }
        }

        public const string Unk29_displayName = "Unk29";
        public const int Unk29_sortIndex = 1550;
        [SortOrder(Unk29_sortIndex)]
        [DisplayName(Unk29_displayName)]
        public virtual float Unk29 {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(Unk29));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk29));
            }
        }

        public const string Unk30_displayName = "Unk30";
        public const int Unk30_sortIndex = 1600;
        [SortOrder(Unk30_sortIndex)]
        [DisplayName(Unk30_displayName)]
        public virtual float Unk30 {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(Unk30));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk30));
            }
        }

        public const string Unk31_displayName = "Unk31";
        public const int Unk31_sortIndex = 1650;
        [SortOrder(Unk31_sortIndex)]
        [DisplayName(Unk31_displayName)]
        public virtual float Unk31 {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(Unk31));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk31));
            }
        }

        public const string Unk32_displayName = "Unk32";
        public const int Unk32_sortIndex = 1700;
        [SortOrder(Unk32_sortIndex)]
        [DisplayName(Unk32_displayName)]
        public virtual float Unk32 {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(Unk32));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk32));
            }
        }

        public const string Unk33_displayName = "Unk33";
        public const int Unk33_sortIndex = 1750;
        [SortOrder(Unk33_sortIndex)]
        [DisplayName(Unk33_displayName)]
        public virtual float Unk33 {
            get => GetData<float>(144);
            set {
                if (GetData<float>(144) == value) return;
                SetData(144, value, nameof(Unk33));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk33));
            }
        }

        public const string Unk34_displayName = "Unk34";
        public const int Unk34_sortIndex = 1800;
        [SortOrder(Unk34_sortIndex)]
        [DisplayName(Unk34_displayName)]
        public virtual float Unk34 {
            get => GetData<float>(148);
            set {
                if (GetData<float>(148) == value) return;
                SetData(148, value, nameof(Unk34));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk34));
            }
        }

        public const string Unk35_displayName = "Unk35";
        public const int Unk35_sortIndex = 1850;
        [SortOrder(Unk35_sortIndex)]
        [DisplayName(Unk35_displayName)]
        public virtual uint Unk35 {
            get => GetData<uint>(152);
            set {
                if (GetData<uint>(152) == value) return;
                SetData(152, value, nameof(Unk35));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk35));
            }
        }

        public const string Unk36_displayName = "Unk36";
        public const int Unk36_sortIndex = 1900;
        [SortOrder(Unk36_sortIndex)]
        [DisplayName(Unk36_displayName)]
        public virtual uint Unk36 {
            get => GetData<uint>(156);
            set {
                if (GetData<uint>(156) == value) return;
                SetData(156, value, nameof(Unk36));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk36));
            }
        }

        public const string Unk37_displayName = "Unk37";
        public const int Unk37_sortIndex = 1950;
        [SortOrder(Unk37_sortIndex)]
        [DisplayName(Unk37_displayName)]
        public virtual float Unk37 {
            get => GetData<float>(160);
            set {
                if (GetData<float>(160) == value) return;
                SetData(160, value, nameof(Unk37));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk37));
            }
        }

        public const string Unk38_displayName = "Unk38";
        public const int Unk38_sortIndex = 2000;
        [SortOrder(Unk38_sortIndex)]
        [DisplayName(Unk38_displayName)]
        public virtual float Unk38 {
            get => GetData<float>(164);
            set {
                if (GetData<float>(164) == value) return;
                SetData(164, value, nameof(Unk38));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk38));
            }
        }

        public const string Unk39_displayName = "Unk39";
        public const int Unk39_sortIndex = 2050;
        [SortOrder(Unk39_sortIndex)]
        [DisplayName(Unk39_displayName)]
        public virtual float Unk39 {
            get => GetData<float>(168);
            set {
                if (GetData<float>(168) == value) return;
                SetData(168, value, nameof(Unk39));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk39));
            }
        }

        public const string Unk40_displayName = "Unk40";
        public const int Unk40_sortIndex = 2100;
        [SortOrder(Unk40_sortIndex)]
        [DisplayName(Unk40_displayName)]
        public virtual float Unk40 {
            get => GetData<float>(172);
            set {
                if (GetData<float>(172) == value) return;
                SetData(172, value, nameof(Unk40));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk40));
            }
        }

        public const string Unk41_displayName = "Unk41";
        public const int Unk41_sortIndex = 2150;
        [SortOrder(Unk41_sortIndex)]
        [DisplayName(Unk41_displayName)]
        public virtual float Unk41 {
            get => GetData<float>(176);
            set {
                if (GetData<float>(176) == value) return;
                SetData(176, value, nameof(Unk41));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk41));
            }
        }

        public const string Unk42_displayName = "Unk42";
        public const int Unk42_sortIndex = 2200;
        [SortOrder(Unk42_sortIndex)]
        [DisplayName(Unk42_displayName)]
        public virtual float Unk42 {
            get => GetData<float>(180);
            set {
                if (GetData<float>(180) == value) return;
                SetData(180, value, nameof(Unk42));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk42));
            }
        }

        public const string Unk43_displayName = "Unk43";
        public const int Unk43_sortIndex = 2250;
        [SortOrder(Unk43_sortIndex)]
        [DisplayName(Unk43_displayName)]
        public virtual float Unk43 {
            get => GetData<float>(184);
            set {
                if (GetData<float>(184) == value) return;
                SetData(184, value, nameof(Unk43));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk43));
            }
        }

        public const string Unk44_displayName = "Unk44";
        public const int Unk44_sortIndex = 2300;
        [SortOrder(Unk44_sortIndex)]
        [DisplayName(Unk44_displayName)]
        public virtual float Unk44 {
            get => GetData<float>(188);
            set {
                if (GetData<float>(188) == value) return;
                SetData(188, value, nameof(Unk44));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk44));
            }
        }

        public const string Unk45_displayName = "Unk45";
        public const int Unk45_sortIndex = 2350;
        [SortOrder(Unk45_sortIndex)]
        [DisplayName(Unk45_displayName)]
        public virtual float Unk45 {
            get => GetData<float>(192);
            set {
                if (GetData<float>(192) == value) return;
                SetData(192, value, nameof(Unk45));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk45));
            }
        }

        public const string Unk46_displayName = "Unk46";
        public const int Unk46_sortIndex = 2400;
        [SortOrder(Unk46_sortIndex)]
        [DisplayName(Unk46_displayName)]
        public virtual float Unk46 {
            get => GetData<float>(196);
            set {
                if (GetData<float>(196) == value) return;
                SetData(196, value, nameof(Unk46));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk46));
            }
        }

        public const string Unk47_displayName = "Unk47";
        public const int Unk47_sortIndex = 2450;
        [SortOrder(Unk47_sortIndex)]
        [DisplayName(Unk47_displayName)]
        public virtual float Unk47 {
            get => GetData<float>(200);
            set {
                if (GetData<float>(200) == value) return;
                SetData(200, value, nameof(Unk47));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk47));
            }
        }

        public const string Unk48_displayName = "Unk48";
        public const int Unk48_sortIndex = 2500;
        [SortOrder(Unk48_sortIndex)]
        [DisplayName(Unk48_displayName)]
        public virtual float Unk48 {
            get => GetData<float>(204);
            set {
                if (GetData<float>(204) == value) return;
                SetData(204, value, nameof(Unk48));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk48));
            }
        }

        public const string Unk49_displayName = "Unk49";
        public const int Unk49_sortIndex = 2550;
        [SortOrder(Unk49_sortIndex)]
        [DisplayName(Unk49_displayName)]
        public virtual float Unk49 {
            get => GetData<float>(208);
            set {
                if (GetData<float>(208) == value) return;
                SetData(208, value, nameof(Unk49));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk49));
            }
        }

        public const string Unk50_displayName = "Unk50";
        public const int Unk50_sortIndex = 2600;
        [SortOrder(Unk50_sortIndex)]
        [DisplayName(Unk50_displayName)]
        public virtual float Unk50 {
            get => GetData<float>(212);
            set {
                if (GetData<float>(212) == value) return;
                SetData(212, value, nameof(Unk50));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk50));
            }
        }

        public const string Unk51_displayName = "Unk51";
        public const int Unk51_sortIndex = 2650;
        [SortOrder(Unk51_sortIndex)]
        [DisplayName(Unk51_displayName)]
        public virtual float Unk51 {
            get => GetData<float>(216);
            set {
                if (GetData<float>(216) == value) return;
                SetData(216, value, nameof(Unk51));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk51));
            }
        }

        public const string Unk52_displayName = "Unk52";
        public const int Unk52_sortIndex = 2700;
        [SortOrder(Unk52_sortIndex)]
        [DisplayName(Unk52_displayName)]
        public virtual float Unk52 {
            get => GetData<float>(220);
            set {
                if (GetData<float>(220) == value) return;
                SetData(220, value, nameof(Unk52));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk52));
            }
        }

        public const string Unk53_displayName = "Unk53";
        public const int Unk53_sortIndex = 2750;
        [SortOrder(Unk53_sortIndex)]
        [DisplayName(Unk53_displayName)]
        public virtual float Unk53 {
            get => GetData<float>(224);
            set {
                if (GetData<float>(224) == value) return;
                SetData(224, value, nameof(Unk53));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk53));
            }
        }

        public const string Unk54_displayName = "Unk54";
        public const int Unk54_sortIndex = 2800;
        [SortOrder(Unk54_sortIndex)]
        [DisplayName(Unk54_displayName)]
        public virtual float Unk54 {
            get => GetData<float>(228);
            set {
                if (GetData<float>(228) == value) return;
                SetData(228, value, nameof(Unk54));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk54));
            }
        }

        public const string Unk55_displayName = "Unk55";
        public const int Unk55_sortIndex = 2850;
        [SortOrder(Unk55_sortIndex)]
        [DisplayName(Unk55_displayName)]
        public virtual float Unk55 {
            get => GetData<float>(232);
            set {
                if (GetData<float>(232) == value) return;
                SetData(232, value, nameof(Unk55));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk55));
            }
        }

        public const string Unk56_displayName = "Unk56";
        public const int Unk56_sortIndex = 2900;
        [SortOrder(Unk56_sortIndex)]
        [DisplayName(Unk56_displayName)]
        public virtual byte Unk56 {
            get => GetData<byte>(236);
            set {
                if (GetData<byte>(236) == value) return;
                SetData(236, value, nameof(Unk56));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk56));
            }
        }

        public const string Unk57_displayName = "Unk57";
        public const int Unk57_sortIndex = 2950;
        [SortOrder(Unk57_sortIndex)]
        [DisplayName(Unk57_displayName)]
        public virtual ushort Unk57 {
            get => GetData<ushort>(237);
            set {
                if (GetData<ushort>(237) == value) return;
                SetData(237, value, nameof(Unk57));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk57));
            }
        }

        public const string Unk58_displayName = "Unk58";
        public const int Unk58_sortIndex = 3000;
        [SortOrder(Unk58_sortIndex)]
        [DisplayName(Unk58_displayName)]
        public virtual ushort Unk58 {
            get => GetData<ushort>(239);
            set {
                if (GetData<ushort>(239) == value) return;
                SetData(239, value, nameof(Unk58));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk58));
            }
        }

        public const string Unk59_displayName = "Unk59";
        public const int Unk59_sortIndex = 3050;
        [SortOrder(Unk59_sortIndex)]
        [DisplayName(Unk59_displayName)]
        public virtual float Unk59 {
            get => GetData<float>(241);
            set {
                if (GetData<float>(241) == value) return;
                SetData(241, value, nameof(Unk59));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk59));
            }
        }

        public const string Unk60_displayName = "Unk60";
        public const int Unk60_sortIndex = 3100;
        [SortOrder(Unk60_sortIndex)]
        [DisplayName(Unk60_displayName)]
        public virtual byte Unk60 {
            get => GetData<byte>(245);
            set {
                if (GetData<byte>(245) == value) return;
                SetData(245, value, nameof(Unk60));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk60));
            }
        }

        public const string Unk61_displayName = "Unk61";
        public const int Unk61_sortIndex = 3150;
        [SortOrder(Unk61_sortIndex)]
        [DisplayName(Unk61_displayName)]
        public virtual ushort Unk61 {
            get => GetData<ushort>(246);
            set {
                if (GetData<ushort>(246) == value) return;
                SetData(246, value, nameof(Unk61));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk61));
            }
        }

        public const string Unk62_displayName = "Unk62";
        public const int Unk62_sortIndex = 3200;
        [SortOrder(Unk62_sortIndex)]
        [DisplayName(Unk62_displayName)]
        public virtual ushort Unk62 {
            get => GetData<ushort>(248);
            set {
                if (GetData<ushort>(248) == value) return;
                SetData(248, value, nameof(Unk62));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk62));
            }
        }

        public const string Unk63_displayName = "Unk63";
        public const int Unk63_sortIndex = 3250;
        [SortOrder(Unk63_sortIndex)]
        [DisplayName(Unk63_displayName)]
        public virtual ushort Unk63 {
            get => GetData<ushort>(250);
            set {
                if (GetData<ushort>(250) == value) return;
                SetData(250, value, nameof(Unk63));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk63));
            }
        }

        public const string Unk64_displayName = "Unk64";
        public const int Unk64_sortIndex = 3300;
        [SortOrder(Unk64_sortIndex)]
        [DisplayName(Unk64_displayName)]
        public virtual float Unk64 {
            get => GetData<float>(252);
            set {
                if (GetData<float>(252) == value) return;
                SetData(252, value, nameof(Unk64));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk64));
            }
        }

        public const string __3350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3350_sortIndex = 3350;
        [SortOrder(__3350_sortIndex)]
        [DisplayName(__3350_displayName)]
        [IsReadOnly]
        public virtual byte __3350 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3350));
            }
        }

        public const string _Skipping_ahead__3400_displayName = "------Skipping ahead.";
        public const int _Skipping_ahead__3400_sortIndex = 3400;
        [SortOrder(_Skipping_ahead__3400_sortIndex)]
        [DisplayName(_Skipping_ahead__3400_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_ahead__3400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(_Skipping_ahead__3400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead__3400));
            }
        }

        public const string __3450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3450_sortIndex = 3450;
        [SortOrder(__3450_sortIndex)]
        [DisplayName(__3450_displayName)]
        [IsReadOnly]
        public virtual byte __3450 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3450));
            }
        }

        public const string Health_Initial_Value_displayName = "Health Initial Value";
        public const int Health_Initial_Value_sortIndex = 3500;
        [SortOrder(Health_Initial_Value_sortIndex)]
        [DisplayName(Health_Initial_Value_displayName)]
        public virtual float Health_Initial_Value {
            get => GetData<float>(408);
            set {
                if (GetData<float>(408) == value) return;
                SetData(408, value, nameof(Health_Initial_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Initial_Value));
            }
        }

        public const string Health_Max_Value_displayName = "Health Max Value";
        public const int Health_Max_Value_sortIndex = 3550;
        [SortOrder(Health_Max_Value_sortIndex)]
        [DisplayName(Health_Max_Value_displayName)]
        public virtual float Health_Max_Value {
            get => GetData<float>(412);
            set {
                if (GetData<float>(412) == value) return;
                SetData(412, value, nameof(Health_Max_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Max_Value));
            }
        }

        public const string Health_Damage_Recovery_Rate_displayName = "Health Damage Recovery Rate";
        public const int Health_Damage_Recovery_Rate_sortIndex = 3600;
        [SortOrder(Health_Damage_Recovery_Rate_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Rate_displayName)]
        public virtual float Health_Damage_Recovery_Rate {
            get => GetData<float>(416);
            set {
                if (GetData<float>(416) == value) return;
                SetData(416, value, nameof(Health_Damage_Recovery_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Rate));
            }
        }

        public const string Health_Damage_Recovery_Wait_Time_displayName = "Health Damage Recovery Wait Time";
        public const int Health_Damage_Recovery_Wait_Time_sortIndex = 3650;
        [SortOrder(Health_Damage_Recovery_Wait_Time_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Wait_Time_displayName)]
        public virtual float Health_Damage_Recovery_Wait_Time {
            get => GetData<float>(420);
            set {
                if (GetData<float>(420) == value) return;
                SetData(420, value, nameof(Health_Damage_Recovery_Wait_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Wait_Time));
            }
        }

        public const string Health_Damage_Recovery_Interval_displayName = "Health Damage Recovery Interval";
        public const int Health_Damage_Recovery_Interval_sortIndex = 3700;
        [SortOrder(Health_Damage_Recovery_Interval_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Interval_displayName)]
        public virtual float Health_Damage_Recovery_Interval {
            get => GetData<float>(424);
            set {
                if (GetData<float>(424) == value) return;
                SetData(424, value, nameof(Health_Damage_Recovery_Interval));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Interval));
            }
        }

        public const string Health_Damage_Recovery_Value_displayName = "Health Damage Recovery Value";
        public const int Health_Damage_Recovery_Value_sortIndex = 3750;
        [SortOrder(Health_Damage_Recovery_Value_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Value_displayName)]
        public virtual float Health_Damage_Recovery_Value {
            get => GetData<float>(428);
            set {
                if (GetData<float>(428) == value) return;
                SetData(428, value, nameof(Health_Damage_Recovery_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Value));
            }
        }

        public const string __3800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3800_sortIndex = 3800;
        [SortOrder(__3800_sortIndex)]
        [DisplayName(__3800_displayName)]
        [IsReadOnly]
        public virtual byte __3800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3800));
            }
        }

        public const string Stamina_Initial_Value_displayName = "Stamina Initial Value";
        public const int Stamina_Initial_Value_sortIndex = 3850;
        [SortOrder(Stamina_Initial_Value_sortIndex)]
        [DisplayName(Stamina_Initial_Value_displayName)]
        public virtual float Stamina_Initial_Value {
            get => GetData<float>(432);
            set {
                if (GetData<float>(432) == value) return;
                SetData(432, value, nameof(Stamina_Initial_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Initial_Value));
            }
        }

        public const string Stamina_Max_Value_displayName = "Stamina Max Value";
        public const int Stamina_Max_Value_sortIndex = 3900;
        [SortOrder(Stamina_Max_Value_sortIndex)]
        [DisplayName(Stamina_Max_Value_displayName)]
        public virtual float Stamina_Max_Value {
            get => GetData<float>(436);
            set {
                if (GetData<float>(436) == value) return;
                SetData(436, value, nameof(Stamina_Max_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Max_Value));
            }
        }

        public const string Stamina_Min_Value_displayName = "Stamina Min Value";
        public const int Stamina_Min_Value_sortIndex = 3950;
        [SortOrder(Stamina_Min_Value_sortIndex)]
        [DisplayName(Stamina_Min_Value_displayName)]
        public virtual float Stamina_Min_Value {
            get => GetData<float>(440);
            set {
                if (GetData<float>(440) == value) return;
                SetData(440, value, nameof(Stamina_Min_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Min_Value));
            }
        }

        public const string Stamina_Tired_Value_displayName = "Stamina Tired Value";
        public const int Stamina_Tired_Value_sortIndex = 4000;
        [SortOrder(Stamina_Tired_Value_sortIndex)]
        [DisplayName(Stamina_Tired_Value_displayName)]
        public virtual float Stamina_Tired_Value {
            get => GetData<float>(444);
            set {
                if (GetData<float>(444) == value) return;
                SetData(444, value, nameof(Stamina_Tired_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Tired_Value));
            }
        }

        public const string Stamina_Auto_Recover_displayName = "Stamina Auto Recover";
        public const int Stamina_Auto_Recover_sortIndex = 4050;
        [SortOrder(Stamina_Auto_Recover_sortIndex)]
        [DisplayName(Stamina_Auto_Recover_displayName)]
        public virtual float Stamina_Auto_Recover {
            get => GetData<float>(448);
            set {
                if (GetData<float>(448) == value) return;
                SetData(448, value, nameof(Stamina_Auto_Recover));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Auto_Recover));
            }
        }

        public const string Stamina_Auto_Max_Reduce_displayName = "Stamina Auto Max Reduce";
        public const int Stamina_Auto_Max_Reduce_sortIndex = 4100;
        [SortOrder(Stamina_Auto_Max_Reduce_sortIndex)]
        [DisplayName(Stamina_Auto_Max_Reduce_displayName)]
        public virtual float Stamina_Auto_Max_Reduce {
            get => GetData<float>(452);
            set {
                if (GetData<float>(452) == value) return;
                SetData(452, value, nameof(Stamina_Auto_Max_Reduce));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Auto_Max_Reduce));
            }
        }

        public const string Stamina_Auto_Max_Reduce_Time_displayName = "Stamina Auto Max Reduce Time";
        public const int Stamina_Auto_Max_Reduce_Time_sortIndex = 4150;
        [SortOrder(Stamina_Auto_Max_Reduce_Time_sortIndex)]
        [DisplayName(Stamina_Auto_Max_Reduce_Time_displayName)]
        public virtual float Stamina_Auto_Max_Reduce_Time {
            get => GetData<float>(456);
            set {
                if (GetData<float>(456) == value) return;
                SetData(456, value, nameof(Stamina_Auto_Max_Reduce_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Auto_Max_Reduce_Time));
            }
        }

        public const string Stamina_IB_Unknown_displayName = "Stamina IB Unknown";
        public const int Stamina_IB_Unknown_sortIndex = 4200;
        [SortOrder(Stamina_IB_Unknown_sortIndex)]
        [DisplayName(Stamina_IB_Unknown_displayName)]
        public virtual float Stamina_IB_Unknown {
            get => GetData<float>(460);
            set {
                if (GetData<float>(460) == value) return;
                SetData(460, value, nameof(Stamina_IB_Unknown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_IB_Unknown));
            }
        }

        public const string Stamina_Escape_Dash_Rate_displayName = "Stamina Escape Dash Rate";
        public const int Stamina_Escape_Dash_Rate_sortIndex = 4250;
        [SortOrder(Stamina_Escape_Dash_Rate_sortIndex)]
        [DisplayName(Stamina_Escape_Dash_Rate_displayName)]
        public virtual float Stamina_Escape_Dash_Rate {
            get => GetData<float>(464);
            set {
                if (GetData<float>(464) == value) return;
                SetData(464, value, nameof(Stamina_Escape_Dash_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Escape_Dash_Rate));
            }
        }

        public const string Stamina_Out_of_Battle_Rate_displayName = "Stamina Out of Battle Rate";
        public const int Stamina_Out_of_Battle_Rate_sortIndex = 4300;
        [SortOrder(Stamina_Out_of_Battle_Rate_sortIndex)]
        [DisplayName(Stamina_Out_of_Battle_Rate_displayName)]
        public virtual float Stamina_Out_of_Battle_Rate {
            get => GetData<float>(468);
            set {
                if (GetData<float>(468) == value) return;
                SetData(468, value, nameof(Stamina_Out_of_Battle_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Out_of_Battle_Rate));
            }
        }

        public const string Stamina_Reduce_Rate_Limit_Trigger_displayName = "Stamina Reduce Rate Limit Trigger";
        public const int Stamina_Reduce_Rate_Limit_Trigger_sortIndex = 4350;
        [SortOrder(Stamina_Reduce_Rate_Limit_Trigger_sortIndex)]
        [DisplayName(Stamina_Reduce_Rate_Limit_Trigger_displayName)]
        public virtual float Stamina_Reduce_Rate_Limit_Trigger {
            get => GetData<float>(472);
            set {
                if (GetData<float>(472) == value) return;
                SetData(472, value, nameof(Stamina_Reduce_Rate_Limit_Trigger));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Reduce_Rate_Limit_Trigger));
            }
        }

        public const string Stamina_Reduce_Rate_Limit_Time_displayName = "Stamina Reduce Rate Limit Time";
        public const int Stamina_Reduce_Rate_Limit_Time_sortIndex = 4400;
        [SortOrder(Stamina_Reduce_Rate_Limit_Time_sortIndex)]
        [DisplayName(Stamina_Reduce_Rate_Limit_Time_displayName)]
        public virtual float Stamina_Reduce_Rate_Limit_Time {
            get => GetData<float>(476);
            set {
                if (GetData<float>(476) == value) return;
                SetData(476, value, nameof(Stamina_Reduce_Rate_Limit_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Reduce_Rate_Limit_Time));
            }
        }

        public const string Stamina_Mount_Endurance_Rate_displayName = "Stamina Mount Endurance Rate";
        public const int Stamina_Mount_Endurance_Rate_sortIndex = 4450;
        [SortOrder(Stamina_Mount_Endurance_Rate_sortIndex)]
        [DisplayName(Stamina_Mount_Endurance_Rate_displayName)]
        public virtual float Stamina_Mount_Endurance_Rate {
            get => GetData<float>(480);
            set {
                if (GetData<float>(480) == value) return;
                SetData(480, value, nameof(Stamina_Mount_Endurance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Mount_Endurance_Rate));
            }
        }

        public const string Stamina_Consumption_Dodge_displayName = "Stamina Consumption: Dodge";
        public const int Stamina_Consumption_Dodge_sortIndex = 4500;
        [SortOrder(Stamina_Consumption_Dodge_sortIndex)]
        [DisplayName(Stamina_Consumption_Dodge_displayName)]
        public virtual float Stamina_Consumption_Dodge {
            get => GetData<float>(484);
            set {
                if (GetData<float>(484) == value) return;
                SetData(484, value, nameof(Stamina_Consumption_Dodge));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Dodge));
            }
        }

        public const string Stamina_Consumption_LS_Counter_displayName = "Stamina Consumption: LS Counter";
        public const int Stamina_Consumption_LS_Counter_sortIndex = 4550;
        [SortOrder(Stamina_Consumption_LS_Counter_sortIndex)]
        [DisplayName(Stamina_Consumption_LS_Counter_displayName)]
        public virtual float Stamina_Consumption_LS_Counter {
            get => GetData<float>(488);
            set {
                if (GetData<float>(488) == value) return;
                SetData(488, value, nameof(Stamina_Consumption_LS_Counter));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_LS_Counter));
            }
        }

        public const string Stamina_Consumption_Unk1_displayName = "Stamina Consumption: Unk1";
        public const int Stamina_Consumption_Unk1_sortIndex = 4600;
        [SortOrder(Stamina_Consumption_Unk1_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk1_displayName)]
        public virtual float Stamina_Consumption_Unk1 {
            get => GetData<float>(492);
            set {
                if (GetData<float>(492) == value) return;
                SetData(492, value, nameof(Stamina_Consumption_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk1));
            }
        }

        public const string Stamina_Consumption_Unk2_displayName = "Stamina Consumption: Unk2";
        public const int Stamina_Consumption_Unk2_sortIndex = 4650;
        [SortOrder(Stamina_Consumption_Unk2_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk2_displayName)]
        public virtual float Stamina_Consumption_Unk2 {
            get => GetData<float>(496);
            set {
                if (GetData<float>(496) == value) return;
                SetData(496, value, nameof(Stamina_Consumption_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk2));
            }
        }

        public const string Stamina_Consumption_Unk3_displayName = "Stamina Consumption: Unk3";
        public const int Stamina_Consumption_Unk3_sortIndex = 4700;
        [SortOrder(Stamina_Consumption_Unk3_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk3_displayName)]
        public virtual float Stamina_Consumption_Unk3 {
            get => GetData<float>(500);
            set {
                if (GetData<float>(500) == value) return;
                SetData(500, value, nameof(Stamina_Consumption_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk3));
            }
        }

        public const string Stamina_Consumption_Unk4_displayName = "Stamina Consumption: Unk4";
        public const int Stamina_Consumption_Unk4_sortIndex = 4750;
        [SortOrder(Stamina_Consumption_Unk4_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk4_displayName)]
        public virtual float Stamina_Consumption_Unk4 {
            get => GetData<float>(504);
            set {
                if (GetData<float>(504) == value) return;
                SetData(504, value, nameof(Stamina_Consumption_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk4));
            }
        }

        public const string Stamina_Consumption_Bow_Shoot_displayName = "Stamina Consumption: Bow Shoot";
        public const int Stamina_Consumption_Bow_Shoot_sortIndex = 4800;
        [SortOrder(Stamina_Consumption_Bow_Shoot_sortIndex)]
        [DisplayName(Stamina_Consumption_Bow_Shoot_displayName)]
        public virtual float Stamina_Consumption_Bow_Shoot {
            get => GetData<float>(508);
            set {
                if (GetData<float>(508) == value) return;
                SetData(508, value, nameof(Stamina_Consumption_Bow_Shoot));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Bow_Shoot));
            }
        }

        public const string Stamina_Consumption_Unk5_displayName = "Stamina Consumption: Unk5";
        public const int Stamina_Consumption_Unk5_sortIndex = 4850;
        [SortOrder(Stamina_Consumption_Unk5_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk5_displayName)]
        public virtual float Stamina_Consumption_Unk5 {
            get => GetData<float>(512);
            set {
                if (GetData<float>(512) == value) return;
                SetData(512, value, nameof(Stamina_Consumption_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk5));
            }
        }

        public const string Stamina_Consumption_Unk6_displayName = "Stamina Consumption: Unk6";
        public const int Stamina_Consumption_Unk6_sortIndex = 4900;
        [SortOrder(Stamina_Consumption_Unk6_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk6_displayName)]
        public virtual float Stamina_Consumption_Unk6 {
            get => GetData<float>(516);
            set {
                if (GetData<float>(516) == value) return;
                SetData(516, value, nameof(Stamina_Consumption_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk6));
            }
        }

        public const string Stamina_Consumption_Unk7_displayName = "Stamina Consumption: Unk7";
        public const int Stamina_Consumption_Unk7_sortIndex = 4950;
        [SortOrder(Stamina_Consumption_Unk7_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk7_displayName)]
        public virtual float Stamina_Consumption_Unk7 {
            get => GetData<float>(520);
            set {
                if (GetData<float>(520) == value) return;
                SetData(520, value, nameof(Stamina_Consumption_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk7));
            }
        }

        public const string Stamina_Consumption_Bow_Charge_Step_displayName = "Stamina Consumption: Bow Charge Step";
        public const int Stamina_Consumption_Bow_Charge_Step_sortIndex = 5000;
        [SortOrder(Stamina_Consumption_Bow_Charge_Step_sortIndex)]
        [DisplayName(Stamina_Consumption_Bow_Charge_Step_displayName)]
        public virtual float Stamina_Consumption_Bow_Charge_Step {
            get => GetData<float>(524);
            set {
                if (GetData<float>(524) == value) return;
                SetData(524, value, nameof(Stamina_Consumption_Bow_Charge_Step));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Bow_Charge_Step));
            }
        }

        public const string Stamina_Consumption_Unk8_displayName = "Stamina Consumption: Unk8";
        public const int Stamina_Consumption_Unk8_sortIndex = 5050;
        [SortOrder(Stamina_Consumption_Unk8_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk8_displayName)]
        public virtual float Stamina_Consumption_Unk8 {
            get => GetData<float>(528);
            set {
                if (GetData<float>(528) == value) return;
                SetData(528, value, nameof(Stamina_Consumption_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk8));
            }
        }

        public const string Stamina_Consumption_IB_Unk9_displayName = "Stamina Consumption: IB Unk9";
        public const int Stamina_Consumption_IB_Unk9_sortIndex = 5100;
        [SortOrder(Stamina_Consumption_IB_Unk9_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk9_displayName)]
        public virtual float Stamina_Consumption_IB_Unk9 {
            get => GetData<float>(532);
            set {
                if (GetData<float>(532) == value) return;
                SetData(532, value, nameof(Stamina_Consumption_IB_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk9));
            }
        }

        public const string Stamina_Consumption_IB_Unk10_displayName = "Stamina Consumption: IB Unk10";
        public const int Stamina_Consumption_IB_Unk10_sortIndex = 5150;
        [SortOrder(Stamina_Consumption_IB_Unk10_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk10_displayName)]
        public virtual float Stamina_Consumption_IB_Unk10 {
            get => GetData<float>(536);
            set {
                if (GetData<float>(536) == value) return;
                SetData(536, value, nameof(Stamina_Consumption_IB_Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk10));
            }
        }

        public const string Stamina_Consumption_IB_Unk11_displayName = "Stamina Consumption: IB Unk11";
        public const int Stamina_Consumption_IB_Unk11_sortIndex = 5200;
        [SortOrder(Stamina_Consumption_IB_Unk11_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk11_displayName)]
        public virtual float Stamina_Consumption_IB_Unk11 {
            get => GetData<float>(540);
            set {
                if (GetData<float>(540) == value) return;
                SetData(540, value, nameof(Stamina_Consumption_IB_Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk11));
            }
        }

        public const string Stamina_Consumption_IB_Unk12_displayName = "Stamina Consumption: IB Unk12";
        public const int Stamina_Consumption_IB_Unk12_sortIndex = 5250;
        [SortOrder(Stamina_Consumption_IB_Unk12_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk12_displayName)]
        public virtual float Stamina_Consumption_IB_Unk12 {
            get => GetData<float>(544);
            set {
                if (GetData<float>(544) == value) return;
                SetData(544, value, nameof(Stamina_Consumption_IB_Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk12));
            }
        }

        public const string Stamina_Consumption_Unk13_displayName = "Stamina Consumption: Unk13";
        public const int Stamina_Consumption_Unk13_sortIndex = 5300;
        [SortOrder(Stamina_Consumption_Unk13_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk13_displayName)]
        public virtual float Stamina_Consumption_Unk13 {
            get => GetData<float>(548);
            set {
                if (GetData<float>(548) == value) return;
                SetData(548, value, nameof(Stamina_Consumption_Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk13));
            }
        }

        public const string Stamina_Consumption_Unk14_displayName = "Stamina Consumption: Unk14";
        public const int Stamina_Consumption_Unk14_sortIndex = 5350;
        [SortOrder(Stamina_Consumption_Unk14_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk14_displayName)]
        public virtual float Stamina_Consumption_Unk14 {
            get => GetData<float>(552);
            set {
                if (GetData<float>(552) == value) return;
                SetData(552, value, nameof(Stamina_Consumption_Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk14));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk1_displayName = "Stamina Time Reduce mCore: Unk1";
        public const int Stamina_Time_Reduce_mCore_Unk1_sortIndex = 5400;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk1_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk1_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk1 {
            get => GetData<float>(556);
            set {
                if (GetData<float>(556) == value) return;
                SetData(556, value, nameof(Stamina_Time_Reduce_mCore_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk1));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk2_displayName = "Stamina Time Reduce mCore: Unk2";
        public const int Stamina_Time_Reduce_mCore_Unk2_sortIndex = 5450;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk2_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk2_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk2 {
            get => GetData<float>(560);
            set {
                if (GetData<float>(560) == value) return;
                SetData(560, value, nameof(Stamina_Time_Reduce_mCore_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk2));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk3_displayName = "Stamina Time Reduce mCore: Unk3";
        public const int Stamina_Time_Reduce_mCore_Unk3_sortIndex = 5500;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk3_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk3_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk3 {
            get => GetData<float>(564);
            set {
                if (GetData<float>(564) == value) return;
                SetData(564, value, nameof(Stamina_Time_Reduce_mCore_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk3));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk4_displayName = "Stamina Time Reduce mCore: Unk4";
        public const int Stamina_Time_Reduce_mCore_Unk4_sortIndex = 5550;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk4_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk4_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk4 {
            get => GetData<float>(568);
            set {
                if (GetData<float>(568) == value) return;
                SetData(568, value, nameof(Stamina_Time_Reduce_mCore_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk4));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk5_displayName = "Stamina Time Reduce mCore: Unk5";
        public const int Stamina_Time_Reduce_mCore_Unk5_sortIndex = 5600;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk5_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk5_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk5 {
            get => GetData<float>(572);
            set {
                if (GetData<float>(572) == value) return;
                SetData(572, value, nameof(Stamina_Time_Reduce_mCore_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk5));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk6_displayName = "Stamina Time Reduce mCore: Unk6";
        public const int Stamina_Time_Reduce_mCore_Unk6_sortIndex = 5650;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk6_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk6_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk6 {
            get => GetData<float>(576);
            set {
                if (GetData<float>(576) == value) return;
                SetData(576, value, nameof(Stamina_Time_Reduce_mCore_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk6));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk7_displayName = "Stamina Time Reduce mCore: Unk7";
        public const int Stamina_Time_Reduce_mCore_Unk7_sortIndex = 5700;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk7_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk7_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk7 {
            get => GetData<float>(580);
            set {
                if (GetData<float>(580) == value) return;
                SetData(580, value, nameof(Stamina_Time_Reduce_mCore_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk7));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk8_displayName = "Stamina Time Reduce mCore: Unk8";
        public const int Stamina_Time_Reduce_mCore_Unk8_sortIndex = 5750;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk8_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk8_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk8 {
            get => GetData<float>(584);
            set {
                if (GetData<float>(584) == value) return;
                SetData(584, value, nameof(Stamina_Time_Reduce_mCore_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk8));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_displayName = "Stamina Time Reduce mCore: Lance's Power Guard";
        public const int Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_sortIndex = 5800;
        [SortOrder(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Lance_s_Power_Guard {
            get => GetData<float>(588);
            set {
                if (GetData<float>(588) == value) return;
                SetData(588, value, nameof(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk9_displayName = "Stamina Time Reduce mCore: Unk9";
        public const int Stamina_Time_Reduce_mCore_Unk9_sortIndex = 5850;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk9_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk9_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk9 {
            get => GetData<float>(592);
            set {
                if (GetData<float>(592) == value) return;
                SetData(592, value, nameof(Stamina_Time_Reduce_mCore_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk9));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk10_displayName = "Stamina Time Reduce mCore: Unk10";
        public const int Stamina_Time_Reduce_mCore_Unk10_sortIndex = 5900;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk10_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk10_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk10 {
            get => GetData<float>(596);
            set {
                if (GetData<float>(596) == value) return;
                SetData(596, value, nameof(Stamina_Time_Reduce_mCore_Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk10));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Clutch_Counter_displayName = "Stamina Time Reduce mCore: Clutch-Counter";
        public const int Stamina_Time_Reduce_mCore_Clutch_Counter_sortIndex = 5950;
        [SortOrder(Stamina_Time_Reduce_mCore_Clutch_Counter_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Clutch_Counter_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Clutch_Counter {
            get => GetData<float>(600);
            set {
                if (GetData<float>(600) == value) return;
                SetData(600, value, nameof(Stamina_Time_Reduce_mCore_Clutch_Counter));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Clutch_Counter));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk11_displayName = "Stamina Time Reduce mCore: Unk11";
        public const int Stamina_Time_Reduce_mCore_Unk11_sortIndex = 6000;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk11_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk11_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk11 {
            get => GetData<float>(604);
            set {
                if (GetData<float>(604) == value) return;
                SetData(604, value, nameof(Stamina_Time_Reduce_mCore_Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk11));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk12_displayName = "Stamina Time Reduce mCore: Unk12";
        public const int Stamina_Time_Reduce_mCore_Unk12_sortIndex = 6050;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk12_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk12_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk12 {
            get => GetData<float>(608);
            set {
                if (GetData<float>(608) == value) return;
                SetData(608, value, nameof(Stamina_Time_Reduce_mCore_Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk12));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk13_displayName = "Stamina Time Reduce mCore: Unk13";
        public const int Stamina_Time_Reduce_mCore_Unk13_sortIndex = 6100;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk13_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk13_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk13 {
            get => GetData<float>(612);
            set {
                if (GetData<float>(612) == value) return;
                SetData(612, value, nameof(Stamina_Time_Reduce_mCore_Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk13));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk14_displayName = "Stamina Time Reduce mCore: Unk14";
        public const int Stamina_Time_Reduce_mCore_Unk14_sortIndex = 6150;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk14_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk14_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk14 {
            get => GetData<float>(616);
            set {
                if (GetData<float>(616) == value) return;
                SetData(616, value, nameof(Stamina_Time_Reduce_mCore_Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk14));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk15_displayName = "Stamina Time Reduce mCore: Unk15";
        public const int Stamina_Time_Reduce_mCore_Unk15_sortIndex = 6200;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk15_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk15_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk15 {
            get => GetData<float>(620);
            set {
                if (GetData<float>(620) == value) return;
                SetData(620, value, nameof(Stamina_Time_Reduce_mCore_Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk15));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk16_displayName = "Stamina Time Reduce mCore: Unk16";
        public const int Stamina_Time_Reduce_mCore_Unk16_sortIndex = 6250;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk16_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk16_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk16 {
            get => GetData<float>(624);
            set {
                if (GetData<float>(624) == value) return;
                SetData(624, value, nameof(Stamina_Time_Reduce_mCore_Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk16));
            }
        }

        public const string __6300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6300_sortIndex = 6300;
        [SortOrder(__6300_sortIndex)]
        [DisplayName(__6300_displayName)]
        [IsReadOnly]
        public virtual byte __6300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6300));
            }
        }

        public const string Mount_Reduce_Stamina_mCore_Unk1_displayName = "Mount Reduce Stamina mCore: Unk1";
        public const int Mount_Reduce_Stamina_mCore_Unk1_sortIndex = 6350;
        [SortOrder(Mount_Reduce_Stamina_mCore_Unk1_sortIndex)]
        [DisplayName(Mount_Reduce_Stamina_mCore_Unk1_displayName)]
        public virtual float Mount_Reduce_Stamina_mCore_Unk1 {
            get => GetData<float>(628);
            set {
                if (GetData<float>(628) == value) return;
                SetData(628, value, nameof(Mount_Reduce_Stamina_mCore_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Reduce_Stamina_mCore_Unk1));
            }
        }

        public const string Mount_Reduce_Stamina_mCore_Unk2_displayName = "Mount Reduce Stamina mCore: Unk2";
        public const int Mount_Reduce_Stamina_mCore_Unk2_sortIndex = 6400;
        [SortOrder(Mount_Reduce_Stamina_mCore_Unk2_sortIndex)]
        [DisplayName(Mount_Reduce_Stamina_mCore_Unk2_displayName)]
        public virtual float Mount_Reduce_Stamina_mCore_Unk2 {
            get => GetData<float>(632);
            set {
                if (GetData<float>(632) == value) return;
                SetData(632, value, nameof(Mount_Reduce_Stamina_mCore_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Reduce_Stamina_mCore_Unk2));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk1_displayName = "Mount Life Reduce Stamina mCore: Unk1";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk1_sortIndex = 6450;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk1_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk1_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk1 {
            get => GetData<float>(636);
            set {
                if (GetData<float>(636) == value) return;
                SetData(636, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk1));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk2_displayName = "Mount Life Reduce Stamina mCore: Unk2";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk2_sortIndex = 6500;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk2_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk2_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk2 {
            get => GetData<float>(640);
            set {
                if (GetData<float>(640) == value) return;
                SetData(640, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk2));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk3_displayName = "Mount Life Reduce Stamina mCore: Unk3";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk3_sortIndex = 6550;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk3_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk3_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk3 {
            get => GetData<float>(644);
            set {
                if (GetData<float>(644) == value) return;
                SetData(644, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk3));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk4_displayName = "Mount Life Reduce Stamina mCore: Unk4";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk4_sortIndex = 6600;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk4_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk4_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk4 {
            get => GetData<float>(648);
            set {
                if (GetData<float>(648) == value) return;
                SetData(648, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk4));
            }
        }

        public const string __6650_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6650_sortIndex = 6650;
        [SortOrder(__6650_sortIndex)]
        [DisplayName(__6650_displayName)]
        [IsReadOnly]
        public virtual byte __6650 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6650));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6650));
            }
        }

        public const string Unk65_displayName = "Unk65";
        public const int Unk65_sortIndex = 6700;
        [SortOrder(Unk65_sortIndex)]
        [DisplayName(Unk65_displayName)]
        public virtual float Unk65 {
            get => GetData<float>(652);
            set {
                if (GetData<float>(652) == value) return;
                SetData(652, value, nameof(Unk65));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk65));
            }
        }

        public const string Unk66_displayName = "Unk66";
        public const int Unk66_sortIndex = 6750;
        [SortOrder(Unk66_sortIndex)]
        [DisplayName(Unk66_displayName)]
        public virtual float Unk66 {
            get => GetData<float>(656);
            set {
                if (GetData<float>(656) == value) return;
                SetData(656, value, nameof(Unk66));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk66));
            }
        }

        public const string Unk67_displayName = "Unk67";
        public const int Unk67_sortIndex = 6800;
        [SortOrder(Unk67_sortIndex)]
        [DisplayName(Unk67_displayName)]
        public virtual float Unk67 {
            get => GetData<float>(660);
            set {
                if (GetData<float>(660) == value) return;
                SetData(660, value, nameof(Unk67));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk67));
            }
        }

        public const string Explosive_HR_Fixed_Attack_Rate_displayName = "Explosive HR Fixed Attack Rate";
        public const int Explosive_HR_Fixed_Attack_Rate_sortIndex = 6850;
        [SortOrder(Explosive_HR_Fixed_Attack_Rate_sortIndex)]
        [DisplayName(Explosive_HR_Fixed_Attack_Rate_displayName)]
        public virtual float Explosive_HR_Fixed_Attack_Rate {
            get => GetData<float>(664);
            set {
                if (GetData<float>(664) == value) return;
                SetData(664, value, nameof(Explosive_HR_Fixed_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Explosive_HR_Fixed_Attack_Rate));
            }
        }

        public const string Explosive_MR_Fixed_Attack_Rate_displayName = "Explosive MR Fixed Attack Rate";
        public const int Explosive_MR_Fixed_Attack_Rate_sortIndex = 6900;
        [SortOrder(Explosive_MR_Fixed_Attack_Rate_sortIndex)]
        [DisplayName(Explosive_MR_Fixed_Attack_Rate_displayName)]
        public virtual float Explosive_MR_Fixed_Attack_Rate {
            get => GetData<float>(668);
            set {
                if (GetData<float>(668) == value) return;
                SetData(668, value, nameof(Explosive_MR_Fixed_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Explosive_MR_Fixed_Attack_Rate));
            }
        }

        public const string Critical_Attack_Rate_displayName = "Critical Attack Rate";
        public const int Critical_Attack_Rate_sortIndex = 6950;
        [SortOrder(Critical_Attack_Rate_sortIndex)]
        [DisplayName(Critical_Attack_Rate_displayName)]
        public virtual float Critical_Attack_Rate {
            get => GetData<float>(672);
            set {
                if (GetData<float>(672) == value) return;
                SetData(672, value, nameof(Critical_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Attack_Rate));
            }
        }

        public const string Bad_Critical_Attack_Rate_displayName = "Bad Critical Attack Rate";
        public const int Bad_Critical_Attack_Rate_sortIndex = 7000;
        [SortOrder(Bad_Critical_Attack_Rate_sortIndex)]
        [DisplayName(Bad_Critical_Attack_Rate_displayName)]
        public virtual float Bad_Critical_Attack_Rate {
            get => GetData<float>(676);
            set {
                if (GetData<float>(676) == value) return;
                SetData(676, value, nameof(Bad_Critical_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bad_Critical_Attack_Rate));
            }
        }

        public const string Sharpness_Recoil_Reduction__displayName = "Sharpness Recoil Reduction %";
        public const int Sharpness_Recoil_Reduction__sortIndex = 7050;
        [SortOrder(Sharpness_Recoil_Reduction__sortIndex)]
        [DisplayName(Sharpness_Recoil_Reduction__displayName)]
        public virtual byte Sharpness_Recoil_Reduction_ {
            get => GetData<byte>(680);
            set {
                if (GetData<byte>(680) == value) return;
                SetData(680, value, nameof(Sharpness_Recoil_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sharpness_Recoil_Reduction_));
            }
        }

        public const string Sharpness_Recoil_Reduction_Value_displayName = "Sharpness Recoil Reduction Value";
        public const int Sharpness_Recoil_Reduction_Value_sortIndex = 7100;
        [SortOrder(Sharpness_Recoil_Reduction_Value_sortIndex)]
        [DisplayName(Sharpness_Recoil_Reduction_Value_displayName)]
        public virtual byte Sharpness_Recoil_Reduction_Value {
            get => GetData<byte>(681);
            set {
                if (GetData<byte>(681) == value) return;
                SetData(681, value, nameof(Sharpness_Recoil_Reduction_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sharpness_Recoil_Reduction_Value));
            }
        }

        public const string Unk68_displayName = "Unk68";
        public const int Unk68_sortIndex = 7150;
        [SortOrder(Unk68_sortIndex)]
        [DisplayName(Unk68_displayName)]
        public virtual float Unk68 {
            get => GetData<float>(682);
            set {
                if (GetData<float>(682) == value) return;
                SetData(682, value, nameof(Unk68));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk68));
            }
        }

        public const string Unk69_displayName = "Unk69";
        public const int Unk69_sortIndex = 7200;
        [SortOrder(Unk69_sortIndex)]
        [DisplayName(Unk69_displayName)]
        public virtual float Unk69 {
            get => GetData<float>(686);
            set {
                if (GetData<float>(686) == value) return;
                SetData(686, value, nameof(Unk69));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk69));
            }
        }

        public const string Unk70_displayName = "Unk70";
        public const int Unk70_sortIndex = 7250;
        [SortOrder(Unk70_sortIndex)]
        [DisplayName(Unk70_displayName)]
        public virtual float Unk70 {
            get => GetData<float>(690);
            set {
                if (GetData<float>(690) == value) return;
                SetData(690, value, nameof(Unk70));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk70));
            }
        }

        public const string Unk71_displayName = "Unk71";
        public const int Unk71_sortIndex = 7300;
        [SortOrder(Unk71_sortIndex)]
        [DisplayName(Unk71_displayName)]
        public virtual float Unk71 {
            get => GetData<float>(694);
            set {
                if (GetData<float>(694) == value) return;
                SetData(694, value, nameof(Unk71));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk71));
            }
        }

        public const string Unk72_displayName = "Unk72";
        public const int Unk72_sortIndex = 7350;
        [SortOrder(Unk72_sortIndex)]
        [DisplayName(Unk72_displayName)]
        public virtual uint Unk72 {
            get => GetData<uint>(698);
            set {
                if (GetData<uint>(698) == value) return;
                SetData(698, value, nameof(Unk72));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk72));
            }
        }

        public const string Physical_Attack_Rate_Limit_displayName = "Physical Attack Rate Limit";
        public const int Physical_Attack_Rate_Limit_sortIndex = 7400;
        [SortOrder(Physical_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Physical_Attack_Rate_Limit_displayName)]
        public virtual float Physical_Attack_Rate_Limit {
            get => GetData<float>(702);
            set {
                if (GetData<float>(702) == value) return;
                SetData(702, value, nameof(Physical_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Physical_Attack_Rate_Limit));
            }
        }

        public const string Elemental_Attack_Rate_Limit_displayName = "Elemental Attack Rate Limit";
        public const int Elemental_Attack_Rate_Limit_sortIndex = 7450;
        [SortOrder(Elemental_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Elemental_Attack_Rate_Limit_displayName)]
        public virtual float Elemental_Attack_Rate_Limit {
            get => GetData<float>(706);
            set {
                if (GetData<float>(706) == value) return;
                SetData(706, value, nameof(Elemental_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Attack_Rate_Limit));
            }
        }

        public const string Condition_Elemental_Attack_Flat_Limit_displayName = "Condition Elemental Attack Flat Limit";
        public const int Condition_Elemental_Attack_Flat_Limit_sortIndex = 7500;
        [SortOrder(Condition_Elemental_Attack_Flat_Limit_sortIndex)]
        [DisplayName(Condition_Elemental_Attack_Flat_Limit_displayName)]
        public virtual float Condition_Elemental_Attack_Flat_Limit {
            get => GetData<float>(710);
            set {
                if (GetData<float>(710) == value) return;
                SetData(710, value, nameof(Condition_Elemental_Attack_Flat_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Condition_Elemental_Attack_Flat_Limit));
            }
        }

        public const string Bowgun_Elemental_Attack_Rate_Limit_displayName = "Bowgun Elemental Attack Rate Limit";
        public const int Bowgun_Elemental_Attack_Rate_Limit_sortIndex = 7550;
        [SortOrder(Bowgun_Elemental_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Bowgun_Elemental_Attack_Rate_Limit_displayName)]
        public virtual float Bowgun_Elemental_Attack_Rate_Limit {
            get => GetData<float>(714);
            set {
                if (GetData<float>(714) == value) return;
                SetData(714, value, nameof(Bowgun_Elemental_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bowgun_Elemental_Attack_Rate_Limit));
            }
        }

        public const string Condition_Attack_Rate_Limit_displayName = "Condition Attack Rate Limit";
        public const int Condition_Attack_Rate_Limit_sortIndex = 7600;
        [SortOrder(Condition_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Condition_Attack_Rate_Limit_displayName)]
        public virtual float Condition_Attack_Rate_Limit {
            get => GetData<float>(718);
            set {
                if (GetData<float>(718) == value) return;
                SetData(718, value, nameof(Condition_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Condition_Attack_Rate_Limit));
            }
        }

        public const string Stun_Attack_Rate_Limit_displayName = "Stun Attack Rate Limit";
        public const int Stun_Attack_Rate_Limit_sortIndex = 7650;
        [SortOrder(Stun_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Stun_Attack_Rate_Limit_displayName)]
        public virtual float Stun_Attack_Rate_Limit {
            get => GetData<float>(722);
            set {
                if (GetData<float>(722) == value) return;
                SetData(722, value, nameof(Stun_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stun_Attack_Rate_Limit));
            }
        }

        public const string Stamina_Attack_Rate_Limit_displayName = "Stamina Attack Rate Limit";
        public const int Stamina_Attack_Rate_Limit_sortIndex = 7700;
        [SortOrder(Stamina_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Stamina_Attack_Rate_Limit_displayName)]
        public virtual float Stamina_Attack_Rate_Limit {
            get => GetData<float>(726);
            set {
                if (GetData<float>(726) == value) return;
                SetData(726, value, nameof(Stamina_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Attack_Rate_Limit));
            }
        }

        public const string Mount_Attack_Rate_Limit_displayName = "Mount Attack Rate Limit";
        public const int Mount_Attack_Rate_Limit_sortIndex = 7750;
        [SortOrder(Mount_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Mount_Attack_Rate_Limit_displayName)]
        public virtual float Mount_Attack_Rate_Limit {
            get => GetData<float>(730);
            set {
                if (GetData<float>(730) == value) return;
                SetData(730, value, nameof(Mount_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Attack_Rate_Limit));
            }
        }

        public const string Super_Armor_Stun_Damage_Rate_displayName = "Super Armor Stun Damage Rate";
        public const int Super_Armor_Stun_Damage_Rate_sortIndex = 7800;
        [SortOrder(Super_Armor_Stun_Damage_Rate_sortIndex)]
        [DisplayName(Super_Armor_Stun_Damage_Rate_displayName)]
        public virtual float Super_Armor_Stun_Damage_Rate {
            get => GetData<float>(734);
            set {
                if (GetData<float>(734) == value) return;
                SetData(734, value, nameof(Super_Armor_Stun_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Super_Armor_Stun_Damage_Rate));
            }
        }

        public const string Hyper_Armor_Damage_Rate_displayName = "Hyper Armor Damage Rate";
        public const int Hyper_Armor_Damage_Rate_sortIndex = 7850;
        [SortOrder(Hyper_Armor_Damage_Rate_sortIndex)]
        [DisplayName(Hyper_Armor_Damage_Rate_displayName)]
        public virtual float Hyper_Armor_Damage_Rate {
            get => GetData<float>(738);
            set {
                if (GetData<float>(738) == value) return;
                SetData(738, value, nameof(Hyper_Armor_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hyper_Armor_Damage_Rate));
            }
        }

        public const string Hyper_Armor_Stun_Damage_Rate_displayName = "Hyper Armor Stun Damage Rate";
        public const int Hyper_Armor_Stun_Damage_Rate_sortIndex = 7900;
        [SortOrder(Hyper_Armor_Stun_Damage_Rate_sortIndex)]
        [DisplayName(Hyper_Armor_Stun_Damage_Rate_displayName)]
        public virtual float Hyper_Armor_Stun_Damage_Rate {
            get => GetData<float>(742);
            set {
                if (GetData<float>(742) == value) return;
                SetData(742, value, nameof(Hyper_Armor_Stun_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hyper_Armor_Stun_Damage_Rate));
            }
        }

        public const string Gunner_Defense_Rate_displayName = "Gunner Defense Rate";
        public const int Gunner_Defense_Rate_sortIndex = 7950;
        [SortOrder(Gunner_Defense_Rate_sortIndex)]
        [DisplayName(Gunner_Defense_Rate_displayName)]
        public virtual float Gunner_Defense_Rate {
            get => GetData<float>(746);
            set {
                if (GetData<float>(746) == value) return;
                SetData(746, value, nameof(Gunner_Defense_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gunner_Defense_Rate));
            }
        }

        public const string Gunner_Elemental_Resistance_Bonus_displayName = "Gunner Elemental Resistance Bonus";
        public const int Gunner_Elemental_Resistance_Bonus_sortIndex = 8000;
        [SortOrder(Gunner_Elemental_Resistance_Bonus_sortIndex)]
        [DisplayName(Gunner_Elemental_Resistance_Bonus_displayName)]
        public virtual byte Gunner_Elemental_Resistance_Bonus {
            get => GetData<byte>(750);
            set {
                if (GetData<byte>(750) == value) return;
                SetData(750, value, nameof(Gunner_Elemental_Resistance_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gunner_Elemental_Resistance_Bonus));
            }
        }

        public const string Lava_Damage_Interval_Time_displayName = "Lava Damage Interval Time";
        public const int Lava_Damage_Interval_Time_sortIndex = 8050;
        [SortOrder(Lava_Damage_Interval_Time_sortIndex)]
        [DisplayName(Lava_Damage_Interval_Time_displayName)]
        public virtual float Lava_Damage_Interval_Time {
            get => GetData<float>(751);
            set {
                if (GetData<float>(751) == value) return;
                SetData(751, value, nameof(Lava_Damage_Interval_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lava_Damage_Interval_Time));
            }
        }

        public const string Lava_Damage_Damage_displayName = "Lava Damage Damage";
        public const int Lava_Damage_Damage_sortIndex = 8100;
        [SortOrder(Lava_Damage_Damage_sortIndex)]
        [DisplayName(Lava_Damage_Damage_displayName)]
        public virtual float Lava_Damage_Damage {
            get => GetData<float>(755);
            set {
                if (GetData<float>(755) == value) return;
                SetData(755, value, nameof(Lava_Damage_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lava_Damage_Damage));
            }
        }

        public const string Acid_Damage_Interval_Time_displayName = "Acid Damage Interval Time";
        public const int Acid_Damage_Interval_Time_sortIndex = 8150;
        [SortOrder(Acid_Damage_Interval_Time_sortIndex)]
        [DisplayName(Acid_Damage_Interval_Time_displayName)]
        public virtual float Acid_Damage_Interval_Time {
            get => GetData<float>(759);
            set {
                if (GetData<float>(759) == value) return;
                SetData(759, value, nameof(Acid_Damage_Interval_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Acid_Damage_Interval_Time));
            }
        }

        public const string Acid_Damage_Damage_displayName = "Acid Damage Damage";
        public const int Acid_Damage_Damage_sortIndex = 8200;
        [SortOrder(Acid_Damage_Damage_sortIndex)]
        [DisplayName(Acid_Damage_Damage_displayName)]
        public virtual float Acid_Damage_Damage {
            get => GetData<float>(763);
            set {
                if (GetData<float>(763) == value) return;
                SetData(763, value, nameof(Acid_Damage_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Acid_Damage_Damage));
            }
        }

        public const string __8250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8250_sortIndex = 8250;
        [SortOrder(__8250_sortIndex)]
        [DisplayName(__8250_displayName)]
        [IsReadOnly]
        public virtual byte __8250 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__8250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__8250));
            }
        }

        public const string Walk_Turn_Tilt_Bow__8300_displayName = "Walk Turn Tilt (Bow)";
        public const int Walk_Turn_Tilt_Bow__8300_sortIndex = 8300;
        [SortOrder(Walk_Turn_Tilt_Bow__8300_sortIndex)]
        [DisplayName(Walk_Turn_Tilt_Bow__8300_displayName)]
        [IsReadOnly]
        public virtual float Walk_Turn_Tilt_Bow__8300 {
            get => GetData<float>(791);
            set {
                if (GetData<float>(791) == value) return;
                SetData(791, value, nameof(Walk_Turn_Tilt_Bow__8300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Walk_Turn_Tilt_Bow__8300));
            }
        }

        public const string Unk73_8350_displayName = "Unk73";
        public const int Unk73_8350_sortIndex = 8350;
        [SortOrder(Unk73_8350_sortIndex)]
        [DisplayName(Unk73_8350_displayName)]
        [IsReadOnly]
        public virtual float Unk73_8350 {
            get => GetData<float>(795);
            set {
                if (GetData<float>(795) == value) return;
                SetData(795, value, nameof(Unk73_8350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk73_8350));
            }
        }

        public const string Unk74_8400_displayName = "Unk74";
        public const int Unk74_8400_sortIndex = 8400;
        [SortOrder(Unk74_8400_sortIndex)]
        [DisplayName(Unk74_8400_displayName)]
        [IsReadOnly]
        public virtual float Unk74_8400 {
            get => GetData<float>(799);
            set {
                if (GetData<float>(799) == value) return;
                SetData(799, value, nameof(Unk74_8400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk74_8400));
            }
        }

        public const string Unk75_8450_displayName = "Unk75";
        public const int Unk75_8450_sortIndex = 8450;
        [SortOrder(Unk75_8450_sortIndex)]
        [DisplayName(Unk75_8450_displayName)]
        [IsReadOnly]
        public virtual float Unk75_8450 {
            get => GetData<float>(803);
            set {
                if (GetData<float>(803) == value) return;
                SetData(803, value, nameof(Unk75_8450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk75_8450));
            }
        }

        public const string Run_Turn_Tilt_Bow__8500_displayName = "Run Turn Tilt (Bow)";
        public const int Run_Turn_Tilt_Bow__8500_sortIndex = 8500;
        [SortOrder(Run_Turn_Tilt_Bow__8500_sortIndex)]
        [DisplayName(Run_Turn_Tilt_Bow__8500_displayName)]
        [IsReadOnly]
        public virtual float Run_Turn_Tilt_Bow__8500 {
            get => GetData<float>(807);
            set {
                if (GetData<float>(807) == value) return;
                SetData(807, value, nameof(Run_Turn_Tilt_Bow__8500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Turn_Tilt_Bow__8500));
            }
        }

        public const string Run_Turn_Tilt_Head_Bow__8550_displayName = "Run Turn Tilt Head (Bow)";
        public const int Run_Turn_Tilt_Head_Bow__8550_sortIndex = 8550;
        [SortOrder(Run_Turn_Tilt_Head_Bow__8550_sortIndex)]
        [DisplayName(Run_Turn_Tilt_Head_Bow__8550_displayName)]
        [IsReadOnly]
        public virtual float Run_Turn_Tilt_Head_Bow__8550 {
            get => GetData<float>(811);
            set {
                if (GetData<float>(811) == value) return;
                SetData(811, value, nameof(Run_Turn_Tilt_Head_Bow__8550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Turn_Tilt_Head_Bow__8550));
            }
        }

        public const string __8600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8600_sortIndex = 8600;
        [SortOrder(__8600_sortIndex)]
        [DisplayName(__8600_displayName)]
        [IsReadOnly]
        public virtual byte __8600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__8600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__8600));
            }
        }

        public const string _Skipping_ahead__8650_displayName = "------Skipping ahead.";
        public const int _Skipping_ahead__8650_sortIndex = 8650;
        [SortOrder(_Skipping_ahead__8650_sortIndex)]
        [DisplayName(_Skipping_ahead__8650_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_ahead__8650 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(_Skipping_ahead__8650));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead__8650));
            }
        }

        public const string __8700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8700_sortIndex = 8700;
        [SortOrder(__8700_sortIndex)]
        [DisplayName(__8700_displayName)]
        [IsReadOnly]
        public virtual byte __8700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__8700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__8700));
            }
        }

        public const string Walk_Turn_Speed_8750_displayName = "Walk Turn Speed";
        public const int Walk_Turn_Speed_8750_sortIndex = 8750;
        [SortOrder(Walk_Turn_Speed_8750_sortIndex)]
        [DisplayName(Walk_Turn_Speed_8750_displayName)]
        [IsReadOnly]
        public virtual float Walk_Turn_Speed_8750 {
            get => GetData<float>(953);
            set {
                if (GetData<float>(953) == value) return;
                SetData(953, value, nameof(Walk_Turn_Speed_8750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Walk_Turn_Speed_8750));
            }
        }

        public const string Walk_Turn_Speed_Room__8800_displayName = "Walk Turn Speed (Room)";
        public const int Walk_Turn_Speed_Room__8800_sortIndex = 8800;
        [SortOrder(Walk_Turn_Speed_Room__8800_sortIndex)]
        [DisplayName(Walk_Turn_Speed_Room__8800_displayName)]
        [IsReadOnly]
        public virtual float Walk_Turn_Speed_Room__8800 {
            get => GetData<float>(957);
            set {
                if (GetData<float>(957) == value) return;
                SetData(957, value, nameof(Walk_Turn_Speed_Room__8800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Walk_Turn_Speed_Room__8800));
            }
        }

        public const string Walk_Stop_Margin_Time_8850_displayName = "Walk Stop Margin Time";
        public const int Walk_Stop_Margin_Time_8850_sortIndex = 8850;
        [SortOrder(Walk_Stop_Margin_Time_8850_sortIndex)]
        [DisplayName(Walk_Stop_Margin_Time_8850_displayName)]
        [IsReadOnly]
        public virtual float Walk_Stop_Margin_Time_8850 {
            get => GetData<float>(961);
            set {
                if (GetData<float>(961) == value) return;
                SetData(961, value, nameof(Walk_Stop_Margin_Time_8850));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Walk_Stop_Margin_Time_8850));
            }
        }

        public const string Female_Motion_Start_Time_8900_displayName = "Female Motion Start Time";
        public const int Female_Motion_Start_Time_8900_sortIndex = 8900;
        [SortOrder(Female_Motion_Start_Time_8900_sortIndex)]
        [DisplayName(Female_Motion_Start_Time_8900_displayName)]
        [IsReadOnly]
        public virtual float Female_Motion_Start_Time_8900 {
            get => GetData<float>(965);
            set {
                if (GetData<float>(965) == value) return;
                SetData(965, value, nameof(Female_Motion_Start_Time_8900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Female_Motion_Start_Time_8900));
            }
        }

        public const string Unk76_8950_displayName = "Unk76";
        public const int Unk76_8950_sortIndex = 8950;
        [SortOrder(Unk76_8950_sortIndex)]
        [DisplayName(Unk76_8950_displayName)]
        [IsReadOnly]
        public virtual float Unk76_8950 {
            get => GetData<float>(969);
            set {
                if (GetData<float>(969) == value) return;
                SetData(969, value, nameof(Unk76_8950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk76_8950));
            }
        }

        public const string Unk77_9000_displayName = "Unk77";
        public const int Unk77_9000_sortIndex = 9000;
        [SortOrder(Unk77_9000_sortIndex)]
        [DisplayName(Unk77_9000_displayName)]
        [IsReadOnly]
        public virtual float Unk77_9000 {
            get => GetData<float>(973);
            set {
                if (GetData<float>(973) == value) return;
                SetData(973, value, nameof(Unk77_9000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk77_9000));
            }
        }

        public const string Walk_Motion_Speed_Room__9050_displayName = "Walk Motion Speed (Room)";
        public const int Walk_Motion_Speed_Room__9050_sortIndex = 9050;
        [SortOrder(Walk_Motion_Speed_Room__9050_sortIndex)]
        [DisplayName(Walk_Motion_Speed_Room__9050_displayName)]
        [IsReadOnly]
        public virtual float Walk_Motion_Speed_Room__9050 {
            get => GetData<float>(977);
            set {
                if (GetData<float>(977) == value) return;
                SetData(977, value, nameof(Walk_Motion_Speed_Room__9050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Walk_Motion_Speed_Room__9050));
            }
        }

        public const string Walk_Motion_Speed_9100_displayName = "Walk Motion Speed";
        public const int Walk_Motion_Speed_9100_sortIndex = 9100;
        [SortOrder(Walk_Motion_Speed_9100_sortIndex)]
        [DisplayName(Walk_Motion_Speed_9100_displayName)]
        [IsReadOnly]
        public virtual float Walk_Motion_Speed_9100 {
            get => GetData<float>(981);
            set {
                if (GetData<float>(981) == value) return;
                SetData(981, value, nameof(Walk_Motion_Speed_9100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Walk_Motion_Speed_9100));
            }
        }

        public const string Run_Stop_Margin_Time_9150_displayName = "Run Stop Margin Time";
        public const int Run_Stop_Margin_Time_9150_sortIndex = 9150;
        [SortOrder(Run_Stop_Margin_Time_9150_sortIndex)]
        [DisplayName(Run_Stop_Margin_Time_9150_displayName)]
        [IsReadOnly]
        public virtual float Run_Stop_Margin_Time_9150 {
            get => GetData<float>(985);
            set {
                if (GetData<float>(985) == value) return;
                SetData(985, value, nameof(Run_Stop_Margin_Time_9150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Stop_Margin_Time_9150));
            }
        }

        public const string Run_Turn_Speed_9200_displayName = "Run Turn Speed";
        public const int Run_Turn_Speed_9200_sortIndex = 9200;
        [SortOrder(Run_Turn_Speed_9200_sortIndex)]
        [DisplayName(Run_Turn_Speed_9200_displayName)]
        [IsReadOnly]
        public virtual float Run_Turn_Speed_9200 {
            get => GetData<float>(989);
            set {
                if (GetData<float>(989) == value) return;
                SetData(989, value, nameof(Run_Turn_Speed_9200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Turn_Speed_9200));
            }
        }

        public const string Run_Turn_Lever_Angle_9250_displayName = "Run Turn Lever Angle";
        public const int Run_Turn_Lever_Angle_9250_sortIndex = 9250;
        [SortOrder(Run_Turn_Lever_Angle_9250_sortIndex)]
        [DisplayName(Run_Turn_Lever_Angle_9250_displayName)]
        [IsReadOnly]
        public virtual float Run_Turn_Lever_Angle_9250 {
            get => GetData<float>(993);
            set {
                if (GetData<float>(993) == value) return;
                SetData(993, value, nameof(Run_Turn_Lever_Angle_9250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Turn_Lever_Angle_9250));
            }
        }

        public const string Run_Female_Motion_Start_Time_9300_displayName = "Run Female Motion Start Time";
        public const int Run_Female_Motion_Start_Time_9300_sortIndex = 9300;
        [SortOrder(Run_Female_Motion_Start_Time_9300_sortIndex)]
        [DisplayName(Run_Female_Motion_Start_Time_9300_displayName)]
        [IsReadOnly]
        public virtual float Run_Female_Motion_Start_Time_9300 {
            get => GetData<float>(997);
            set {
                if (GetData<float>(997) == value) return;
                SetData(997, value, nameof(Run_Female_Motion_Start_Time_9300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Female_Motion_Start_Time_9300));
            }
        }

        public const string Unk78_9350_displayName = "Unk78";
        public const int Unk78_9350_sortIndex = 9350;
        [SortOrder(Unk78_9350_sortIndex)]
        [DisplayName(Unk78_9350_displayName)]
        [IsReadOnly]
        public virtual float Unk78_9350 {
            get => GetData<float>(1001);
            set {
                if (GetData<float>(1001) == value) return;
                SetData(1001, value, nameof(Unk78_9350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk78_9350));
            }
        }

        public const string Unk79_9400_displayName = "Unk79";
        public const int Unk79_9400_sortIndex = 9400;
        [SortOrder(Unk79_9400_sortIndex)]
        [DisplayName(Unk79_9400_displayName)]
        [IsReadOnly]
        public virtual float Unk79_9400 {
            get => GetData<float>(1005);
            set {
                if (GetData<float>(1005) == value) return;
                SetData(1005, value, nameof(Unk79_9400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk79_9400));
            }
        }

        public const string Run_Motion_Speed_Room__9450_displayName = "Run Motion Speed (Room)";
        public const int Run_Motion_Speed_Room__9450_sortIndex = 9450;
        [SortOrder(Run_Motion_Speed_Room__9450_sortIndex)]
        [DisplayName(Run_Motion_Speed_Room__9450_displayName)]
        [IsReadOnly]
        public virtual float Run_Motion_Speed_Room__9450 {
            get => GetData<float>(1009);
            set {
                if (GetData<float>(1009) == value) return;
                SetData(1009, value, nameof(Run_Motion_Speed_Room__9450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Motion_Speed_Room__9450));
            }
        }

        public const string Run_Motion_Speed_9500_displayName = "Run Motion Speed";
        public const int Run_Motion_Speed_9500_sortIndex = 9500;
        [SortOrder(Run_Motion_Speed_9500_sortIndex)]
        [DisplayName(Run_Motion_Speed_9500_displayName)]
        [IsReadOnly]
        public virtual float Run_Motion_Speed_9500 {
            get => GetData<float>(1013);
            set {
                if (GetData<float>(1013) == value) return;
                SetData(1013, value, nameof(Run_Motion_Speed_9500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Run_Motion_Speed_9500));
            }
        }

        public const string Dash_Turn_Speed_9550_displayName = "Dash Turn Speed";
        public const int Dash_Turn_Speed_9550_sortIndex = 9550;
        [SortOrder(Dash_Turn_Speed_9550_sortIndex)]
        [DisplayName(Dash_Turn_Speed_9550_displayName)]
        [IsReadOnly]
        public virtual float Dash_Turn_Speed_9550 {
            get => GetData<float>(1017);
            set {
                if (GetData<float>(1017) == value) return;
                SetData(1017, value, nameof(Dash_Turn_Speed_9550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dash_Turn_Speed_9550));
            }
        }

        public const string Dash_Motion_Speed_9600_displayName = "Dash Motion Speed";
        public const int Dash_Motion_Speed_9600_sortIndex = 9600;
        [SortOrder(Dash_Motion_Speed_9600_sortIndex)]
        [DisplayName(Dash_Motion_Speed_9600_displayName)]
        [IsReadOnly]
        public virtual float Dash_Motion_Speed_9600 {
            get => GetData<float>(1021);
            set {
                if (GetData<float>(1021) == value) return;
                SetData(1021, value, nameof(Dash_Motion_Speed_9600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dash_Motion_Speed_9600));
            }
        }

        public const string Unk80_9650_displayName = "Unk80";
        public const int Unk80_9650_sortIndex = 9650;
        [SortOrder(Unk80_9650_sortIndex)]
        [DisplayName(Unk80_9650_displayName)]
        [IsReadOnly]
        public virtual float Unk80_9650 {
            get => GetData<float>(1025);
            set {
                if (GetData<float>(1025) == value) return;
                SetData(1025, value, nameof(Unk80_9650));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk80_9650));
            }
        }

        public const string Unk81_9700_displayName = "Unk81";
        public const int Unk81_9700_sortIndex = 9700;
        [SortOrder(Unk81_9700_sortIndex)]
        [DisplayName(Unk81_9700_displayName)]
        [IsReadOnly]
        public virtual float Unk81_9700 {
            get => GetData<float>(1029);
            set {
                if (GetData<float>(1029) == value) return;
                SetData(1029, value, nameof(Unk81_9700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk81_9700));
            }
        }

        public const string Unk82_9750_displayName = "Unk82";
        public const int Unk82_9750_sortIndex = 9750;
        [SortOrder(Unk82_9750_sortIndex)]
        [DisplayName(Unk82_9750_displayName)]
        [IsReadOnly]
        public virtual float Unk82_9750 {
            get => GetData<float>(1033);
            set {
                if (GetData<float>(1033) == value) return;
                SetData(1033, value, nameof(Unk82_9750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk82_9750));
            }
        }

        public const string Unk83_9800_displayName = "Unk83";
        public const int Unk83_9800_sortIndex = 9800;
        [SortOrder(Unk83_9800_sortIndex)]
        [DisplayName(Unk83_9800_displayName)]
        [IsReadOnly]
        public virtual float Unk83_9800 {
            get => GetData<float>(1037);
            set {
                if (GetData<float>(1037) == value) return;
                SetData(1037, value, nameof(Unk83_9800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk83_9800));
            }
        }

        public const string Unk84_9850_displayName = "Unk84";
        public const int Unk84_9850_sortIndex = 9850;
        [SortOrder(Unk84_9850_sortIndex)]
        [DisplayName(Unk84_9850_displayName)]
        [IsReadOnly]
        public virtual float Unk84_9850 {
            get => GetData<float>(1041);
            set {
                if (GetData<float>(1041) == value) return;
                SetData(1041, value, nameof(Unk84_9850));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk84_9850));
            }
        }

        public const string Unk85_9900_displayName = "Unk85";
        public const int Unk85_9900_sortIndex = 9900;
        [SortOrder(Unk85_9900_sortIndex)]
        [DisplayName(Unk85_9900_displayName)]
        [IsReadOnly]
        public virtual float Unk85_9900 {
            get => GetData<float>(1045);
            set {
                if (GetData<float>(1045) == value) return;
                SetData(1045, value, nameof(Unk85_9900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk85_9900));
            }
        }

        public const string Unk86_9950_displayName = "Unk86";
        public const int Unk86_9950_sortIndex = 9950;
        [SortOrder(Unk86_9950_sortIndex)]
        [DisplayName(Unk86_9950_displayName)]
        [IsReadOnly]
        public virtual float Unk86_9950 {
            get => GetData<float>(1049);
            set {
                if (GetData<float>(1049) == value) return;
                SetData(1049, value, nameof(Unk86_9950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk86_9950));
            }
        }

        public const string Unk87_10000_displayName = "Unk87";
        public const int Unk87_10000_sortIndex = 10000;
        [SortOrder(Unk87_10000_sortIndex)]
        [DisplayName(Unk87_10000_displayName)]
        [IsReadOnly]
        public virtual float Unk87_10000 {
            get => GetData<float>(1053);
            set {
                if (GetData<float>(1053) == value) return;
                SetData(1053, value, nameof(Unk87_10000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk87_10000));
            }
        }

        public const string Unk88_10050_displayName = "Unk88";
        public const int Unk88_10050_sortIndex = 10050;
        [SortOrder(Unk88_10050_sortIndex)]
        [DisplayName(Unk88_10050_displayName)]
        [IsReadOnly]
        public virtual float Unk88_10050 {
            get => GetData<float>(1057);
            set {
                if (GetData<float>(1057) == value) return;
                SetData(1057, value, nameof(Unk88_10050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk88_10050));
            }
        }

        public const string Unk89_10100_displayName = "Unk89";
        public const int Unk89_10100_sortIndex = 10100;
        [SortOrder(Unk89_10100_sortIndex)]
        [DisplayName(Unk89_10100_displayName)]
        [IsReadOnly]
        public virtual float Unk89_10100 {
            get => GetData<float>(1061);
            set {
                if (GetData<float>(1061) == value) return;
                SetData(1061, value, nameof(Unk89_10100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk89_10100));
            }
        }

        public const string Unk90_10150_displayName = "Unk90";
        public const int Unk90_10150_sortIndex = 10150;
        [SortOrder(Unk90_10150_sortIndex)]
        [DisplayName(Unk90_10150_displayName)]
        [IsReadOnly]
        public virtual float Unk90_10150 {
            get => GetData<float>(1065);
            set {
                if (GetData<float>(1065) == value) return;
                SetData(1065, value, nameof(Unk90_10150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk90_10150));
            }
        }

        public const string Unk91_10200_displayName = "Unk91";
        public const int Unk91_10200_sortIndex = 10200;
        [SortOrder(Unk91_10200_sortIndex)]
        [DisplayName(Unk91_10200_displayName)]
        [IsReadOnly]
        public virtual float Unk91_10200 {
            get => GetData<float>(1069);
            set {
                if (GetData<float>(1069) == value) return;
                SetData(1069, value, nameof(Unk91_10200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk91_10200));
            }
        }

        public const string Unk92_10250_displayName = "Unk92";
        public const int Unk92_10250_sortIndex = 10250;
        [SortOrder(Unk92_10250_sortIndex)]
        [DisplayName(Unk92_10250_displayName)]
        [IsReadOnly]
        public virtual float Unk92_10250 {
            get => GetData<float>(1073);
            set {
                if (GetData<float>(1073) == value) return;
                SetData(1073, value, nameof(Unk92_10250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk92_10250));
            }
        }

        public const string Unk93_10300_displayName = "Unk93";
        public const int Unk93_10300_sortIndex = 10300;
        [SortOrder(Unk93_10300_sortIndex)]
        [DisplayName(Unk93_10300_displayName)]
        [IsReadOnly]
        public virtual float Unk93_10300 {
            get => GetData<float>(1077);
            set {
                if (GetData<float>(1077) == value) return;
                SetData(1077, value, nameof(Unk93_10300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk93_10300));
            }
        }

        public const string Unk94_10350_displayName = "Unk94";
        public const int Unk94_10350_sortIndex = 10350;
        [SortOrder(Unk94_10350_sortIndex)]
        [DisplayName(Unk94_10350_displayName)]
        [IsReadOnly]
        public virtual float Unk94_10350 {
            get => GetData<float>(1081);
            set {
                if (GetData<float>(1081) == value) return;
                SetData(1081, value, nameof(Unk94_10350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk94_10350));
            }
        }

        public const string Unk95_10400_displayName = "Unk95";
        public const int Unk95_10400_sortIndex = 10400;
        [SortOrder(Unk95_10400_sortIndex)]
        [DisplayName(Unk95_10400_displayName)]
        [IsReadOnly]
        public virtual float Unk95_10400 {
            get => GetData<float>(1085);
            set {
                if (GetData<float>(1085) == value) return;
                SetData(1085, value, nameof(Unk95_10400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk95_10400));
            }
        }

        public const string Unk96_10450_displayName = "Unk96";
        public const int Unk96_10450_sortIndex = 10450;
        [SortOrder(Unk96_10450_sortIndex)]
        [DisplayName(Unk96_10450_displayName)]
        [IsReadOnly]
        public virtual float Unk96_10450 {
            get => GetData<float>(1089);
            set {
                if (GetData<float>(1089) == value) return;
                SetData(1089, value, nameof(Unk96_10450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk96_10450));
            }
        }

        public const string __10500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __10500_sortIndex = 10500;
        [SortOrder(__10500_sortIndex)]
        [DisplayName(__10500_displayName)]
        [IsReadOnly]
        public virtual byte __10500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__10500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__10500));
            }
        }

        public const string _Skipping_ahead__10550_displayName = "------Skipping ahead.";
        public const int _Skipping_ahead__10550_sortIndex = 10550;
        [SortOrder(_Skipping_ahead__10550_sortIndex)]
        [DisplayName(_Skipping_ahead__10550_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_ahead__10550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(_Skipping_ahead__10550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead__10550));
            }
        }

        public const string __10600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __10600_sortIndex = 10600;
        [SortOrder(__10600_sortIndex)]
        [DisplayName(__10600_displayName)]
        [IsReadOnly]
        public virtual byte __10600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__10600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__10600));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_0_displayName = "Dodge IFrames: Normal: Evasion 0";
        public const int Dodge_IFrames_Normal_Evasion_0_sortIndex = 10650;
        [SortOrder(Dodge_IFrames_Normal_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_0 {
            get => GetData<float>(1157);
            set {
                if (GetData<float>(1157) == value) return;
                SetData(1157, value, nameof(Dodge_IFrames_Normal_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_1_displayName = "Dodge IFrames: Normal: Evasion 1";
        public const int Dodge_IFrames_Normal_Evasion_1_sortIndex = 10700;
        [SortOrder(Dodge_IFrames_Normal_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_1 {
            get => GetData<float>(1161);
            set {
                if (GetData<float>(1161) == value) return;
                SetData(1161, value, nameof(Dodge_IFrames_Normal_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_2_displayName = "Dodge IFrames: Normal: Evasion 2";
        public const int Dodge_IFrames_Normal_Evasion_2_sortIndex = 10750;
        [SortOrder(Dodge_IFrames_Normal_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_2 {
            get => GetData<float>(1165);
            set {
                if (GetData<float>(1165) == value) return;
                SetData(1165, value, nameof(Dodge_IFrames_Normal_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_3_displayName = "Dodge IFrames: Normal: Evasion 3";
        public const int Dodge_IFrames_Normal_Evasion_3_sortIndex = 10800;
        [SortOrder(Dodge_IFrames_Normal_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_3 {
            get => GetData<float>(1169);
            set {
                if (GetData<float>(1169) == value) return;
                SetData(1169, value, nameof(Dodge_IFrames_Normal_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_4_displayName = "Dodge IFrames: Normal: Evasion 4";
        public const int Dodge_IFrames_Normal_Evasion_4_sortIndex = 10850;
        [SortOrder(Dodge_IFrames_Normal_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_4 {
            get => GetData<float>(1173);
            set {
                if (GetData<float>(1173) == value) return;
                SetData(1173, value, nameof(Dodge_IFrames_Normal_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_5_displayName = "Dodge IFrames: Normal: Evasion 5";
        public const int Dodge_IFrames_Normal_Evasion_5_sortIndex = 10900;
        [SortOrder(Dodge_IFrames_Normal_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_5 {
            get => GetData<float>(1177);
            set {
                if (GetData<float>(1177) == value) return;
                SetData(1177, value, nameof(Dodge_IFrames_Normal_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Normal_Evasion_Mantle_displayName = "Dodge IFrames: Normal: Evasion Mantle";
        public const int Dodge_IFrames_Normal_Evasion_Mantle_sortIndex = 10950;
        [SortOrder(Dodge_IFrames_Normal_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Normal_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Normal_Evasion_Mantle {
            get => GetData<float>(1181);
            set {
                if (GetData<float>(1181) == value) return;
                SetData(1181, value, nameof(Dodge_IFrames_Normal_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Normal_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_0_displayName = "Dodge IFrames: Step: Evasion 0";
        public const int Dodge_IFrames_Step_Evasion_0_sortIndex = 11000;
        [SortOrder(Dodge_IFrames_Step_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_0 {
            get => GetData<float>(1185);
            set {
                if (GetData<float>(1185) == value) return;
                SetData(1185, value, nameof(Dodge_IFrames_Step_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_1_displayName = "Dodge IFrames: Step: Evasion 1";
        public const int Dodge_IFrames_Step_Evasion_1_sortIndex = 11050;
        [SortOrder(Dodge_IFrames_Step_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_1 {
            get => GetData<float>(1189);
            set {
                if (GetData<float>(1189) == value) return;
                SetData(1189, value, nameof(Dodge_IFrames_Step_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_2_displayName = "Dodge IFrames: Step: Evasion 2";
        public const int Dodge_IFrames_Step_Evasion_2_sortIndex = 11100;
        [SortOrder(Dodge_IFrames_Step_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_2 {
            get => GetData<float>(1193);
            set {
                if (GetData<float>(1193) == value) return;
                SetData(1193, value, nameof(Dodge_IFrames_Step_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_3_displayName = "Dodge IFrames: Step: Evasion 3";
        public const int Dodge_IFrames_Step_Evasion_3_sortIndex = 11150;
        [SortOrder(Dodge_IFrames_Step_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_3 {
            get => GetData<float>(1197);
            set {
                if (GetData<float>(1197) == value) return;
                SetData(1197, value, nameof(Dodge_IFrames_Step_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_4_displayName = "Dodge IFrames: Step: Evasion 4";
        public const int Dodge_IFrames_Step_Evasion_4_sortIndex = 11200;
        [SortOrder(Dodge_IFrames_Step_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_4 {
            get => GetData<float>(1201);
            set {
                if (GetData<float>(1201) == value) return;
                SetData(1201, value, nameof(Dodge_IFrames_Step_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_5_displayName = "Dodge IFrames: Step: Evasion 5";
        public const int Dodge_IFrames_Step_Evasion_5_sortIndex = 11250;
        [SortOrder(Dodge_IFrames_Step_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_5 {
            get => GetData<float>(1205);
            set {
                if (GetData<float>(1205) == value) return;
                SetData(1205, value, nameof(Dodge_IFrames_Step_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Step_Evasion_Mantle_displayName = "Dodge IFrames: Step: Evasion Mantle";
        public const int Dodge_IFrames_Step_Evasion_Mantle_sortIndex = 11300;
        [SortOrder(Dodge_IFrames_Step_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Step_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Step_Evasion_Mantle {
            get => GetData<float>(1209);
            set {
                if (GetData<float>(1209) == value) return;
                SetData(1209, value, nameof(Dodge_IFrames_Step_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Step_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion 0";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0_sortIndex = 11350;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0 {
            get => GetData<float>(1213);
            set {
                if (GetData<float>(1213) == value) return;
                SetData(1213, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion 1";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1_sortIndex = 11400;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1 {
            get => GetData<float>(1217);
            set {
                if (GetData<float>(1217) == value) return;
                SetData(1217, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion 2";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2_sortIndex = 11450;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2 {
            get => GetData<float>(1221);
            set {
                if (GetData<float>(1221) == value) return;
                SetData(1221, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion 3";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3_sortIndex = 11500;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3 {
            get => GetData<float>(1225);
            set {
                if (GetData<float>(1225) == value) return;
                SetData(1225, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion 4";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4_sortIndex = 11550;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4 {
            get => GetData<float>(1229);
            set {
                if (GetData<float>(1229) == value) return;
                SetData(1229, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion 5";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5_sortIndex = 11600;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5 {
            get => GetData<float>(1233);
            set {
                if (GetData<float>(1233) == value) return;
                SetData(1233, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle_displayName = "Dodge IFrames: Sword & Shield Back Step: Evasion Mantle";
        public const int Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle_sortIndex = 11650;
        [SortOrder(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle {
            get => GetData<float>(1237);
            set {
                if (GetData<float>(1237) == value) return;
                SetData(1237, value, nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Sword_Shield_Back_Step_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion 0";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0_sortIndex = 11700;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0 {
            get => GetData<float>(1241);
            set {
                if (GetData<float>(1241) == value) return;
                SetData(1241, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion 1";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1_sortIndex = 11750;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1 {
            get => GetData<float>(1245);
            set {
                if (GetData<float>(1245) == value) return;
                SetData(1245, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion 2";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2_sortIndex = 11800;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2 {
            get => GetData<float>(1249);
            set {
                if (GetData<float>(1249) == value) return;
                SetData(1249, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion 3";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3_sortIndex = 11850;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3 {
            get => GetData<float>(1253);
            set {
                if (GetData<float>(1253) == value) return;
                SetData(1253, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion 4";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4_sortIndex = 11900;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4 {
            get => GetData<float>(1257);
            set {
                if (GetData<float>(1257) == value) return;
                SetData(1257, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion 5";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5_sortIndex = 11950;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5 {
            get => GetData<float>(1261);
            set {
                if (GetData<float>(1261) == value) return;
                SetData(1261, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle_displayName = "Dodge IFrames: Dual Blades Demon Mode Step: Evasion Mantle";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle_sortIndex = 12000;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle {
            get => GetData<float>(1265);
            set {
                if (GetData<float>(1265) == value) return;
                SetData(1265, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Step_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_0_displayName = "Dodge IFrames: Long Sword Counter: Evasion 0";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_0_sortIndex = 12050;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_0 {
            get => GetData<float>(1269);
            set {
                if (GetData<float>(1269) == value) return;
                SetData(1269, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_1_displayName = "Dodge IFrames: Long Sword Counter: Evasion 1";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_1_sortIndex = 12100;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_1 {
            get => GetData<float>(1273);
            set {
                if (GetData<float>(1273) == value) return;
                SetData(1273, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_2_displayName = "Dodge IFrames: Long Sword Counter: Evasion 2";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_2_sortIndex = 12150;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_2 {
            get => GetData<float>(1277);
            set {
                if (GetData<float>(1277) == value) return;
                SetData(1277, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_3_displayName = "Dodge IFrames: Long Sword Counter: Evasion 3";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_3_sortIndex = 12200;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_3 {
            get => GetData<float>(1281);
            set {
                if (GetData<float>(1281) == value) return;
                SetData(1281, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_4_displayName = "Dodge IFrames: Long Sword Counter: Evasion 4";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_4_sortIndex = 12250;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_4 {
            get => GetData<float>(1285);
            set {
                if (GetData<float>(1285) == value) return;
                SetData(1285, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_5_displayName = "Dodge IFrames: Long Sword Counter: Evasion 5";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_5_sortIndex = 12300;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_5 {
            get => GetData<float>(1289);
            set {
                if (GetData<float>(1289) == value) return;
                SetData(1289, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle_displayName = "Dodge IFrames: Long Sword Counter: Evasion Mantle";
        public const int Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle_sortIndex = 12350;
        [SortOrder(Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle {
            get => GetData<float>(1293);
            set {
                if (GetData<float>(1293) == value) return;
                SetData(1293, value, nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Long_Sword_Counter_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_0_displayName = "Dodge IFrames: Bow Charge Step: Evasion 0";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_0_sortIndex = 12400;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_0 {
            get => GetData<float>(1297);
            set {
                if (GetData<float>(1297) == value) return;
                SetData(1297, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_1_displayName = "Dodge IFrames: Bow Charge Step: Evasion 1";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_1_sortIndex = 12450;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_1 {
            get => GetData<float>(1301);
            set {
                if (GetData<float>(1301) == value) return;
                SetData(1301, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_2_displayName = "Dodge IFrames: Bow Charge Step: Evasion 2";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_2_sortIndex = 12500;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_2 {
            get => GetData<float>(1305);
            set {
                if (GetData<float>(1305) == value) return;
                SetData(1305, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_3_displayName = "Dodge IFrames: Bow Charge Step: Evasion 3";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_3_sortIndex = 12550;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_3 {
            get => GetData<float>(1309);
            set {
                if (GetData<float>(1309) == value) return;
                SetData(1309, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_4_displayName = "Dodge IFrames: Bow Charge Step: Evasion 4";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_4_sortIndex = 12600;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_4 {
            get => GetData<float>(1313);
            set {
                if (GetData<float>(1313) == value) return;
                SetData(1313, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_5_displayName = "Dodge IFrames: Bow Charge Step: Evasion 5";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_5_sortIndex = 12650;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_5 {
            get => GetData<float>(1317);
            set {
                if (GetData<float>(1317) == value) return;
                SetData(1317, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle_displayName = "Dodge IFrames: Bow Charge Step: Evasion Mantle";
        public const int Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle_sortIndex = 12700;
        [SortOrder(Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle {
            get => GetData<float>(1321);
            set {
                if (GetData<float>(1321) == value) return;
                SetData(1321, value, nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Bow_Charge_Step_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_0_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion 0";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_0_sortIndex = 12750;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_0 {
            get => GetData<float>(1325);
            set {
                if (GetData<float>(1325) == value) return;
                SetData(1325, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_0));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_1_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion 1";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_1_sortIndex = 12800;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_1 {
            get => GetData<float>(1329);
            set {
                if (GetData<float>(1329) == value) return;
                SetData(1329, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_1));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_2_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion 2";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_2_sortIndex = 12850;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_2 {
            get => GetData<float>(1333);
            set {
                if (GetData<float>(1333) == value) return;
                SetData(1333, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_2));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_3_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion 3";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_3_sortIndex = 12900;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_3 {
            get => GetData<float>(1337);
            set {
                if (GetData<float>(1337) == value) return;
                SetData(1337, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_3));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_4_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion 4";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_4_sortIndex = 12950;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_4 {
            get => GetData<float>(1341);
            set {
                if (GetData<float>(1341) == value) return;
                SetData(1341, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_4));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_5_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion 5";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_5_sortIndex = 13000;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_5 {
            get => GetData<float>(1345);
            set {
                if (GetData<float>(1345) == value) return;
                SetData(1345, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_5));
            }
        }

        public const string Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle_displayName = "Dodge IFrames: HBG Roll Dodge: Evasion Mantle";
        public const int Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle_sortIndex = 13050;
        [SortOrder(Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle {
            get => GetData<float>(1349);
            set {
                if (GetData<float>(1349) == value) return;
                SetData(1349, value, nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_HBG_Roll_Dodge_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_0_displayName = "Dodge IFrames: LBG Side Dodge: Evasion 0";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_0_sortIndex = 13100;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_0 {
            get => GetData<float>(1353);
            set {
                if (GetData<float>(1353) == value) return;
                SetData(1353, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_0));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_1_displayName = "Dodge IFrames: LBG Side Dodge: Evasion 1";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_1_sortIndex = 13150;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_1 {
            get => GetData<float>(1357);
            set {
                if (GetData<float>(1357) == value) return;
                SetData(1357, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_1));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_2_displayName = "Dodge IFrames: LBG Side Dodge: Evasion 2";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_2_sortIndex = 13200;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_2 {
            get => GetData<float>(1361);
            set {
                if (GetData<float>(1361) == value) return;
                SetData(1361, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_2));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_3_displayName = "Dodge IFrames: LBG Side Dodge: Evasion 3";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_3_sortIndex = 13250;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_3 {
            get => GetData<float>(1365);
            set {
                if (GetData<float>(1365) == value) return;
                SetData(1365, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_3));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_4_displayName = "Dodge IFrames: LBG Side Dodge: Evasion 4";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_4_sortIndex = 13300;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_4 {
            get => GetData<float>(1369);
            set {
                if (GetData<float>(1369) == value) return;
                SetData(1369, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_4));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_5_displayName = "Dodge IFrames: LBG Side Dodge: Evasion 5";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_5_sortIndex = 13350;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_5 {
            get => GetData<float>(1373);
            set {
                if (GetData<float>(1373) == value) return;
                SetData(1373, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_5));
            }
        }

        public const string Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle_displayName = "Dodge IFrames: LBG Side Dodge: Evasion Mantle";
        public const int Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle_sortIndex = 13400;
        [SortOrder(Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle {
            get => GetData<float>(1377);
            set {
                if (GetData<float>(1377) == value) return;
                SetData(1377, value, nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_LBG_Side_Dodge_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion 0";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0_sortIndex = 13450;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0 {
            get => GetData<float>(1381);
            set {
                if (GetData<float>(1381) == value) return;
                SetData(1381, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion 1";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1_sortIndex = 13500;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1 {
            get => GetData<float>(1385);
            set {
                if (GetData<float>(1385) == value) return;
                SetData(1385, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion 2";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2_sortIndex = 13550;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2 {
            get => GetData<float>(1389);
            set {
                if (GetData<float>(1389) == value) return;
                SetData(1389, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion 3";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3_sortIndex = 13600;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3 {
            get => GetData<float>(1393);
            set {
                if (GetData<float>(1393) == value) return;
                SetData(1393, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion 4";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4_sortIndex = 13650;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4 {
            get => GetData<float>(1397);
            set {
                if (GetData<float>(1397) == value) return;
                SetData(1397, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion 5";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5_sortIndex = 13700;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5 {
            get => GetData<float>(1401);
            set {
                if (GetData<float>(1401) == value) return;
                SetData(1401, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle_displayName = "Dodge IFrames: Dual Blades Demon Mode Slinger Evade: Evasion Mantle";
        public const int Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle_sortIndex = 13750;
        [SortOrder(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle {
            get => GetData<float>(1405);
            set {
                if (GetData<float>(1405) == value) return;
                SetData(1405, value, nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Demon_Mode_Slinger_Evade_Evasion_Mantle));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion 0";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0_sortIndex = 13800;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0 {
            get => GetData<float>(1409);
            set {
                if (GetData<float>(1409) == value) return;
                SetData(1409, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_0));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion 1";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1_sortIndex = 13850;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1 {
            get => GetData<float>(1413);
            set {
                if (GetData<float>(1413) == value) return;
                SetData(1413, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_1));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion 2";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2_sortIndex = 13900;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2 {
            get => GetData<float>(1417);
            set {
                if (GetData<float>(1417) == value) return;
                SetData(1417, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_2));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion 3";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3_sortIndex = 13950;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3 {
            get => GetData<float>(1421);
            set {
                if (GetData<float>(1421) == value) return;
                SetData(1421, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_3));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion 4";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4_sortIndex = 14000;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4 {
            get => GetData<float>(1425);
            set {
                if (GetData<float>(1425) == value) return;
                SetData(1425, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_4));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion 5";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5_sortIndex = 14050;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5 {
            get => GetData<float>(1429);
            set {
                if (GetData<float>(1429) == value) return;
                SetData(1429, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_5));
            }
        }

        public const string Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle_displayName = "Dodge IFrames: Dual Blades Slinger Evade: Evasion Mantle";
        public const int Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle_sortIndex = 14100;
        [SortOrder(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle_sortIndex)]
        [DisplayName(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle_displayName)]
        public virtual float Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle {
            get => GetData<float>(1433);
            set {
                if (GetData<float>(1433) == value) return;
                SetData(1433, value, nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dodge_IFrames_Dual_Blades_Slinger_Evade_Evasion_Mantle));
            }
        }

        public const string __14150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14150_sortIndex = 14150;
        [SortOrder(__14150_sortIndex)]
        [DisplayName(__14150_displayName)]
        [IsReadOnly]
        public virtual byte __14150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__14150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__14150));
            }
        }

        public const string Evade_Normal_Distance_1_displayName = "Evade: Normal: Distance 1";
        public const int Evade_Normal_Distance_1_sortIndex = 14200;
        [SortOrder(Evade_Normal_Distance_1_sortIndex)]
        [DisplayName(Evade_Normal_Distance_1_displayName)]
        public virtual float Evade_Normal_Distance_1 {
            get => GetData<float>(1437);
            set {
                if (GetData<float>(1437) == value) return;
                SetData(1437, value, nameof(Evade_Normal_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Normal_Distance_1));
            }
        }

        public const string Evade_Normal_Distance_2_displayName = "Evade: Normal: Distance 2";
        public const int Evade_Normal_Distance_2_sortIndex = 14250;
        [SortOrder(Evade_Normal_Distance_2_sortIndex)]
        [DisplayName(Evade_Normal_Distance_2_displayName)]
        public virtual float Evade_Normal_Distance_2 {
            get => GetData<float>(1441);
            set {
                if (GetData<float>(1441) == value) return;
                SetData(1441, value, nameof(Evade_Normal_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Normal_Distance_2));
            }
        }

        public const string Evade_Normal_Distance_3_displayName = "Evade: Normal: Distance 3";
        public const int Evade_Normal_Distance_3_sortIndex = 14300;
        [SortOrder(Evade_Normal_Distance_3_sortIndex)]
        [DisplayName(Evade_Normal_Distance_3_displayName)]
        public virtual float Evade_Normal_Distance_3 {
            get => GetData<float>(1445);
            set {
                if (GetData<float>(1445) == value) return;
                SetData(1445, value, nameof(Evade_Normal_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Normal_Distance_3));
            }
        }

        public const string Evade_Step_Distance_1_displayName = "Evade: Step: Distance 1";
        public const int Evade_Step_Distance_1_sortIndex = 14350;
        [SortOrder(Evade_Step_Distance_1_sortIndex)]
        [DisplayName(Evade_Step_Distance_1_displayName)]
        public virtual float Evade_Step_Distance_1 {
            get => GetData<float>(1449);
            set {
                if (GetData<float>(1449) == value) return;
                SetData(1449, value, nameof(Evade_Step_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Step_Distance_1));
            }
        }

        public const string Evade_Step_Distance_2_displayName = "Evade: Step: Distance 2";
        public const int Evade_Step_Distance_2_sortIndex = 14400;
        [SortOrder(Evade_Step_Distance_2_sortIndex)]
        [DisplayName(Evade_Step_Distance_2_displayName)]
        public virtual float Evade_Step_Distance_2 {
            get => GetData<float>(1453);
            set {
                if (GetData<float>(1453) == value) return;
                SetData(1453, value, nameof(Evade_Step_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Step_Distance_2));
            }
        }

        public const string Evade_Step_Distance_3_displayName = "Evade: Step: Distance 3";
        public const int Evade_Step_Distance_3_sortIndex = 14450;
        [SortOrder(Evade_Step_Distance_3_sortIndex)]
        [DisplayName(Evade_Step_Distance_3_displayName)]
        public virtual float Evade_Step_Distance_3 {
            get => GetData<float>(1457);
            set {
                if (GetData<float>(1457) == value) return;
                SetData(1457, value, nameof(Evade_Step_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Step_Distance_3));
            }
        }

        public const string Evade_Sword_Shield_Back_Step_Distance_1_displayName = "Evade: Sword & Shield Back Step: Distance 1";
        public const int Evade_Sword_Shield_Back_Step_Distance_1_sortIndex = 14500;
        [SortOrder(Evade_Sword_Shield_Back_Step_Distance_1_sortIndex)]
        [DisplayName(Evade_Sword_Shield_Back_Step_Distance_1_displayName)]
        public virtual float Evade_Sword_Shield_Back_Step_Distance_1 {
            get => GetData<float>(1461);
            set {
                if (GetData<float>(1461) == value) return;
                SetData(1461, value, nameof(Evade_Sword_Shield_Back_Step_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Sword_Shield_Back_Step_Distance_1));
            }
        }

        public const string Evade_Sword_Shield_Back_Step_Distance_2_displayName = "Evade: Sword & Shield Back Step: Distance 2";
        public const int Evade_Sword_Shield_Back_Step_Distance_2_sortIndex = 14550;
        [SortOrder(Evade_Sword_Shield_Back_Step_Distance_2_sortIndex)]
        [DisplayName(Evade_Sword_Shield_Back_Step_Distance_2_displayName)]
        public virtual float Evade_Sword_Shield_Back_Step_Distance_2 {
            get => GetData<float>(1465);
            set {
                if (GetData<float>(1465) == value) return;
                SetData(1465, value, nameof(Evade_Sword_Shield_Back_Step_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Sword_Shield_Back_Step_Distance_2));
            }
        }

        public const string Evade_Sword_Shield_Back_Step_Distance_3_displayName = "Evade: Sword & Shield Back Step: Distance 3";
        public const int Evade_Sword_Shield_Back_Step_Distance_3_sortIndex = 14600;
        [SortOrder(Evade_Sword_Shield_Back_Step_Distance_3_sortIndex)]
        [DisplayName(Evade_Sword_Shield_Back_Step_Distance_3_displayName)]
        public virtual float Evade_Sword_Shield_Back_Step_Distance_3 {
            get => GetData<float>(1469);
            set {
                if (GetData<float>(1469) == value) return;
                SetData(1469, value, nameof(Evade_Sword_Shield_Back_Step_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Sword_Shield_Back_Step_Distance_3));
            }
        }

        public const string Evade_Dual_Blades_DemonMode_Step_Distance_1_displayName = "Evade: Dual Blades DemonMode Step: Distance 1";
        public const int Evade_Dual_Blades_DemonMode_Step_Distance_1_sortIndex = 14650;
        [SortOrder(Evade_Dual_Blades_DemonMode_Step_Distance_1_sortIndex)]
        [DisplayName(Evade_Dual_Blades_DemonMode_Step_Distance_1_displayName)]
        public virtual float Evade_Dual_Blades_DemonMode_Step_Distance_1 {
            get => GetData<float>(1473);
            set {
                if (GetData<float>(1473) == value) return;
                SetData(1473, value, nameof(Evade_Dual_Blades_DemonMode_Step_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_DemonMode_Step_Distance_1));
            }
        }

        public const string Evade_Dual_Blades_DemonMode_Step_Distance_2_displayName = "Evade: Dual Blades DemonMode Step: Distance 2";
        public const int Evade_Dual_Blades_DemonMode_Step_Distance_2_sortIndex = 14700;
        [SortOrder(Evade_Dual_Blades_DemonMode_Step_Distance_2_sortIndex)]
        [DisplayName(Evade_Dual_Blades_DemonMode_Step_Distance_2_displayName)]
        public virtual float Evade_Dual_Blades_DemonMode_Step_Distance_2 {
            get => GetData<float>(1477);
            set {
                if (GetData<float>(1477) == value) return;
                SetData(1477, value, nameof(Evade_Dual_Blades_DemonMode_Step_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_DemonMode_Step_Distance_2));
            }
        }

        public const string Evade_Dual_Blades_DemonMode_Step_Distance_3_displayName = "Evade: Dual Blades DemonMode Step: Distance 3";
        public const int Evade_Dual_Blades_DemonMode_Step_Distance_3_sortIndex = 14750;
        [SortOrder(Evade_Dual_Blades_DemonMode_Step_Distance_3_sortIndex)]
        [DisplayName(Evade_Dual_Blades_DemonMode_Step_Distance_3_displayName)]
        public virtual float Evade_Dual_Blades_DemonMode_Step_Distance_3 {
            get => GetData<float>(1481);
            set {
                if (GetData<float>(1481) == value) return;
                SetData(1481, value, nameof(Evade_Dual_Blades_DemonMode_Step_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_DemonMode_Step_Distance_3));
            }
        }

        public const string Evade_Long_Sword_Counter_Distance_1_displayName = "Evade: Long Sword Counter: Distance 1";
        public const int Evade_Long_Sword_Counter_Distance_1_sortIndex = 14800;
        [SortOrder(Evade_Long_Sword_Counter_Distance_1_sortIndex)]
        [DisplayName(Evade_Long_Sword_Counter_Distance_1_displayName)]
        public virtual float Evade_Long_Sword_Counter_Distance_1 {
            get => GetData<float>(1485);
            set {
                if (GetData<float>(1485) == value) return;
                SetData(1485, value, nameof(Evade_Long_Sword_Counter_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Long_Sword_Counter_Distance_1));
            }
        }

        public const string Evade_Long_Sword_Counter_Distance_2_displayName = "Evade: Long Sword Counter: Distance 2";
        public const int Evade_Long_Sword_Counter_Distance_2_sortIndex = 14850;
        [SortOrder(Evade_Long_Sword_Counter_Distance_2_sortIndex)]
        [DisplayName(Evade_Long_Sword_Counter_Distance_2_displayName)]
        public virtual float Evade_Long_Sword_Counter_Distance_2 {
            get => GetData<float>(1489);
            set {
                if (GetData<float>(1489) == value) return;
                SetData(1489, value, nameof(Evade_Long_Sword_Counter_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Long_Sword_Counter_Distance_2));
            }
        }

        public const string Evade_Long_Sword_Counter_Distance_3_displayName = "Evade: Long Sword Counter: Distance 3";
        public const int Evade_Long_Sword_Counter_Distance_3_sortIndex = 14900;
        [SortOrder(Evade_Long_Sword_Counter_Distance_3_sortIndex)]
        [DisplayName(Evade_Long_Sword_Counter_Distance_3_displayName)]
        public virtual float Evade_Long_Sword_Counter_Distance_3 {
            get => GetData<float>(1493);
            set {
                if (GetData<float>(1493) == value) return;
                SetData(1493, value, nameof(Evade_Long_Sword_Counter_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Long_Sword_Counter_Distance_3));
            }
        }

        public const string Evade_Insect_Glaive_Air_Dodge_Distance_1_displayName = "Evade: Insect Glaive Air Dodge: Distance 1";
        public const int Evade_Insect_Glaive_Air_Dodge_Distance_1_sortIndex = 14950;
        [SortOrder(Evade_Insect_Glaive_Air_Dodge_Distance_1_sortIndex)]
        [DisplayName(Evade_Insect_Glaive_Air_Dodge_Distance_1_displayName)]
        public virtual float Evade_Insect_Glaive_Air_Dodge_Distance_1 {
            get => GetData<float>(1497);
            set {
                if (GetData<float>(1497) == value) return;
                SetData(1497, value, nameof(Evade_Insect_Glaive_Air_Dodge_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Insect_Glaive_Air_Dodge_Distance_1));
            }
        }

        public const string Evade_Insect_Glaive_Air_Dodge_Distance_2_displayName = "Evade: Insect Glaive Air Dodge: Distance 2";
        public const int Evade_Insect_Glaive_Air_Dodge_Distance_2_sortIndex = 15000;
        [SortOrder(Evade_Insect_Glaive_Air_Dodge_Distance_2_sortIndex)]
        [DisplayName(Evade_Insect_Glaive_Air_Dodge_Distance_2_displayName)]
        public virtual float Evade_Insect_Glaive_Air_Dodge_Distance_2 {
            get => GetData<float>(1501);
            set {
                if (GetData<float>(1501) == value) return;
                SetData(1501, value, nameof(Evade_Insect_Glaive_Air_Dodge_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Insect_Glaive_Air_Dodge_Distance_2));
            }
        }

        public const string Evade_Insect_Glaive_Air_Dodge_Distance_3_displayName = "Evade: Insect Glaive Air Dodge: Distance 3";
        public const int Evade_Insect_Glaive_Air_Dodge_Distance_3_sortIndex = 15050;
        [SortOrder(Evade_Insect_Glaive_Air_Dodge_Distance_3_sortIndex)]
        [DisplayName(Evade_Insect_Glaive_Air_Dodge_Distance_3_displayName)]
        public virtual float Evade_Insect_Glaive_Air_Dodge_Distance_3 {
            get => GetData<float>(1505);
            set {
                if (GetData<float>(1505) == value) return;
                SetData(1505, value, nameof(Evade_Insect_Glaive_Air_Dodge_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Insect_Glaive_Air_Dodge_Distance_3));
            }
        }

        public const string Evade_Bow_Charge_Step_Distance_1_displayName = "Evade: Bow Charge Step: Distance 1";
        public const int Evade_Bow_Charge_Step_Distance_1_sortIndex = 15100;
        [SortOrder(Evade_Bow_Charge_Step_Distance_1_sortIndex)]
        [DisplayName(Evade_Bow_Charge_Step_Distance_1_displayName)]
        public virtual float Evade_Bow_Charge_Step_Distance_1 {
            get => GetData<float>(1509);
            set {
                if (GetData<float>(1509) == value) return;
                SetData(1509, value, nameof(Evade_Bow_Charge_Step_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Bow_Charge_Step_Distance_1));
            }
        }

        public const string Evade_Bow_Charge_Step_Distance_2_displayName = "Evade: Bow Charge Step: Distance 2";
        public const int Evade_Bow_Charge_Step_Distance_2_sortIndex = 15150;
        [SortOrder(Evade_Bow_Charge_Step_Distance_2_sortIndex)]
        [DisplayName(Evade_Bow_Charge_Step_Distance_2_displayName)]
        public virtual float Evade_Bow_Charge_Step_Distance_2 {
            get => GetData<float>(1513);
            set {
                if (GetData<float>(1513) == value) return;
                SetData(1513, value, nameof(Evade_Bow_Charge_Step_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Bow_Charge_Step_Distance_2));
            }
        }

        public const string Evade_Bow_Charge_Step_Distance_3_displayName = "Evade: Bow Charge Step: Distance 3";
        public const int Evade_Bow_Charge_Step_Distance_3_sortIndex = 15200;
        [SortOrder(Evade_Bow_Charge_Step_Distance_3_sortIndex)]
        [DisplayName(Evade_Bow_Charge_Step_Distance_3_displayName)]
        public virtual float Evade_Bow_Charge_Step_Distance_3 {
            get => GetData<float>(1517);
            set {
                if (GetData<float>(1517) == value) return;
                SetData(1517, value, nameof(Evade_Bow_Charge_Step_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Bow_Charge_Step_Distance_3));
            }
        }

        public const string Evade_HBG_Roll_Dodge_Distance_1_displayName = "Evade: HBG Roll Dodge: Distance 1";
        public const int Evade_HBG_Roll_Dodge_Distance_1_sortIndex = 15250;
        [SortOrder(Evade_HBG_Roll_Dodge_Distance_1_sortIndex)]
        [DisplayName(Evade_HBG_Roll_Dodge_Distance_1_displayName)]
        public virtual float Evade_HBG_Roll_Dodge_Distance_1 {
            get => GetData<float>(1521);
            set {
                if (GetData<float>(1521) == value) return;
                SetData(1521, value, nameof(Evade_HBG_Roll_Dodge_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_HBG_Roll_Dodge_Distance_1));
            }
        }

        public const string Evade_HBG_Roll_Dodge_Distance_2_displayName = "Evade: HBG Roll Dodge: Distance 2";
        public const int Evade_HBG_Roll_Dodge_Distance_2_sortIndex = 15300;
        [SortOrder(Evade_HBG_Roll_Dodge_Distance_2_sortIndex)]
        [DisplayName(Evade_HBG_Roll_Dodge_Distance_2_displayName)]
        public virtual float Evade_HBG_Roll_Dodge_Distance_2 {
            get => GetData<float>(1525);
            set {
                if (GetData<float>(1525) == value) return;
                SetData(1525, value, nameof(Evade_HBG_Roll_Dodge_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_HBG_Roll_Dodge_Distance_2));
            }
        }

        public const string Evade_HBG_Roll_Dodge_Distance_3_displayName = "Evade: HBG Roll Dodge: Distance 3";
        public const int Evade_HBG_Roll_Dodge_Distance_3_sortIndex = 15350;
        [SortOrder(Evade_HBG_Roll_Dodge_Distance_3_sortIndex)]
        [DisplayName(Evade_HBG_Roll_Dodge_Distance_3_displayName)]
        public virtual float Evade_HBG_Roll_Dodge_Distance_3 {
            get => GetData<float>(1529);
            set {
                if (GetData<float>(1529) == value) return;
                SetData(1529, value, nameof(Evade_HBG_Roll_Dodge_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_HBG_Roll_Dodge_Distance_3));
            }
        }

        public const string Evade_LBG_Side_Dodge_Distance_1_displayName = "Evade: LBG Side Dodge: Distance 1";
        public const int Evade_LBG_Side_Dodge_Distance_1_sortIndex = 15400;
        [SortOrder(Evade_LBG_Side_Dodge_Distance_1_sortIndex)]
        [DisplayName(Evade_LBG_Side_Dodge_Distance_1_displayName)]
        public virtual float Evade_LBG_Side_Dodge_Distance_1 {
            get => GetData<float>(1533);
            set {
                if (GetData<float>(1533) == value) return;
                SetData(1533, value, nameof(Evade_LBG_Side_Dodge_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_LBG_Side_Dodge_Distance_1));
            }
        }

        public const string Evade_LBG_Side_Dodge_Distance_2_displayName = "Evade: LBG Side Dodge: Distance 2";
        public const int Evade_LBG_Side_Dodge_Distance_2_sortIndex = 15450;
        [SortOrder(Evade_LBG_Side_Dodge_Distance_2_sortIndex)]
        [DisplayName(Evade_LBG_Side_Dodge_Distance_2_displayName)]
        public virtual float Evade_LBG_Side_Dodge_Distance_2 {
            get => GetData<float>(1537);
            set {
                if (GetData<float>(1537) == value) return;
                SetData(1537, value, nameof(Evade_LBG_Side_Dodge_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_LBG_Side_Dodge_Distance_2));
            }
        }

        public const string Evade_LBG_Side_Dodge_Distance_3_displayName = "Evade: LBG Side Dodge: Distance 3";
        public const int Evade_LBG_Side_Dodge_Distance_3_sortIndex = 15500;
        [SortOrder(Evade_LBG_Side_Dodge_Distance_3_sortIndex)]
        [DisplayName(Evade_LBG_Side_Dodge_Distance_3_displayName)]
        public virtual float Evade_LBG_Side_Dodge_Distance_3 {
            get => GetData<float>(1541);
            set {
                if (GetData<float>(1541) == value) return;
                SetData(1541, value, nameof(Evade_LBG_Side_Dodge_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_LBG_Side_Dodge_Distance_3));
            }
        }

        public const string Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1_displayName = "Evade: Dual Blades Demon Mode Slinger Evade: Distance 1";
        public const int Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1_sortIndex = 15550;
        [SortOrder(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1_sortIndex)]
        [DisplayName(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1_displayName)]
        public virtual float Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1 {
            get => GetData<float>(1545);
            set {
                if (GetData<float>(1545) == value) return;
                SetData(1545, value, nameof(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_1));
            }
        }

        public const string Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2_displayName = "Evade: Dual Blades Demon Mode Slinger Evade: Distance 2";
        public const int Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2_sortIndex = 15600;
        [SortOrder(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2_sortIndex)]
        [DisplayName(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2_displayName)]
        public virtual float Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2 {
            get => GetData<float>(1549);
            set {
                if (GetData<float>(1549) == value) return;
                SetData(1549, value, nameof(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_2));
            }
        }

        public const string Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3_displayName = "Evade: Dual Blades Demon Mode Slinger Evade: Distance 3";
        public const int Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3_sortIndex = 15650;
        [SortOrder(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3_sortIndex)]
        [DisplayName(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3_displayName)]
        public virtual float Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3 {
            get => GetData<float>(1553);
            set {
                if (GetData<float>(1553) == value) return;
                SetData(1553, value, nameof(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_Demon_Mode_Slinger_Evade_Distance_3));
            }
        }

        public const string Evade_Dual_Blades_Slinger_Evade_Distance_1_displayName = "Evade: Dual Blades Slinger Evade: Distance 1";
        public const int Evade_Dual_Blades_Slinger_Evade_Distance_1_sortIndex = 15700;
        [SortOrder(Evade_Dual_Blades_Slinger_Evade_Distance_1_sortIndex)]
        [DisplayName(Evade_Dual_Blades_Slinger_Evade_Distance_1_displayName)]
        public virtual float Evade_Dual_Blades_Slinger_Evade_Distance_1 {
            get => GetData<float>(1557);
            set {
                if (GetData<float>(1557) == value) return;
                SetData(1557, value, nameof(Evade_Dual_Blades_Slinger_Evade_Distance_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_Slinger_Evade_Distance_1));
            }
        }

        public const string Evade_Dual_Blades_Slinger_Evade_Distance_2_displayName = "Evade: Dual Blades Slinger Evade: Distance 2";
        public const int Evade_Dual_Blades_Slinger_Evade_Distance_2_sortIndex = 15750;
        [SortOrder(Evade_Dual_Blades_Slinger_Evade_Distance_2_sortIndex)]
        [DisplayName(Evade_Dual_Blades_Slinger_Evade_Distance_2_displayName)]
        public virtual float Evade_Dual_Blades_Slinger_Evade_Distance_2 {
            get => GetData<float>(1561);
            set {
                if (GetData<float>(1561) == value) return;
                SetData(1561, value, nameof(Evade_Dual_Blades_Slinger_Evade_Distance_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_Slinger_Evade_Distance_2));
            }
        }

        public const string Evade_Dual_Blades_Slinger_Evade_Distance_3_displayName = "Evade: Dual Blades Slinger Evade: Distance 3";
        public const int Evade_Dual_Blades_Slinger_Evade_Distance_3_sortIndex = 15800;
        [SortOrder(Evade_Dual_Blades_Slinger_Evade_Distance_3_sortIndex)]
        [DisplayName(Evade_Dual_Blades_Slinger_Evade_Distance_3_displayName)]
        public virtual float Evade_Dual_Blades_Slinger_Evade_Distance_3 {
            get => GetData<float>(1565);
            set {
                if (GetData<float>(1565) == value) return;
                SetData(1565, value, nameof(Evade_Dual_Blades_Slinger_Evade_Distance_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evade_Dual_Blades_Slinger_Evade_Distance_3));
            }
        }

        public const string __15850_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15850_sortIndex = 15850;
        [SortOrder(__15850_sortIndex)]
        [DisplayName(__15850_displayName)]
        [IsReadOnly]
        public virtual byte __15850 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__15850));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__15850));
            }
        }

        public const string _Skipping_ahead__15900_displayName = "------Skipping ahead.";
        public const int _Skipping_ahead__15900_sortIndex = 15900;
        [SortOrder(_Skipping_ahead__15900_sortIndex)]
        [DisplayName(_Skipping_ahead__15900_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_ahead__15900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(_Skipping_ahead__15900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead__15900));
            }
        }

        public const string __15950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15950_sortIndex = 15950;
        [SortOrder(__15950_sortIndex)]
        [DisplayName(__15950_displayName)]
        [IsReadOnly]
        public virtual byte __15950 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__15950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__15950));
            }
        }

        public const string Wp_HR_Augment_Attack_Bonus_1__displayName = "Wp HR Augment Attack Bonus (1)";
        public const int Wp_HR_Augment_Attack_Bonus_1__sortIndex = 16000;
        [SortOrder(Wp_HR_Augment_Attack_Bonus_1__sortIndex)]
        [DisplayName(Wp_HR_Augment_Attack_Bonus_1__displayName)]
        public virtual byte Wp_HR_Augment_Attack_Bonus_1_ {
            get => GetData<byte>(8583);
            set {
                if (GetData<byte>(8583) == value) return;
                SetData(8583, value, nameof(Wp_HR_Augment_Attack_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Attack_Bonus_1_));
            }
        }

        public const string Wp_HR_Augment_Attack_Bonus_2__displayName = "Wp HR Augment Attack Bonus (2)";
        public const int Wp_HR_Augment_Attack_Bonus_2__sortIndex = 16050;
        [SortOrder(Wp_HR_Augment_Attack_Bonus_2__sortIndex)]
        [DisplayName(Wp_HR_Augment_Attack_Bonus_2__displayName)]
        public virtual byte Wp_HR_Augment_Attack_Bonus_2_ {
            get => GetData<byte>(8584);
            set {
                if (GetData<byte>(8584) == value) return;
                SetData(8584, value, nameof(Wp_HR_Augment_Attack_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Attack_Bonus_2_));
            }
        }

        public const string Wp_HR_Augment_Attack_Bonus_3__displayName = "Wp HR Augment Attack Bonus (3)";
        public const int Wp_HR_Augment_Attack_Bonus_3__sortIndex = 16100;
        [SortOrder(Wp_HR_Augment_Attack_Bonus_3__sortIndex)]
        [DisplayName(Wp_HR_Augment_Attack_Bonus_3__displayName)]
        public virtual byte Wp_HR_Augment_Attack_Bonus_3_ {
            get => GetData<byte>(8585);
            set {
                if (GetData<byte>(8585) == value) return;
                SetData(8585, value, nameof(Wp_HR_Augment_Attack_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Attack_Bonus_3_));
            }
        }

        public const string Wp_HR_Augment_Critical_Bonus_1__displayName = "Wp HR Augment Critical Bonus (1)";
        public const int Wp_HR_Augment_Critical_Bonus_1__sortIndex = 16150;
        [SortOrder(Wp_HR_Augment_Critical_Bonus_1__sortIndex)]
        [DisplayName(Wp_HR_Augment_Critical_Bonus_1__displayName)]
        public virtual byte Wp_HR_Augment_Critical_Bonus_1_ {
            get => GetData<byte>(8586);
            set {
                if (GetData<byte>(8586) == value) return;
                SetData(8586, value, nameof(Wp_HR_Augment_Critical_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Critical_Bonus_1_));
            }
        }

        public const string Wp_HR_Augment_Critical_Bonus_2__displayName = "Wp HR Augment Critical Bonus (2)";
        public const int Wp_HR_Augment_Critical_Bonus_2__sortIndex = 16200;
        [SortOrder(Wp_HR_Augment_Critical_Bonus_2__sortIndex)]
        [DisplayName(Wp_HR_Augment_Critical_Bonus_2__displayName)]
        public virtual byte Wp_HR_Augment_Critical_Bonus_2_ {
            get => GetData<byte>(8587);
            set {
                if (GetData<byte>(8587) == value) return;
                SetData(8587, value, nameof(Wp_HR_Augment_Critical_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Critical_Bonus_2_));
            }
        }

        public const string Wp_HR_Augment_Critical_Bonus_3__displayName = "Wp HR Augment Critical Bonus (3)";
        public const int Wp_HR_Augment_Critical_Bonus_3__sortIndex = 16250;
        [SortOrder(Wp_HR_Augment_Critical_Bonus_3__sortIndex)]
        [DisplayName(Wp_HR_Augment_Critical_Bonus_3__displayName)]
        public virtual byte Wp_HR_Augment_Critical_Bonus_3_ {
            get => GetData<byte>(8588);
            set {
                if (GetData<byte>(8588) == value) return;
                SetData(8588, value, nameof(Wp_HR_Augment_Critical_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Critical_Bonus_3_));
            }
        }

        public const string Wp_HR_Augment_Defense_Bonus_1__displayName = "Wp HR Augment Defense Bonus (1)";
        public const int Wp_HR_Augment_Defense_Bonus_1__sortIndex = 16300;
        [SortOrder(Wp_HR_Augment_Defense_Bonus_1__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Bonus_1__displayName)]
        public virtual byte Wp_HR_Augment_Defense_Bonus_1_ {
            get => GetData<byte>(8589);
            set {
                if (GetData<byte>(8589) == value) return;
                SetData(8589, value, nameof(Wp_HR_Augment_Defense_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Bonus_1_));
            }
        }

        public const string Wp_HR_Augment_Defense_Bonus_2__displayName = "Wp HR Augment Defense Bonus (2)";
        public const int Wp_HR_Augment_Defense_Bonus_2__sortIndex = 16350;
        [SortOrder(Wp_HR_Augment_Defense_Bonus_2__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Bonus_2__displayName)]
        public virtual byte Wp_HR_Augment_Defense_Bonus_2_ {
            get => GetData<byte>(8590);
            set {
                if (GetData<byte>(8590) == value) return;
                SetData(8590, value, nameof(Wp_HR_Augment_Defense_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Bonus_2_));
            }
        }

        public const string Wp_HR_Augment_Defense_Bonus_3__displayName = "Wp HR Augment Defense Bonus (3)";
        public const int Wp_HR_Augment_Defense_Bonus_3__sortIndex = 16400;
        [SortOrder(Wp_HR_Augment_Defense_Bonus_3__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Bonus_3__displayName)]
        public virtual byte Wp_HR_Augment_Defense_Bonus_3_ {
            get => GetData<byte>(8591);
            set {
                if (GetData<byte>(8591) == value) return;
                SetData(8591, value, nameof(Wp_HR_Augment_Defense_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Bonus_3_));
            }
        }

        public const string Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__displayName = "Wp HR Augment Defense: Divine Blessing Chance (1)";
        public const int Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex = 16450;
        [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__displayName)]
        public virtual byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_1_ {
            get => GetData<byte>(8592);
            set {
                if (GetData<byte>(8592) == value) return;
                SetData(8592, value, nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1_));
            }
        }

        public const string Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__displayName = "Wp HR Augment Defense: Divine Blessing Chance (2)";
        public const int Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex = 16500;
        [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__displayName)]
        public virtual byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_2_ {
            get => GetData<byte>(8593);
            set {
                if (GetData<byte>(8593) == value) return;
                SetData(8593, value, nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2_));
            }
        }

        public const string Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__displayName = "Wp HR Augment Defense: Divine Blessing Chance (3)";
        public const int Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex = 16550;
        [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__displayName)]
        public virtual byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_3_ {
            get => GetData<byte>(8594);
            set {
                if (GetData<byte>(8594) == value) return;
                SetData(8594, value, nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3_));
            }
        }

        public const string Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__displayName = "Wp HR Augment Defense: Divine Blessing Reduction (1)";
        public const int Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex = 16600;
        [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__displayName)]
        public virtual float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1_ {
            get => GetData<float>(8595);
            set {
                if (GetData<float>(8595) == value) return;
                SetData(8595, value, nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1_));
            }
        }

        public const string Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__displayName = "Wp HR Augment Defense: Divine Blessing Reduction (2)";
        public const int Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex = 16650;
        [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__displayName)]
        public virtual float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2_ {
            get => GetData<float>(8599);
            set {
                if (GetData<float>(8599) == value) return;
                SetData(8599, value, nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2_));
            }
        }

        public const string Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__displayName = "Wp HR Augment Defense: Divine Blessing Reduction (3)";
        public const int Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex = 16700;
        [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__displayName)]
        public virtual float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3_ {
            get => GetData<float>(8603);
            set {
                if (GetData<float>(8603) == value) return;
                SetData(8603, value, nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3_));
            }
        }

        public const string Wp_HR_Augment_Defense_Heal_Damage_Rate_1__displayName = "Wp HR Augment Defense Heal Damage Rate (1)";
        public const int Wp_HR_Augment_Defense_Heal_Damage_Rate_1__sortIndex = 16750;
        [SortOrder(Wp_HR_Augment_Defense_Heal_Damage_Rate_1__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Heal_Damage_Rate_1__displayName)]
        public virtual float Wp_HR_Augment_Defense_Heal_Damage_Rate_1_ {
            get => GetData<float>(8607);
            set {
                if (GetData<float>(8607) == value) return;
                SetData(8607, value, nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_1_));
            }
        }

        public const string Wp_HR_Augment_Defense_Heal_Damage_Rate_2__displayName = "Wp HR Augment Defense Heal Damage Rate (2)";
        public const int Wp_HR_Augment_Defense_Heal_Damage_Rate_2__sortIndex = 16800;
        [SortOrder(Wp_HR_Augment_Defense_Heal_Damage_Rate_2__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Heal_Damage_Rate_2__displayName)]
        public virtual float Wp_HR_Augment_Defense_Heal_Damage_Rate_2_ {
            get => GetData<float>(8611);
            set {
                if (GetData<float>(8611) == value) return;
                SetData(8611, value, nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_2_));
            }
        }

        public const string Wp_HR_Augment_Defense_Heal_Damage_Rate_3__displayName = "Wp HR Augment Defense Heal Damage Rate (3)";
        public const int Wp_HR_Augment_Defense_Heal_Damage_Rate_3__sortIndex = 16850;
        [SortOrder(Wp_HR_Augment_Defense_Heal_Damage_Rate_3__sortIndex)]
        [DisplayName(Wp_HR_Augment_Defense_Heal_Damage_Rate_3__displayName)]
        public virtual float Wp_HR_Augment_Defense_Heal_Damage_Rate_3_ {
            get => GetData<float>(8615);
            set {
                if (GetData<float>(8615) == value) return;
                SetData(8615, value, nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_3_));
            }
        }

        public const string Wp_HR_Augment_IB_Unk_displayName = "Wp HR Augment IB Unk";
        public const int Wp_HR_Augment_IB_Unk_sortIndex = 16900;
        [SortOrder(Wp_HR_Augment_IB_Unk_sortIndex)]
        [DisplayName(Wp_HR_Augment_IB_Unk_displayName)]
        public virtual float Wp_HR_Augment_IB_Unk {
            get => GetData<float>(8619);
            set {
                if (GetData<float>(8619) == value) return;
                SetData(8619, value, nameof(Wp_HR_Augment_IB_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_IB_Unk));
            }
        }

        public const string Wp_HR_Augment_Lifesteal_Cooldown_displayName = "Wp HR Augment Lifesteal Cooldown";
        public const int Wp_HR_Augment_Lifesteal_Cooldown_sortIndex = 16950;
        [SortOrder(Wp_HR_Augment_Lifesteal_Cooldown_sortIndex)]
        [DisplayName(Wp_HR_Augment_Lifesteal_Cooldown_displayName)]
        public virtual float Wp_HR_Augment_Lifesteal_Cooldown {
            get => GetData<float>(8623);
            set {
                if (GetData<float>(8623) == value) return;
                SetData(8623, value, nameof(Wp_HR_Augment_Lifesteal_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_HR_Augment_Lifesteal_Cooldown));
            }
        }

        public const string __17000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __17000_sortIndex = 17000;
        [SortOrder(__17000_sortIndex)]
        [DisplayName(__17000_displayName)]
        [IsReadOnly]
        public virtual byte __17000 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__17000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__17000));
            }
        }

        public const string Wp_MR_Augment_Attack_Bonus_1__displayName = "Wp MR Augment Attack Bonus (1)";
        public const int Wp_MR_Augment_Attack_Bonus_1__sortIndex = 17050;
        [SortOrder(Wp_MR_Augment_Attack_Bonus_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Attack_Bonus_1__displayName)]
        public virtual byte Wp_MR_Augment_Attack_Bonus_1_ {
            get => GetData<byte>(8627);
            set {
                if (GetData<byte>(8627) == value) return;
                SetData(8627, value, nameof(Wp_MR_Augment_Attack_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_1_));
            }
        }

        public const string Wp_MR_Augment_Attack_Bonus_2__displayName = "Wp MR Augment Attack Bonus (2)";
        public const int Wp_MR_Augment_Attack_Bonus_2__sortIndex = 17100;
        [SortOrder(Wp_MR_Augment_Attack_Bonus_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Attack_Bonus_2__displayName)]
        public virtual byte Wp_MR_Augment_Attack_Bonus_2_ {
            get => GetData<byte>(8628);
            set {
                if (GetData<byte>(8628) == value) return;
                SetData(8628, value, nameof(Wp_MR_Augment_Attack_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_2_));
            }
        }

        public const string Wp_MR_Augment_Attack_Bonus_3__displayName = "Wp MR Augment Attack Bonus (3)";
        public const int Wp_MR_Augment_Attack_Bonus_3__sortIndex = 17150;
        [SortOrder(Wp_MR_Augment_Attack_Bonus_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Attack_Bonus_3__displayName)]
        public virtual byte Wp_MR_Augment_Attack_Bonus_3_ {
            get => GetData<byte>(8629);
            set {
                if (GetData<byte>(8629) == value) return;
                SetData(8629, value, nameof(Wp_MR_Augment_Attack_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_3_));
            }
        }

        public const string Wp_MR_Augment_Attack_Bonus_4__displayName = "Wp MR Augment Attack Bonus (4)";
        public const int Wp_MR_Augment_Attack_Bonus_4__sortIndex = 17200;
        [SortOrder(Wp_MR_Augment_Attack_Bonus_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Attack_Bonus_4__displayName)]
        public virtual byte Wp_MR_Augment_Attack_Bonus_4_ {
            get => GetData<byte>(8630);
            set {
                if (GetData<byte>(8630) == value) return;
                SetData(8630, value, nameof(Wp_MR_Augment_Attack_Bonus_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_4_));
            }
        }

        public const string Wp_MR_Augment_Critical_Bonus_1__displayName = "Wp MR Augment Critical Bonus (1)";
        public const int Wp_MR_Augment_Critical_Bonus_1__sortIndex = 17250;
        [SortOrder(Wp_MR_Augment_Critical_Bonus_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Critical_Bonus_1__displayName)]
        public virtual byte Wp_MR_Augment_Critical_Bonus_1_ {
            get => GetData<byte>(8631);
            set {
                if (GetData<byte>(8631) == value) return;
                SetData(8631, value, nameof(Wp_MR_Augment_Critical_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_1_));
            }
        }

        public const string Wp_MR_Augment_Critical_Bonus_2__displayName = "Wp MR Augment Critical Bonus (2)";
        public const int Wp_MR_Augment_Critical_Bonus_2__sortIndex = 17300;
        [SortOrder(Wp_MR_Augment_Critical_Bonus_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Critical_Bonus_2__displayName)]
        public virtual byte Wp_MR_Augment_Critical_Bonus_2_ {
            get => GetData<byte>(8632);
            set {
                if (GetData<byte>(8632) == value) return;
                SetData(8632, value, nameof(Wp_MR_Augment_Critical_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_2_));
            }
        }

        public const string Wp_MR_Augment_Critical_Bonus_3__displayName = "Wp MR Augment Critical Bonus (3)";
        public const int Wp_MR_Augment_Critical_Bonus_3__sortIndex = 17350;
        [SortOrder(Wp_MR_Augment_Critical_Bonus_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Critical_Bonus_3__displayName)]
        public virtual byte Wp_MR_Augment_Critical_Bonus_3_ {
            get => GetData<byte>(8633);
            set {
                if (GetData<byte>(8633) == value) return;
                SetData(8633, value, nameof(Wp_MR_Augment_Critical_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_3_));
            }
        }

        public const string Wp_MR_Augment_Critical_Bonus_4__displayName = "Wp MR Augment Critical Bonus (4)";
        public const int Wp_MR_Augment_Critical_Bonus_4__sortIndex = 17400;
        [SortOrder(Wp_MR_Augment_Critical_Bonus_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Critical_Bonus_4__displayName)]
        public virtual byte Wp_MR_Augment_Critical_Bonus_4_ {
            get => GetData<byte>(8634);
            set {
                if (GetData<byte>(8634) == value) return;
                SetData(8634, value, nameof(Wp_MR_Augment_Critical_Bonus_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_4_));
            }
        }

        public const string Wp_MR_Augment_Defense_Bonus_1__displayName = "Wp MR Augment Defense Bonus (1)";
        public const int Wp_MR_Augment_Defense_Bonus_1__sortIndex = 17450;
        [SortOrder(Wp_MR_Augment_Defense_Bonus_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Bonus_1__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Bonus_1_ {
            get => GetData<byte>(8635);
            set {
                if (GetData<byte>(8635) == value) return;
                SetData(8635, value, nameof(Wp_MR_Augment_Defense_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_1_));
            }
        }

        public const string Wp_MR_Augment_Defense_Bonus_2__displayName = "Wp MR Augment Defense Bonus (2)";
        public const int Wp_MR_Augment_Defense_Bonus_2__sortIndex = 17500;
        [SortOrder(Wp_MR_Augment_Defense_Bonus_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Bonus_2__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Bonus_2_ {
            get => GetData<byte>(8636);
            set {
                if (GetData<byte>(8636) == value) return;
                SetData(8636, value, nameof(Wp_MR_Augment_Defense_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_2_));
            }
        }

        public const string Wp_MR_Augment_Defense_Bonus_3__displayName = "Wp MR Augment Defense Bonus (3)";
        public const int Wp_MR_Augment_Defense_Bonus_3__sortIndex = 17550;
        [SortOrder(Wp_MR_Augment_Defense_Bonus_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Bonus_3__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Bonus_3_ {
            get => GetData<byte>(8637);
            set {
                if (GetData<byte>(8637) == value) return;
                SetData(8637, value, nameof(Wp_MR_Augment_Defense_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_3_));
            }
        }

        public const string Wp_MR_Augment_Defense_Bonus_4__displayName = "Wp MR Augment Defense Bonus (4)";
        public const int Wp_MR_Augment_Defense_Bonus_4__sortIndex = 17600;
        [SortOrder(Wp_MR_Augment_Defense_Bonus_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Bonus_4__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Bonus_4_ {
            get => GetData<byte>(8638);
            set {
                if (GetData<byte>(8638) == value) return;
                SetData(8638, value, nameof(Wp_MR_Augment_Defense_Bonus_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_4_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__displayName = "Wp MR Augment Defense: Divine Blessing Chance (1)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex = 17650;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_1_ {
            get => GetData<byte>(8639);
            set {
                if (GetData<byte>(8639) == value) return;
                SetData(8639, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__displayName = "Wp MR Augment Defense: Divine Blessing Chance (2)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex = 17700;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_2_ {
            get => GetData<byte>(8640);
            set {
                if (GetData<byte>(8640) == value) return;
                SetData(8640, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__displayName = "Wp MR Augment Defense: Divine Blessing Chance (3)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex = 17750;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_3_ {
            get => GetData<byte>(8641);
            set {
                if (GetData<byte>(8641) == value) return;
                SetData(8641, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__displayName = "Wp MR Augment Defense: Divine Blessing Chance (4)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__sortIndex = 17800;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__displayName)]
        public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_4_ {
            get => GetData<byte>(8642);
            set {
                if (GetData<byte>(8642) == value) return;
                SetData(8642, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (1)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex = 17850;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__displayName)]
        public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1_ {
            get => GetData<float>(8643);
            set {
                if (GetData<float>(8643) == value) return;
                SetData(8643, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (2)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex = 17900;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__displayName)]
        public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2_ {
            get => GetData<float>(8647);
            set {
                if (GetData<float>(8647) == value) return;
                SetData(8647, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (3)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex = 17950;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__displayName)]
        public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3_ {
            get => GetData<float>(8651);
            set {
                if (GetData<float>(8651) == value) return;
                SetData(8651, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3_));
            }
        }

        public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (4)";
        public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__sortIndex = 18000;
        [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__displayName)]
        public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4_ {
            get => GetData<float>(8655);
            set {
                if (GetData<float>(8655) == value) return;
                SetData(8655, value, nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4_));
            }
        }

        public const string Wp_MR_Augment_Health_Percent_1__displayName = "Wp MR Augment Health Percent (1)";
        public const int Wp_MR_Augment_Health_Percent_1__sortIndex = 18050;
        [SortOrder(Wp_MR_Augment_Health_Percent_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Health_Percent_1__displayName)]
        public virtual float Wp_MR_Augment_Health_Percent_1_ {
            get => GetData<float>(8659);
            set {
                if (GetData<float>(8659) == value) return;
                SetData(8659, value, nameof(Wp_MR_Augment_Health_Percent_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_1_));
            }
        }

        public const string Wp_MR_Augment_Health_Percent_2__displayName = "Wp MR Augment Health Percent (2)";
        public const int Wp_MR_Augment_Health_Percent_2__sortIndex = 18100;
        [SortOrder(Wp_MR_Augment_Health_Percent_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Health_Percent_2__displayName)]
        public virtual float Wp_MR_Augment_Health_Percent_2_ {
            get => GetData<float>(8663);
            set {
                if (GetData<float>(8663) == value) return;
                SetData(8663, value, nameof(Wp_MR_Augment_Health_Percent_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_2_));
            }
        }

        public const string Wp_MR_Augment_Health_Percent_3__displayName = "Wp MR Augment Health Percent (3)";
        public const int Wp_MR_Augment_Health_Percent_3__sortIndex = 18150;
        [SortOrder(Wp_MR_Augment_Health_Percent_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Health_Percent_3__displayName)]
        public virtual float Wp_MR_Augment_Health_Percent_3_ {
            get => GetData<float>(8667);
            set {
                if (GetData<float>(8667) == value) return;
                SetData(8667, value, nameof(Wp_MR_Augment_Health_Percent_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_3_));
            }
        }

        public const string Wp_MR_Augment_Health_Percent_4__displayName = "Wp MR Augment Health Percent (4)";
        public const int Wp_MR_Augment_Health_Percent_4__sortIndex = 18200;
        [SortOrder(Wp_MR_Augment_Health_Percent_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Health_Percent_4__displayName)]
        public virtual float Wp_MR_Augment_Health_Percent_4_ {
            get => GetData<float>(8671);
            set {
                if (GetData<float>(8671) == value) return;
                SetData(8671, value, nameof(Wp_MR_Augment_Health_Percent_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_4_));
            }
        }

        public const string IB_Unk1_displayName = "IB Unk1";
        public const int IB_Unk1_sortIndex = 18250;
        [SortOrder(IB_Unk1_sortIndex)]
        [DisplayName(IB_Unk1_displayName)]
        public virtual float IB_Unk1 {
            get => GetData<float>(8675);
            set {
                if (GetData<float>(8675) == value) return;
                SetData(8675, value, nameof(IB_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(IB_Unk1));
            }
        }

        public const string Wp_MR_Augment_Lifesteal_Cooldown_displayName = "Wp MR Augment Lifesteal Cooldown";
        public const int Wp_MR_Augment_Lifesteal_Cooldown_sortIndex = 18300;
        [SortOrder(Wp_MR_Augment_Lifesteal_Cooldown_sortIndex)]
        [DisplayName(Wp_MR_Augment_Lifesteal_Cooldown_displayName)]
        public virtual float Wp_MR_Augment_Lifesteal_Cooldown {
            get => GetData<float>(8679);
            set {
                if (GetData<float>(8679) == value) return;
                SetData(8679, value, nameof(Wp_MR_Augment_Lifesteal_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Lifesteal_Cooldown));
            }
        }

        public const string Wp_MR_Augment_Element_1__displayName = "Wp MR Augment Element (1)";
        public const int Wp_MR_Augment_Element_1__sortIndex = 18350;
        [SortOrder(Wp_MR_Augment_Element_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Element_1__displayName)]
        public virtual byte Wp_MR_Augment_Element_1_ {
            get => GetData<byte>(8683);
            set {
                if (GetData<byte>(8683) == value) return;
                SetData(8683, value, nameof(Wp_MR_Augment_Element_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Element_1_));
            }
        }

        public const string Wp_MR_Augment_Element_2__displayName = "Wp MR Augment Element (2)";
        public const int Wp_MR_Augment_Element_2__sortIndex = 18400;
        [SortOrder(Wp_MR_Augment_Element_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Element_2__displayName)]
        public virtual byte Wp_MR_Augment_Element_2_ {
            get => GetData<byte>(8684);
            set {
                if (GetData<byte>(8684) == value) return;
                SetData(8684, value, nameof(Wp_MR_Augment_Element_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Element_2_));
            }
        }

        public const string Wp_MR_Augment_Element_3__displayName = "Wp MR Augment Element (3)";
        public const int Wp_MR_Augment_Element_3__sortIndex = 18450;
        [SortOrder(Wp_MR_Augment_Element_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Element_3__displayName)]
        public virtual byte Wp_MR_Augment_Element_3_ {
            get => GetData<byte>(8685);
            set {
                if (GetData<byte>(8685) == value) return;
                SetData(8685, value, nameof(Wp_MR_Augment_Element_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Element_3_));
            }
        }

        public const string Wp_MR_Augment_Element_4__displayName = "Wp MR Augment Element (4)";
        public const int Wp_MR_Augment_Element_4__sortIndex = 18500;
        [SortOrder(Wp_MR_Augment_Element_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Element_4__displayName)]
        public virtual byte Wp_MR_Augment_Element_4_ {
            get => GetData<byte>(8686);
            set {
                if (GetData<byte>(8686) == value) return;
                SetData(8686, value, nameof(Wp_MR_Augment_Element_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Element_4_));
            }
        }

        public const string __18550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __18550_sortIndex = 18550;
        [SortOrder(__18550_sortIndex)]
        [DisplayName(__18550_displayName)]
        [IsReadOnly]
        public virtual byte __18550 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__18550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__18550));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (1)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__sortIndex = 18600;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1_ {
            get => GetData<byte>(8687);
            set {
                if (GetData<byte>(8687) == value) return;
                SetData(8687, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (2)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__sortIndex = 18650;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2_ {
            get => GetData<byte>(8688);
            set {
                if (GetData<byte>(8688) == value) return;
                SetData(8688, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (3)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__sortIndex = 18700;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3_ {
            get => GetData<byte>(8689);
            set {
                if (GetData<byte>(8689) == value) return;
                SetData(8689, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (4)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__sortIndex = 18750;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4_ {
            get => GetData<byte>(8690);
            set {
                if (GetData<byte>(8690) == value) return;
                SetData(8690, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (1)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__sortIndex = 18800;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1_ {
            get => GetData<byte>(8691);
            set {
                if (GetData<byte>(8691) == value) return;
                SetData(8691, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (2)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__sortIndex = 18850;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2_ {
            get => GetData<byte>(8692);
            set {
                if (GetData<byte>(8692) == value) return;
                SetData(8692, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (3)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__sortIndex = 18900;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3_ {
            get => GetData<byte>(8693);
            set {
                if (GetData<byte>(8693) == value) return;
                SetData(8693, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3_));
            }
        }

        public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (4)";
        public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__sortIndex = 18950;
        [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__displayName)]
        public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4_ {
            get => GetData<byte>(8694);
            set {
                if (GetData<byte>(8694) == value) return;
                SetData(8694, value, nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4_));
            }
        }

        public const string __19000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __19000_sortIndex = 19000;
        [SortOrder(__19000_sortIndex)]
        [DisplayName(__19000_displayName)]
        [IsReadOnly]
        public virtual byte __19000 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__19000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__19000));
            }
        }

        public const string Wp_MR_Augment_Great_Sword_Elemental_Multiplier_displayName = "Wp MR Augment Great Sword Elemental Multiplier";
        public const int Wp_MR_Augment_Great_Sword_Elemental_Multiplier_sortIndex = 19050;
        [SortOrder(Wp_MR_Augment_Great_Sword_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Great_Sword_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Great_Sword_Elemental_Multiplier {
            get => GetData<float>(8695);
            set {
                if (GetData<float>(8695) == value) return;
                SetData(8695, value, nameof(Wp_MR_Augment_Great_Sword_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Great_Sword_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_displayName = "Wp MR Augment Sword & Shield Elemental Multiplier";
        public const int Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_sortIndex = 19100;
        [SortOrder(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Sword_Shield_Elemental_Multiplier {
            get => GetData<float>(8699);
            set {
                if (GetData<float>(8699) == value) return;
                SetData(8699, value, nameof(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_displayName = "Wp MR Augment Dual Blades Elemental Multiplier";
        public const int Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_sortIndex = 19150;
        [SortOrder(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Dual_Blades_Elemental_Multiplier {
            get => GetData<float>(8703);
            set {
                if (GetData<float>(8703) == value) return;
                SetData(8703, value, nameof(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Long_Sword_Elemental_Multiplier_displayName = "Wp MR Augment Long Sword Elemental Multiplier";
        public const int Wp_MR_Augment_Long_Sword_Elemental_Multiplier_sortIndex = 19200;
        [SortOrder(Wp_MR_Augment_Long_Sword_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Long_Sword_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Long_Sword_Elemental_Multiplier {
            get => GetData<float>(8707);
            set {
                if (GetData<float>(8707) == value) return;
                SetData(8707, value, nameof(Wp_MR_Augment_Long_Sword_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Long_Sword_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Hammer_Elemental_Multiplier_displayName = "Wp MR Augment Hammer Elemental Multiplier";
        public const int Wp_MR_Augment_Hammer_Elemental_Multiplier_sortIndex = 19250;
        [SortOrder(Wp_MR_Augment_Hammer_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Hammer_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Hammer_Elemental_Multiplier {
            get => GetData<float>(8711);
            set {
                if (GetData<float>(8711) == value) return;
                SetData(8711, value, nameof(Wp_MR_Augment_Hammer_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Hammer_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_displayName = "Wp MR Augment Hunting Horn Elemental Multiplier";
        public const int Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_sortIndex = 19300;
        [SortOrder(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier {
            get => GetData<float>(8715);
            set {
                if (GetData<float>(8715) == value) return;
                SetData(8715, value, nameof(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Lance_Elemental_Multiplier_displayName = "Wp MR Augment Lance Elemental Multiplier";
        public const int Wp_MR_Augment_Lance_Elemental_Multiplier_sortIndex = 19350;
        [SortOrder(Wp_MR_Augment_Lance_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Lance_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Lance_Elemental_Multiplier {
            get => GetData<float>(8719);
            set {
                if (GetData<float>(8719) == value) return;
                SetData(8719, value, nameof(Wp_MR_Augment_Lance_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Lance_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Gunlance_Elemental_Multiplier_displayName = "Wp MR Augment Gunlance Elemental Multiplier";
        public const int Wp_MR_Augment_Gunlance_Elemental_Multiplier_sortIndex = 19400;
        [SortOrder(Wp_MR_Augment_Gunlance_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Gunlance_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Gunlance_Elemental_Multiplier {
            get => GetData<float>(8723);
            set {
                if (GetData<float>(8723) == value) return;
                SetData(8723, value, nameof(Wp_MR_Augment_Gunlance_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Gunlance_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_displayName = "Wp MR Augment Switch Axe Elemental Multiplier";
        public const int Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_sortIndex = 19450;
        [SortOrder(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Switch_Axe_Elemental_Multiplier {
            get => GetData<float>(8727);
            set {
                if (GetData<float>(8727) == value) return;
                SetData(8727, value, nameof(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_displayName = "Wp MR Augment Charge Blade Elemental Multiplier";
        public const int Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_sortIndex = 19500;
        [SortOrder(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Charge_Blade_Elemental_Multiplier {
            get => GetData<float>(8731);
            set {
                if (GetData<float>(8731) == value) return;
                SetData(8731, value, nameof(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_displayName = "Wp MR Augment Insect Glaive Elemental Multiplier";
        public const int Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_sortIndex = 19550;
        [SortOrder(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier {
            get => GetData<float>(8735);
            set {
                if (GetData<float>(8735) == value) return;
                SetData(8735, value, nameof(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_Bow_Elemental_Multiplier_displayName = "Wp MR Augment Bow Elemental Multiplier";
        public const int Wp_MR_Augment_Bow_Elemental_Multiplier_sortIndex = 19600;
        [SortOrder(Wp_MR_Augment_Bow_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_Bow_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_Bow_Elemental_Multiplier {
            get => GetData<float>(8739);
            set {
                if (GetData<float>(8739) == value) return;
                SetData(8739, value, nameof(Wp_MR_Augment_Bow_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_HBG_Elemental_Multiplier_displayName = "Wp MR Augment HBG Elemental Multiplier";
        public const int Wp_MR_Augment_HBG_Elemental_Multiplier_sortIndex = 19650;
        [SortOrder(Wp_MR_Augment_HBG_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_HBG_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_HBG_Elemental_Multiplier {
            get => GetData<float>(8743);
            set {
                if (GetData<float>(8743) == value) return;
                SetData(8743, value, nameof(Wp_MR_Augment_HBG_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_HBG_Elemental_Multiplier));
            }
        }

        public const string Wp_MR_Augment_LBG_Elemental_Multiplier_displayName = "Wp MR Augment LBG Elemental Multiplier";
        public const int Wp_MR_Augment_LBG_Elemental_Multiplier_sortIndex = 19700;
        [SortOrder(Wp_MR_Augment_LBG_Elemental_Multiplier_sortIndex)]
        [DisplayName(Wp_MR_Augment_LBG_Elemental_Multiplier_displayName)]
        public virtual float Wp_MR_Augment_LBG_Elemental_Multiplier {
            get => GetData<float>(8747);
            set {
                if (GetData<float>(8747) == value) return;
                SetData(8747, value, nameof(Wp_MR_Augment_LBG_Elemental_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_LBG_Elemental_Multiplier));
            }
        }

        public const string __19750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __19750_sortIndex = 19750;
        [SortOrder(__19750_sortIndex)]
        [DisplayName(__19750_displayName)]
        [IsReadOnly]
        public virtual byte __19750 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__19750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__19750));
            }
        }

        public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__displayName = "Wp MR Augment Bow Coating Status Multiplier (1)";
        public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__sortIndex = 19800;
        [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__displayName)]
        public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_1_ {
            get => GetData<float>(8751);
            set {
                if (GetData<float>(8751) == value) return;
                SetData(8751, value, nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1_));
            }
        }

        public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__displayName = "Wp MR Augment Bow Coating Status Multiplier (2)";
        public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__sortIndex = 19850;
        [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__displayName)]
        public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_2_ {
            get => GetData<float>(8755);
            set {
                if (GetData<float>(8755) == value) return;
                SetData(8755, value, nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2_));
            }
        }

        public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__displayName = "Wp MR Augment Bow Coating Status Multiplier (3)";
        public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__sortIndex = 19900;
        [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__displayName)]
        public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_3_ {
            get => GetData<float>(8759);
            set {
                if (GetData<float>(8759) == value) return;
                SetData(8759, value, nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3_));
            }
        }

        public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__displayName = "Wp MR Augment Bow Coating Status Multiplier (4)";
        public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__sortIndex = 19950;
        [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__sortIndex)]
        [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__displayName)]
        public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_4_ {
            get => GetData<float>(8763);
            set {
                if (GetData<float>(8763) == value) return;
                SetData(8763, value, nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4_));
            }
        }

        public const string __20000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __20000_sortIndex = 20000;
        [SortOrder(__20000_sortIndex)]
        [DisplayName(__20000_displayName)]
        [IsReadOnly]
        public virtual byte __20000 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__20000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__20000));
            }
        }

        public const string _Skipping_ahead__20050_displayName = "------Skipping ahead.";
        public const int _Skipping_ahead__20050_sortIndex = 20050;
        [SortOrder(_Skipping_ahead__20050_sortIndex)]
        [DisplayName(_Skipping_ahead__20050_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_ahead__20050 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(_Skipping_ahead__20050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead__20050));
            }
        }

        public const string __20100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __20100_sortIndex = 20100;
        [SortOrder(__20100_sortIndex)]
        [DisplayName(__20100_displayName)]
        [IsReadOnly]
        public virtual byte __20100 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__20100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__20100));
            }
        }

        public const string Max_Slinger_Capacity_Stone_displayName = "Max Slinger Capacity: Stone";
        public const int Max_Slinger_Capacity_Stone_sortIndex = 20150;
        [SortOrder(Max_Slinger_Capacity_Stone_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Stone_displayName)]
        public virtual byte Max_Slinger_Capacity_Stone {
            get => GetData<byte>(9357);
            set {
                if (GetData<byte>(9357) == value) return;
                SetData(9357, value, nameof(Max_Slinger_Capacity_Stone));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Stone));
            }
        }

        public const string Max_Slinger_Capacity_Redpit_displayName = "Max Slinger Capacity: Redpit";
        public const int Max_Slinger_Capacity_Redpit_sortIndex = 20200;
        [SortOrder(Max_Slinger_Capacity_Redpit_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Redpit_displayName)]
        public virtual byte Max_Slinger_Capacity_Redpit {
            get => GetData<byte>(9358);
            set {
                if (GetData<byte>(9358) == value) return;
                SetData(9358, value, nameof(Max_Slinger_Capacity_Redpit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Redpit));
            }
        }

        public const string Max_Slinger_Capacity_Brightmoss_displayName = "Max Slinger Capacity: Brightmoss";
        public const int Max_Slinger_Capacity_Brightmoss_sortIndex = 20250;
        [SortOrder(Max_Slinger_Capacity_Brightmoss_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Brightmoss_displayName)]
        public virtual byte Max_Slinger_Capacity_Brightmoss {
            get => GetData<byte>(9359);
            set {
                if (GetData<byte>(9359) == value) return;
                SetData(9359, value, nameof(Max_Slinger_Capacity_Brightmoss));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Brightmoss));
            }
        }

        public const string Max_Slinger_Capacity_Scatternut_displayName = "Max Slinger Capacity: Scatternut";
        public const int Max_Slinger_Capacity_Scatternut_sortIndex = 20300;
        [SortOrder(Max_Slinger_Capacity_Scatternut_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Scatternut_displayName)]
        public virtual byte Max_Slinger_Capacity_Scatternut {
            get => GetData<byte>(9360);
            set {
                if (GetData<byte>(9360) == value) return;
                SetData(9360, value, nameof(Max_Slinger_Capacity_Scatternut));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Scatternut));
            }
        }

        public const string Max_Slinger_Capacity_Unk_1_displayName = "Max Slinger Capacity: Unk 1";
        public const int Max_Slinger_Capacity_Unk_1_sortIndex = 20350;
        [SortOrder(Max_Slinger_Capacity_Unk_1_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_1_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_1 {
            get => GetData<byte>(9361);
            set {
                if (GetData<byte>(9361) == value) return;
                SetData(9361, value, nameof(Max_Slinger_Capacity_Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_1));
            }
        }

        public const string Max_Slinger_Capacity_Unk_2_displayName = "Max Slinger Capacity: Unk 2";
        public const int Max_Slinger_Capacity_Unk_2_sortIndex = 20400;
        [SortOrder(Max_Slinger_Capacity_Unk_2_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_2_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_2 {
            get => GetData<byte>(9362);
            set {
                if (GetData<byte>(9362) == value) return;
                SetData(9362, value, nameof(Max_Slinger_Capacity_Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_2));
            }
        }

        public const string Max_Slinger_Capacity_Unk_3_displayName = "Max Slinger Capacity: Unk 3";
        public const int Max_Slinger_Capacity_Unk_3_sortIndex = 20450;
        [SortOrder(Max_Slinger_Capacity_Unk_3_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_3_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_3 {
            get => GetData<byte>(9363);
            set {
                if (GetData<byte>(9363) == value) return;
                SetData(9363, value, nameof(Max_Slinger_Capacity_Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_3));
            }
        }

        public const string Max_Slinger_Capacity_Unk_4_displayName = "Max Slinger Capacity: Unk 4";
        public const int Max_Slinger_Capacity_Unk_4_sortIndex = 20500;
        [SortOrder(Max_Slinger_Capacity_Unk_4_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_4_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_4 {
            get => GetData<byte>(9364);
            set {
                if (GetData<byte>(9364) == value) return;
                SetData(9364, value, nameof(Max_Slinger_Capacity_Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_4));
            }
        }

        public const string Max_Slinger_Capacity_Unk_5_displayName = "Max Slinger Capacity: Unk 5";
        public const int Max_Slinger_Capacity_Unk_5_sortIndex = 20550;
        [SortOrder(Max_Slinger_Capacity_Unk_5_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_5_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_5 {
            get => GetData<byte>(9365);
            set {
                if (GetData<byte>(9365) == value) return;
                SetData(9365, value, nameof(Max_Slinger_Capacity_Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_5));
            }
        }

        public const string Max_Slinger_Capacity_Torch_Pod_displayName = "Max Slinger Capacity: Torch Pod";
        public const int Max_Slinger_Capacity_Torch_Pod_sortIndex = 20600;
        [SortOrder(Max_Slinger_Capacity_Torch_Pod_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Torch_Pod_displayName)]
        public virtual byte Max_Slinger_Capacity_Torch_Pod {
            get => GetData<byte>(9366);
            set {
                if (GetData<byte>(9366) == value) return;
                SetData(9366, value, nameof(Max_Slinger_Capacity_Torch_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Torch_Pod));
            }
        }

        public const string Max_Slinger_Capacity_Unk_6_displayName = "Max Slinger Capacity: Unk 6";
        public const int Max_Slinger_Capacity_Unk_6_sortIndex = 20650;
        [SortOrder(Max_Slinger_Capacity_Unk_6_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_6_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_6 {
            get => GetData<byte>(9367);
            set {
                if (GetData<byte>(9367) == value) return;
                SetData(9367, value, nameof(Max_Slinger_Capacity_Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_6));
            }
        }

        public const string Max_Slinger_Capacity_Unk_7_displayName = "Max Slinger Capacity: Unk 7";
        public const int Max_Slinger_Capacity_Unk_7_sortIndex = 20700;
        [SortOrder(Max_Slinger_Capacity_Unk_7_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_7_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_7 {
            get => GetData<byte>(9368);
            set {
                if (GetData<byte>(9368) == value) return;
                SetData(9368, value, nameof(Max_Slinger_Capacity_Unk_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_7));
            }
        }

        public const string Max_Slinger_Capacity_Unk_8_displayName = "Max Slinger Capacity: Unk 8";
        public const int Max_Slinger_Capacity_Unk_8_sortIndex = 20750;
        [SortOrder(Max_Slinger_Capacity_Unk_8_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_8_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_8 {
            get => GetData<byte>(9369);
            set {
                if (GetData<byte>(9369) == value) return;
                SetData(9369, value, nameof(Max_Slinger_Capacity_Unk_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_8));
            }
        }

        public const string Max_Slinger_Capacity_Unk_9_displayName = "Max Slinger Capacity: Unk 9";
        public const int Max_Slinger_Capacity_Unk_9_sortIndex = 20800;
        [SortOrder(Max_Slinger_Capacity_Unk_9_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_9_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_9 {
            get => GetData<byte>(9370);
            set {
                if (GetData<byte>(9370) == value) return;
                SetData(9370, value, nameof(Max_Slinger_Capacity_Unk_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_9));
            }
        }

        public const string Max_Slinger_Capacity_Bomb_Pod_displayName = "Max Slinger Capacity: Bomb Pod";
        public const int Max_Slinger_Capacity_Bomb_Pod_sortIndex = 20850;
        [SortOrder(Max_Slinger_Capacity_Bomb_Pod_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Bomb_Pod_displayName)]
        public virtual byte Max_Slinger_Capacity_Bomb_Pod {
            get => GetData<byte>(9371);
            set {
                if (GetData<byte>(9371) == value) return;
                SetData(9371, value, nameof(Max_Slinger_Capacity_Bomb_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Bomb_Pod));
            }
        }

        public const string Max_Slinger_Capacity_Piercing_Pod_displayName = "Max Slinger Capacity: Piercing Pod";
        public const int Max_Slinger_Capacity_Piercing_Pod_sortIndex = 20900;
        [SortOrder(Max_Slinger_Capacity_Piercing_Pod_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Piercing_Pod_displayName)]
        public virtual byte Max_Slinger_Capacity_Piercing_Pod {
            get => GetData<byte>(9372);
            set {
                if (GetData<byte>(9372) == value) return;
                SetData(9372, value, nameof(Max_Slinger_Capacity_Piercing_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Piercing_Pod));
            }
        }

        public const string Max_Slinger_Capacity_Slinger_Thorn_displayName = "Max Slinger Capacity: Slinger Thorn";
        public const int Max_Slinger_Capacity_Slinger_Thorn_sortIndex = 20950;
        [SortOrder(Max_Slinger_Capacity_Slinger_Thorn_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Slinger_Thorn_displayName)]
        public virtual byte Max_Slinger_Capacity_Slinger_Thorn {
            get => GetData<byte>(9373);
            set {
                if (GetData<byte>(9373) == value) return;
                SetData(9373, value, nameof(Max_Slinger_Capacity_Slinger_Thorn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Slinger_Thorn));
            }
        }

        public const string Max_Slinger_Capacity_Dragon_Pod_displayName = "Max Slinger Capacity: Dragon Pod";
        public const int Max_Slinger_Capacity_Dragon_Pod_sortIndex = 21000;
        [SortOrder(Max_Slinger_Capacity_Dragon_Pod_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Dragon_Pod_displayName)]
        public virtual byte Max_Slinger_Capacity_Dragon_Pod {
            get => GetData<byte>(9374);
            set {
                if (GetData<byte>(9374) == value) return;
                SetData(9374, value, nameof(Max_Slinger_Capacity_Dragon_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Dragon_Pod));
            }
        }

        public const string Max_Slinger_Capacity_Unk_10_displayName = "Max Slinger Capacity: Unk 10";
        public const int Max_Slinger_Capacity_Unk_10_sortIndex = 21050;
        [SortOrder(Max_Slinger_Capacity_Unk_10_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_10_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_10 {
            get => GetData<byte>(9375);
            set {
                if (GetData<byte>(9375) == value) return;
                SetData(9375, value, nameof(Max_Slinger_Capacity_Unk_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_10));
            }
        }

        public const string Max_Slinger_Capacity_Unk_11_displayName = "Max Slinger Capacity: Unk 11";
        public const int Max_Slinger_Capacity_Unk_11_sortIndex = 21100;
        [SortOrder(Max_Slinger_Capacity_Unk_11_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_11_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_11 {
            get => GetData<byte>(9376);
            set {
                if (GetData<byte>(9376) == value) return;
                SetData(9376, value, nameof(Max_Slinger_Capacity_Unk_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_11));
            }
        }

        public const string Max_Slinger_Capacity_Unk_12_displayName = "Max Slinger Capacity: Unk 12";
        public const int Max_Slinger_Capacity_Unk_12_sortIndex = 21150;
        [SortOrder(Max_Slinger_Capacity_Unk_12_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_12_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_12 {
            get => GetData<byte>(9377);
            set {
                if (GetData<byte>(9377) == value) return;
                SetData(9377, value, nameof(Max_Slinger_Capacity_Unk_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_12));
            }
        }

        public const string Max_Slinger_Capacity_Unk_13_displayName = "Max Slinger Capacity: Unk 13";
        public const int Max_Slinger_Capacity_Unk_13_sortIndex = 21200;
        [SortOrder(Max_Slinger_Capacity_Unk_13_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_13_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_13 {
            get => GetData<byte>(9378);
            set {
                if (GetData<byte>(9378) == value) return;
                SetData(9378, value, nameof(Max_Slinger_Capacity_Unk_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_13));
            }
        }

        public const string Max_Slinger_Capacity_Unk_14_displayName = "Max Slinger Capacity: Unk 14";
        public const int Max_Slinger_Capacity_Unk_14_sortIndex = 21250;
        [SortOrder(Max_Slinger_Capacity_Unk_14_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_14_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_14 {
            get => GetData<byte>(9379);
            set {
                if (GetData<byte>(9379) == value) return;
                SetData(9379, value, nameof(Max_Slinger_Capacity_Unk_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_14));
            }
        }

        public const string Max_Slinger_Capacity_Unk_15_displayName = "Max Slinger Capacity: Unk 15";
        public const int Max_Slinger_Capacity_Unk_15_sortIndex = 21300;
        [SortOrder(Max_Slinger_Capacity_Unk_15_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_15_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_15 {
            get => GetData<byte>(9380);
            set {
                if (GetData<byte>(9380) == value) return;
                SetData(9380, value, nameof(Max_Slinger_Capacity_Unk_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_15));
            }
        }

        public const string Max_Slinger_Capacity_Unk_16_displayName = "Max Slinger Capacity: Unk 16";
        public const int Max_Slinger_Capacity_Unk_16_sortIndex = 21350;
        [SortOrder(Max_Slinger_Capacity_Unk_16_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_16_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_16 {
            get => GetData<byte>(9381);
            set {
                if (GetData<byte>(9381) == value) return;
                SetData(9381, value, nameof(Max_Slinger_Capacity_Unk_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_16));
            }
        }

        public const string Max_Slinger_Capacity_Unk_17_displayName = "Max Slinger Capacity: Unk 17";
        public const int Max_Slinger_Capacity_Unk_17_sortIndex = 21400;
        [SortOrder(Max_Slinger_Capacity_Unk_17_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_17_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_17 {
            get => GetData<byte>(9382);
            set {
                if (GetData<byte>(9382) == value) return;
                SetData(9382, value, nameof(Max_Slinger_Capacity_Unk_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_17));
            }
        }

        public const string Max_Slinger_Capacity_Crystalburst_displayName = "Max Slinger Capacity: Crystalburst";
        public const int Max_Slinger_Capacity_Crystalburst_sortIndex = 21450;
        [SortOrder(Max_Slinger_Capacity_Crystalburst_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Crystalburst_displayName)]
        public virtual byte Max_Slinger_Capacity_Crystalburst {
            get => GetData<byte>(9383);
            set {
                if (GetData<byte>(9383) == value) return;
                SetData(9383, value, nameof(Max_Slinger_Capacity_Crystalburst));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Crystalburst));
            }
        }

        public const string Max_Slinger_Capacity_Puddle_Pod_displayName = "Max Slinger Capacity: Puddle Pod";
        public const int Max_Slinger_Capacity_Puddle_Pod_sortIndex = 21500;
        [SortOrder(Max_Slinger_Capacity_Puddle_Pod_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Puddle_Pod_displayName)]
        public virtual byte Max_Slinger_Capacity_Puddle_Pod {
            get => GetData<byte>(9384);
            set {
                if (GetData<byte>(9384) == value) return;
                SetData(9384, value, nameof(Max_Slinger_Capacity_Puddle_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Puddle_Pod));
            }
        }

        public const string Max_Slinger_Capacity_Unk_18_displayName = "Max Slinger Capacity: Unk 18";
        public const int Max_Slinger_Capacity_Unk_18_sortIndex = 21550;
        [SortOrder(Max_Slinger_Capacity_Unk_18_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_18_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_18 {
            get => GetData<byte>(9385);
            set {
                if (GetData<byte>(9385) == value) return;
                SetData(9385, value, nameof(Max_Slinger_Capacity_Unk_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_18));
            }
        }

        public const string Max_Slinger_Capacity_Unk_19_displayName = "Max Slinger Capacity: Unk 19";
        public const int Max_Slinger_Capacity_Unk_19_sortIndex = 21600;
        [SortOrder(Max_Slinger_Capacity_Unk_19_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_19_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_19 {
            get => GetData<byte>(9386);
            set {
                if (GetData<byte>(9386) == value) return;
                SetData(9386, value, nameof(Max_Slinger_Capacity_Unk_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_19));
            }
        }

        public const string Max_Slinger_Capacity_Unk_20_displayName = "Max Slinger Capacity: Unk 20";
        public const int Max_Slinger_Capacity_Unk_20_sortIndex = 21650;
        [SortOrder(Max_Slinger_Capacity_Unk_20_sortIndex)]
        [DisplayName(Max_Slinger_Capacity_Unk_20_displayName)]
        public virtual byte Max_Slinger_Capacity_Unk_20 {
            get => GetData<byte>(9387);
            set {
                if (GetData<byte>(9387) == value) return;
                SetData(9387, value, nameof(Max_Slinger_Capacity_Unk_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_20));
            }
        }

        public const string __21700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __21700_sortIndex = 21700;
        [SortOrder(__21700_sortIndex)]
        [DisplayName(__21700_displayName)]
        [IsReadOnly]
        public virtual byte __21700 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(__21700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__21700));
            }
        }

        public const string _Skipping_ahead__21750_displayName = "------Skipping ahead.";
        public const int _Skipping_ahead__21750_sortIndex = 21750;
        [SortOrder(_Skipping_ahead__21750_sortIndex)]
        [DisplayName(_Skipping_ahead__21750_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_ahead__21750 {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(_Skipping_ahead__21750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead__21750));
            }
        }

        public const string __21800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __21800_sortIndex = 21800;
        [SortOrder(__21800_sortIndex)]
        [DisplayName(__21800_displayName)]
        [IsReadOnly]
        public virtual byte __21800 {
            get => GetData<byte>(55);
            set {
                if (GetData<byte>(55) == value) return;
                SetData(55, value, nameof(__21800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__21800));
            }
        }

        public const string Gesture_Dragoon_Jump_Loop_Time_displayName = "Gesture: Dragoon Jump Loop Time";
        public const int Gesture_Dragoon_Jump_Loop_Time_sortIndex = 21850;
        [SortOrder(Gesture_Dragoon_Jump_Loop_Time_sortIndex)]
        [DisplayName(Gesture_Dragoon_Jump_Loop_Time_displayName)]
        public virtual float Gesture_Dragoon_Jump_Loop_Time {
            get => GetData<float>(17853);
            set {
                if (GetData<float>(17853) == value) return;
                SetData(17853, value, nameof(Gesture_Dragoon_Jump_Loop_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gesture_Dragoon_Jump_Loop_Time));
            }
        }

        public const string Gesture_Dragoon_Jump_Meteor_Start_displayName = "Gesture: Dragoon Jump Meteor Start";
        public const int Gesture_Dragoon_Jump_Meteor_Start_sortIndex = 21900;
        [SortOrder(Gesture_Dragoon_Jump_Meteor_Start_sortIndex)]
        [DisplayName(Gesture_Dragoon_Jump_Meteor_Start_displayName)]
        public virtual float Gesture_Dragoon_Jump_Meteor_Start {
            get => GetData<float>(17857);
            set {
                if (GetData<float>(17857) == value) return;
                SetData(17857, value, nameof(Gesture_Dragoon_Jump_Meteor_Start));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gesture_Dragoon_Jump_Meteor_Start));
            }
        }

        public const string Gesture_Dragoon_Jump_Meteor_Duration_displayName = "Gesture: Dragoon Jump Meteor Duration";
        public const int Gesture_Dragoon_Jump_Meteor_Duration_sortIndex = 21950;
        [SortOrder(Gesture_Dragoon_Jump_Meteor_Duration_sortIndex)]
        [DisplayName(Gesture_Dragoon_Jump_Meteor_Duration_displayName)]
        public virtual float Gesture_Dragoon_Jump_Meteor_Duration {
            get => GetData<float>(17861);
            set {
                if (GetData<float>(17861) == value) return;
                SetData(17861, value, nameof(Gesture_Dragoon_Jump_Meteor_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gesture_Dragoon_Jump_Meteor_Duration));
            }
        }

        public const string __22000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __22000_sortIndex = 22000;
        [SortOrder(__22000_sortIndex)]
        [DisplayName(__22000_displayName)]
        [IsReadOnly]
        public virtual byte __22000 {
            get => GetData<byte>(55);
            set {
                if (GetData<byte>(55) == value) return;
                SetData(55, value, nameof(__22000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__22000));
            }
        }

        public const string _Skipping_the_rest__22050_displayName = "------Skipping the rest.";
        public const int _Skipping_the_rest__22050_sortIndex = 22050;
        [SortOrder(_Skipping_the_rest__22050_sortIndex)]
        [DisplayName(_Skipping_the_rest__22050_displayName)]
        [IsReadOnly]
        public virtual byte _Skipping_the_rest__22050 {
            get => GetData<byte>(55);
            set {
                if (GetData<byte>(55) == value) return;
                SetData(55, value, nameof(_Skipping_the_rest__22050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_the_rest__22050));
            }
        }

        public const string __22100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __22100_sortIndex = 22100;
        [SortOrder(__22100_sortIndex)]
        [DisplayName(__22100_displayName)]
        [IsReadOnly]
        public virtual byte __22100 {
            get => GetData<byte>(55);
            set {
                if (GetData<byte>(55) == value) return;
                SetData(55, value, nameof(__22100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__22100));
            }
        }

        public const int lastSortIndex = 22150;
    }
}