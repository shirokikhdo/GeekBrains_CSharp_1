using H7E2_GuessNumber.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace H7E2_GuessNumber.Views.Controls
{
    public class InputViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public EventHandler CheckInputData;

        private string _inputData;
        public string InputData
        {
            get => _inputData;
            set
            {
                _inputData = value;
                OnPropertyChanged(nameof(InputData));
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

        private RelayCommand _checkCmd;
        public RelayCommand CheckCmd
        {
            get => _checkCmd ?? (_checkCmd = new RelayCommand((obj =>
            {
                CheckInputData?.Invoke(this, null);
                _updateData();
            })));
        }

        private Model _model;
        public InputViewModel(Model model)
        {
            _model = model;
            _updateData();
        }

        private void _updateData()
        {
            Steps = _model.Steps.ToString();
        }
    }
}