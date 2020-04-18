﻿using System.Collections.Generic;
using System.Text;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;
using Newtonsoft.Json;

namespace MHW_Editor.Assets {
    public static class DataHelper {
        public static readonly LangMap armorData = new LangMap(); // Uses GMD reference.
        public static readonly LangMap awakeningNames = new LangMap();
        public static readonly LangMap awakeningDescriptions = new LangMap();
        public static readonly LangMap bountyNames = new LangMap();
        public static readonly LangMap bountyDescriptions = new LangMap();
        public static readonly LangMap itemNames = new LangMap();
        public static readonly LangMap itemDescriptions = new LangMap();
        public static readonly LangMap kinsectNames = new LangMap();
        public static readonly LangMap mantleNames = new LangMap();
        public static readonly LangMap mantleDescriptions = new LangMap();
        public static readonly LangMap otomoArmorData = new LangMap(); // Uses GMD reference.
        public static readonly LangMap otomoWeaponData = new LangMap(); // Uses GMD reference.
        public static readonly LangMap pendantNames = new LangMap();
        public static readonly LangMap skillNames = new LangMap();
        public static readonly LangMap skillDescriptions = new LangMap();
        public static readonly Dictionary<uint, string> songNames = new Dictionary<uint, string>(); // Has no lang.
        public static readonly Dictionary<string, LangMap> weaponData = new Dictionary<string, LangMap>(); // Has wp file name too. Uses GMD reference.
        public static readonly Dictionary<string, Dictionary<int, NameDescPair>> collisionTranslationsData;
        public static readonly Dictionary<WeaponTypeOnlyWeapons, LangMap> weaponIdNameLookup;

        public static readonly Dictionary<string, Dictionary<string, List<string>>> BAD_FILE_HASH_MAP;
        public static readonly Dictionary<string, string> GOOD_CHUNK_MAP;
        public static readonly Dictionary<string, string> FILE_PATH_MAP;
        public static readonly Dictionary<string, ulong> FILE_SIZE_MAP;

        static DataHelper() {
            BAD_FILE_HASH_MAP = LoadDict<string, Dictionary<string, List<string>>>(EditorAssets.BadHashMap);
            GOOD_CHUNK_MAP = LoadDict<string, string>(EditorAssets.GoodChunkMap);
            FILE_PATH_MAP = LoadDict<string, string>(EditorAssets.FilePathMap);
            FILE_SIZE_MAP = LoadDict<string, ulong>(EditorAssets.FileSizeMap);

            collisionTranslationsData = LoadDict<string, Dictionary<int, NameDescPair>>(Assets.CollisionTranslationsData);
            weaponIdNameLookup = LoadDict<WeaponTypeOnlyWeapons, LangMap>(Assets.WeaponNameLookup);

            foreach (var lang in Global.LANGUAGES) {
                ParseItemData(lang);
                ParseSkillData(lang);
                ParseSongData();
                ParseBountyData(lang);
                ParseMantleData(lang);
                ParseAwakeningData(lang);

                armorData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_armorData"));
                otomoArmorData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_otomo_armorData"));
                otomoWeaponData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_otomo_weaponData"));
                kinsectNames[lang] = LoadDict<uint, string>(GetAsset($"{lang}_insectData"));
                pendantNames[lang] = LoadDict<uint, string>(GetAsset($"{lang}_pendantData"));

                weaponData[lang] = new LangMap();
                foreach (var weapon in Global.WEAPONS) {
                    weaponData[lang][weapon] = LoadDict<uint, string>(GetAsset($"{lang}_{weapon}"));
                }
            }
        }

        private static void ParseItemData(string lang) {
            itemNames[lang] = new Dictionary<uint, string>();
            itemDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_itemData"));
            rawItemData[0] = "--------";

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                itemNames[lang][key] = rawItemData[index];
                itemDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseSkillData(string lang) {
            skillNames[lang] = new Dictionary<uint, string>();
            skillDescriptions[lang] = new Dictionary<uint, string>();

            var rawSkillData = LoadDict<uint, string>(GetAsset($"{lang}_skillData"));
            rawSkillData[0] = "--------";

            const uint step = 3;
            for (uint index = 0; index < rawSkillData.Count; index += step) {
                var key = index / step;

                skillNames[lang][key] = rawSkillData[index];
                skillDescriptions[lang][key] = rawSkillData[index + 2].Replace("\r\n", " ");
            }
        }

        private static void ParseSongData() {
            var rawSongData = LoadDict<uint, string>(Assets.songData);

            foreach (var pair in rawSongData) {
                songNames[pair.Key] = pair.Value;
            }
        }

        private static void ParseBountyData(string lang) {
            bountyNames[lang] = new Dictionary<uint, string>();
            bountyDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_bountyData"));

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                bountyNames[lang][key] = rawItemData[index];
                bountyDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseMantleData(string lang) {
            mantleNames[lang] = new Dictionary<uint, string>();
            mantleDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_mantleData"));

            const uint step = 4;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                mantleNames[lang][key] = rawItemData[index];
                mantleDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseAwakeningData(string lang) {
            awakeningNames[lang] = new Dictionary<uint, string>();
            awakeningDescriptions[lang] = new Dictionary<uint, string>();

            var rawAwakeningData = LoadDict<uint, string>(GetAsset($"{lang}_awakeningData"));

            const uint step = 2;
            for (uint index = 0; index < rawAwakeningData.Count; index += step) {
                var key = index / step;

                awakeningNames[lang][key] = rawAwakeningData[index];
                awakeningDescriptions[lang][key] = rawAwakeningData[index + 1].Replace("\r\n", " ");
            }
        }

        private static Dictionary<K, V> LoadDict<K, V>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Dictionary<K, V>>(json);
        }

        private static byte[] GetAsset(string assetName) {
            return (byte[]) Assets.ResourceManager.GetObject(assetName);
        }
    }
}