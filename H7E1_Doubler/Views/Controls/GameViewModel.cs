using H7E1_Doubler.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace H7E1_Doubler.Views.Controls
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public EventHandler EndGame;

        private string _value;
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        private string _steps;
        public string Steps
        {
            get => _steps;
            set
            {
                _steps = value;
                OnPropertyChanged(nameof(Steps));
            }
        }

        private RelayCommand _plusCmd;
        public RelayCommand PlusCmd
        {
            get => _plusCmd ?? (_plusCmd = new RelayCommand((obj =>
            {
                _model.Plus();
                _updateData();
            })));
        }

        private RelayCommand _multiplyCmd;
        public RelayCommand MultiplyCmd
        {
            get => _multiplyCmd ?? (_multiplyCmd = new RelayCommand((obj =>
            {
                _model.Multiply();
                _updateData();
            })));
        }

        private RelayCommand _resetCmd;
        public RelayCommand ResetCmd
        {
            get => _resetCmd ?? (_resetCmd = new RelayCommand((obj =>
            {
                _model.Reset();
                _updateData();
            })));
        }

        private RelayCommand _cancelCmd;
        public RelayCommand CancelCmd
        {
            get => _cancelCmd ?? (_cancelCmd = new RelayCommand((obj =>
            {
                _model.Cancel();
                _updateData();
            })));
        }

        private Model _model;
        public GameViewModel(int result)
        {
            _model = new Model(result);
            _updateData();
        }

        private void _updateData()
        {
            Value = _model.Value.ToString();
            Steps = _model.Steps.ToString();
            if (!_model.CheckValue())
            {
                EndGame?.Invoke(this, null);
            }
        }
    }
}