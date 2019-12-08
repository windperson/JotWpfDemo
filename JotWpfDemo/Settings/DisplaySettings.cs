using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media;

namespace JotWpfDemo.Settings
{
    [Serializable]
    public class DisplaySettings : INotifyPropertyChanged
    {
        private FontFamily _font;
        public FontFamily Font
        {
            get { return _font; }
            set { _font = value; OnPropertyChanged(); }
        }

        private decimal _fontSize = 15;
        public decimal FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; OnPropertyChanged(); }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
