﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public abstract class MhwStructItem : IMhwStructItem {
        public event PropertyChangedEventHandler PropertyChanged;

        public ulong index;
        public ulong Index => index;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChanged(IEnumerable<string> propertyName) {
            foreach (var name in propertyName) {
                OnPropertyChanged(name);
            }
        }

        public void OnPropertyChanged(params string[] propertyName) {
            foreach (var name in propertyName) {
                OnPropertyChanged(name);
            }
        }
    }
}