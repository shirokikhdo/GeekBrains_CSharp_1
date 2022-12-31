using H8E3_BelieveNotBelieve.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace H8E3_BelieveNotBelieve.Views.Controls
{
    public class NumericUpDownViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private string _upDownText;
        public string UpDownText
        {
            get => _upDownText;
            set
            {
                _upDownText = value;
                OnPropertyChanged(nameof(UpDownText));
            }
        }

        private RelayCommand _incrementCmd;
        public RelayCommand IncrementCmd
        {
            get => _incrementCmd ?? (_incrementCmd = new RelayCommand(obj =>
            {
                Model.Increment();
                UpdateData();
            }));
        }

        private RelayCommand _decrementCmd;
        public RelayCommand DecrementCmd
        {
            get => _decrementCmd ?? (_decrementCmd = new RelayCommand(obj =>
            {
                Model.Decrement();
                UpdateData();
            }));
        }

        public NumericUpDownModel Model;
        public NumericUpDownViewModel()
        {
            Model = new NumericUpDownModel();
            UpdateData();
        }

        public void UpdateData()
        {
            var value = Model.Value + 1;
            UpDownText = value.ToString();
        }
    }
}