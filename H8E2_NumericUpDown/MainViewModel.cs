using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace H8E2_NumericUpDown
{
    public class MainViewModel : INotifyPropertyChanged
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

        private string _textData;
        public string TextData
        {
            get => _textData;
            set
            {
                _textData = value;
                OnPropertyChanged(nameof(TextData));
            }
        }

        private RelayCommand _incrementCmd;
        public RelayCommand IncrementCmd
        {
            get => _incrementCmd ?? (_incrementCmd = new RelayCommand(obj =>
            {
                _model.Increment();
                _updateData();
            }));
        }

        private RelayCommand _decrementCmd;
        public RelayCommand DecrementCmd
        {
            get => _decrementCmd ?? (_decrementCmd = new RelayCommand(obj =>
            {
                _model.Decrement();
                _updateData();
            }));
        }

        private Model _model;
        public MainViewModel()
        {
            _model = new Model();
            _updateData();
        }

        private void _updateData()
        {
            var value = _model.Value.ToString();
            UpDownText = value;
            TextData = value;
        }
    }
}