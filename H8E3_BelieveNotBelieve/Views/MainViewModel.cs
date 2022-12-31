using H8E3_BelieveNotBelieve.Models;
using H8E3_BelieveNotBelieve.Views.Controls;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace H8E3_BelieveNotBelieve.Views
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        #region ViewBindings
        private string _questionText;
        public string QuestionText
        {
            get => _questionText;
            set
            {
                _questionText = value;
                OnPropertyChanged(nameof(QuestionText));
            }
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }
        private UserControl _numericUpDown;
        public UserControl NumericUpDown
        {
            get => _numericUpDown;
            set
            {
                _numericUpDown = value;
                OnPropertyChanged(nameof(NumericUpDown));
            }
        }
        #endregion

        #region Commands
        private RelayCommand _newCmd;
        public RelayCommand NewCmd
        {
            get => _newCmd ?? (_newCmd = new RelayCommand(obj => _cmd_new()));
        }

        private RelayCommand _openCmd;
        public RelayCommand OpenCmd
        {
            get => _openCmd ?? (_openCmd = new RelayCommand(obj => _cmd_open()));
        }

        private RelayCommand _saveCmd;
        public RelayCommand SaveCmd
        {
            get => _saveCmd ?? (_saveCmd = new RelayCommand(obj => _cmd_save()));
        }

        private Action _closeAction;
        private RelayCommand _exitCmd;
        public RelayCommand ExitCmd
        {
            get => _exitCmd ?? (_exitCmd = new RelayCommand(obj => _closeAction?.Invoke()));
        }

        private RelayCommand _addCmd;
        public RelayCommand AddCmd
        {
            get => _addCmd ?? (_addCmd = new RelayCommand(obj => _cmd_add()));
        }

        private RelayCommand _deleteCmd;
        public RelayCommand DeleteCmd
        {
            get => _deleteCmd ?? (_deleteCmd = new RelayCommand(obj => _cmd_delete()));
        }

        private RelayCommand _saveBtnCmd;
        public RelayCommand SaveBtnCmd
        {
            get => _saveBtnCmd ?? (_saveBtnCmd = new RelayCommand(obj => _cmd_saveBtn()));
        }
        #endregion

        private TrueFalse _db;
        private NumericUpDownModel _numericUpDownModel;
        private NumericUpDownView _numericUpDownView;
        private NumericUpDownViewModel _numericUpDownViewModel;
        public MainViewModel(Action action)
        {
            MessageBox.Show("Укажите базу данных!");
            _closeAction += action;
            _numericUpDownView = new NumericUpDownView();
            NumericUpDown = _numericUpDownView;
            _numericUpDownViewModel = _numericUpDownView.GetDataContext();
            _numericUpDownModel = _numericUpDownViewModel.Model;
        }

        #region Methods
        private void _cmd_new()
        {
            var saveFileDialog = new SaveFileDialog();
            var result = saveFileDialog.ShowDialog();
            if (result.Value)
            {
                _db = new TrueFalse(saveFileDialog.FileName);
                _db.Add(string.Empty, false);
                _db.Save();
                var startIndex = 0;
                _numericUpDownModel.Value = startIndex;
                _numericUpDownModel.Minimum = startIndex;
                _numericUpDownModel.Maximum = _db.Count-1;
                _updateData();
            }
            MessageBox.Show("База данных создана. Введите данные.");
        }

        private void _cmd_open()
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result.Value)
            {
                _db = new TrueFalse(openFileDialog.FileName);
                _db.Load();
                var startIndex = 0;
                _numericUpDownModel.Value = startIndex;
                _numericUpDownModel.Minimum = startIndex;
                _numericUpDownModel.Maximum = _db.Count-1;
                _updateData();
            }
            MessageBox.Show("База данных открыта.");
        }

        private void _cmd_save()
        {
            if (_db != null)
            {
                _db.Save();
                MessageBox.Show("База данных сохранена.");
            }
            else MessageBox.Show("База данных не указана!");
        }

        private void _updateData()
        {
            var value = _db[_numericUpDownModel.Value];
            QuestionText = value.Text;
            IsChecked = value.TrueFalse;
            _numericUpDownViewModel.UpdateData();
        }

        private void _cmd_add()
        {
            if (_db == null)
            {
                MessageBox.Show("Укажите базу данных!");
                return;
            }
            _db.Add(string.Empty, false);
            var lastIndex = _db.Count - 1;
            _numericUpDownModel.Value = lastIndex;
            _numericUpDownModel.Maximum = lastIndex;
            _updateData();
            MessageBox.Show("Добавлен новый вопрос.");
        }

        private void _cmd_delete()
        {
            if (_db == null)
            {
                MessageBox.Show("Укажите базу данных!");
                return;
            }
            if (_numericUpDownModel.Maximum == 1)
            {
                MessageBox.Show("В базе данных невозможно удалить последний элемент, измените данные текущего вопроса!");
                return;
            }
            _db.Remove(_numericUpDownModel.Value);
            _numericUpDownModel.Maximum--;
            _updateData();
            MessageBox.Show("Удален текущий вопрос.");
        }

        private void _cmd_saveBtn()
        {
            if(_db == null)
            {
                MessageBox.Show("Укажите базу данных!");
                return;
            }
            var currentIndex = _numericUpDownModel.Value;
            _db[currentIndex].Text = QuestionText;
            _db[currentIndex].TrueFalse = IsChecked;
            MessageBox.Show("Вопрос сохранен. Сохраните базу данных, чтобы внести изменения.");
        }
        #endregion
    }
}