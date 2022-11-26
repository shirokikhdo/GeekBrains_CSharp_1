using H7E1_Doubler.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace H7E1_Doubler.Views.Controls
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private RelayCommand _playCmd;
        public RelayCommand PlayCmd
        {
            get => _playCmd ?? (_playCmd = new RelayCommand((obj => Play_Click?.Invoke(this, null))));
        }

        public EventHandler Play_Click;
    }
}