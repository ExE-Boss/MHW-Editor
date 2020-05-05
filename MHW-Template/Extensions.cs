﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using MHW_Template.Armors;
using MHW_Template.Items;
using MHW_Template.Weapons;

namespace MHW_Template {
    public static class Extensions {
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T> {
            if (val.CompareTo(min) < 0) {
                return min;
            } else if (val.CompareTo(max) > 0) {
                return max;
            } else {
                return val;
            }
        }

        public static bool Is(this Type source, params Type[] types) {
            return types.Any(type => type.IsAssignableFrom(source));
        }

        public static T[] Subsequence<T>(this IEnumerable<T> arr, int startIndex, int length) {
            return arr.Skip(startIndex).Take(length).ToArray();
        }

        public static bool ContainsIgnoreCase(this IEnumerable<string> arr, string needle) {
            return arr.Any(s => string.Equals(s, needle, StringComparison.CurrentCultureIgnoreCase));
        }

        public static V TryGet<K, V>(this IDictionary<K, V> dict, K key, V defaultValue) {
            if (dict == null) return defaultValue;
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        public static string TryGet<K>(this IDictionary<K, string> dict, K key, string defaultValue = "Unknown") {
            if (dict == null) return defaultValue;
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        public static T GetData<T>(this IEnumerable<byte> bytes) where T : struct {
            return bytes.GetData<T>(0, Marshal.SizeOf(default(T)));
        }

        public static T GetData<T>(this IEnumerable<byte> bytes, int offset) where T : struct {
            return bytes.GetData<T>(offset, Marshal.SizeOf(default(T)));
        }

        public static T GetData<T>(this IEnumerable<byte> bytes, int offset, int size) where T : struct {
            var subsequence = bytes.Subsequence(offset, size);
            var handle      = GCHandle.Alloc(subsequence, GCHandleType.Pinned);

            try {
                var rawDataPtr = handle.AddrOfPinnedObject();
                return (T) Marshal.PtrToStructure(rawDataPtr, typeof(T));
            } finally {
                handle.Free();
            }
        }

        public static string SHA512(this string fileName) {
            using var file = File.OpenRead(fileName);
            return file.SHA512();
        }

        public static string SHA512(this Stream stream) {
            using var sha512 = System.Security.Cryptography.SHA512.Create();
            var       hash   = sha512.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        public static string SHA512(this byte[] bytes) {
            using var sha512 = System.Security.Cryptography.SHA512.Create();
            var       hash   = sha512.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        public static Dictionary<K, V> Sort<K, V, O>(this Dictionary<K, V> dict, Func<KeyValuePair<K, V>, O> keySelector) {
            return dict.OrderBy(keySelector)
                       .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<K, V> SortDescending<K, V, O>(this Dictionary<K, V> dict, Func<KeyValuePair<K, V>, O> keySelector) {
            return dict.OrderByDescending(keySelector)
                       .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<K2, V> GetOrCreate<K1, K2, V>(this Dictionary<K1, Dictionary<K2, V>> dict, K1 key) {
            if (dict.ContainsKey(key)) return dict[key];
            dict[key] = new Dictionary<K2, V>();
            return dict[key];
        }

        public static List<V> GetOrCreate<K, V>(this Dictionary<K, List<V>> dict, K key) {
            if (dict.ContainsKey(key)) return dict[key];
            dict[key] = new List<V>();
            return dict[key];
        }

        public static string ToDatFileName(this WeaponType weaponType) {
            return weaponType switch {
                WeaponType.Greatsword => "l_sword.wp_dat",
                WeaponType.Sword_and_Shield => "sword.wp_dat",
                WeaponType.Dual_Blades => "w_sword.wp_dat",
                WeaponType.Longsword => "tachi.wp_dat",
                WeaponType.Hammer => "hammer.wp_dat",
                WeaponType.Hunting_Horn => "whistle.wp_dat",
                WeaponType.Lance => "lance.wp_dat",
                WeaponType.Gunlance => "g_lance.wp_dat",
                WeaponType.Switch_Axe => "s_axe.wp_dat",
                WeaponType.Charge_Blade => "c_axe.wp_dat",
                WeaponType.Insect_Glaive => "rod.wp_dat",
                WeaponType.Bow => "bow.wp_dat_g",
                WeaponType.Light_Bowgun => "lbg.wp_dat_g",
                WeaponType.Heavy_Bowgun => "hbg.wp_dat_g",
                _ => null
            };
        }

        public static string ToDatFileName(this EquipmentType equipmentType) {
            return equipmentType switch {
                EquipmentType.Greatsword => "l_sword.wp_dat",
                EquipmentType.Sword_and_Shield => "sword.wp_dat",
                EquipmentType.Dual_Blades => "w_sword.wp_dat",
                EquipmentType.Longsword => "tachi.wp_dat",
                EquipmentType.Hammer => "hammer.wp_dat",
                EquipmentType.Hunting_Horn => "whistle.wp_dat",
                EquipmentType.Lance => "lance.wp_dat",
                EquipmentType.Gunlance => "g_lance.wp_dat",
                EquipmentType.Switch_Axe => "s_axe.wp_dat",
                EquipmentType.Charge_Blade => "c_axe.wp_dat",
                EquipmentType.Insect_Glaive => "rod.wp_dat",
                EquipmentType.Bow => "bow.wp_dat_g",
                EquipmentType.Light_Bowgun => "lbg.wp_dat_g",
                EquipmentType.Heavy_Bowgun => "hbg.wp_dat_g",
                var x when x == EquipmentType.Armor_Head
                           || x == EquipmentType.Armor_Chest
                           || x == EquipmentType.Armor_Arms
                           || x == EquipmentType.Armor_Waist
                           || x == EquipmentType.Armor_Legs
                           || x == EquipmentType.Armor_Charm => "armor.am_dat",
                _ => null
            };
        }

        public static string ToDatFileName(this ArmorType armorType) {
            return "armor.am_dat";
        }
    }
}