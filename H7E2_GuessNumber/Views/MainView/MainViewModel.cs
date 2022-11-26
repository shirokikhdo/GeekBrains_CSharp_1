using H7E2_GuessNumber.Models;
using H7E2_GuessNumber.Views.Controls;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace H7E2_GuessNumber.Views.MainView
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public EventHandler Exit;

        private UserControl _visibleContent;
        public UserControl VisibleContent
        {
            get => _visibleContent;
            set
            {
                _visibleContent = value;
                OnPropertyChanged(nameof(VisibleContent));
            }
        }

        private Model _model;
        private InputViewModel _inputViewModel;
        public MainViewModel()
        {
            _model = new Model();
            var inputView = new InputView()
            {
                DataContext = new InputViewModel(_model)
            };
            var inputViewModel = inputView.DataContext as InputViewModel;
            _inputViewModel = inputViewModel;
            _inputViewModel.CheckInputData += _check;
            VisibleContent = inputView;
        }

        private void _check(object sender, EventArgs e)
        {
            if (!int.TryParse(_inputViewModel.InputData, out var value))
            {
                MessageBox.Show("Введенное значение не является целым числом");
            }
            else
            {
                if (!_model.CheckValue(value))
                {
                    if (value < _model.Result)
                    {
                        MessageBox.Show("Неправильно!\nВведенное значение меньше загадонного числа!");
                    }
                    if (value > _model.Result)
                    {
                        MessageBox.Show("Неправильно!\nВведенное значение больше загадонного числа!");
                    }
                }             
                else
                {
                    MessageBox.Show("Правильно!\nВы угадали!");
                    Exit?.Invoke(this, null);
                }
            }
        }
    }
}