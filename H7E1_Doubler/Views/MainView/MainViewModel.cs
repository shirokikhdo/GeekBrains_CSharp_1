using H7E1_Doubler.Models;
using H7E1_Doubler.Views.Controls;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace H7E1_Doubler.Views.MainView
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

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

        private UserControl _menuView;
        private UserControl _gameView;
        public MainViewModel()
        {
            var menuView = new MenuView()
            {
                DataContext = new MenuViewModel()
            };
            _menuView = menuView;
            VisibleContent = _menuView;
            
            var menuViewModel = menuView.DataContext as MenuViewModel;
            menuViewModel.Play_Click += _play;
        }

        private void _play(object sender, EventArgs e)
        {
            var result = Model.GenerateResult();
            MessageBox.Show($"Результат, который вы должны получить - {result}");
            var gameView = new GameView()
            {
                DataContext = new GameViewModel(result)
            };
            _gameView = gameView;
            VisibleContent = _gameView;
            var gameViewModel = gameView.DataContext as GameViewModel;
            gameViewModel.EndGame += _end;
        }

        private void _end(object sender, EventArgs e)
        {
            VisibleContent = _menuView;
        }
    }
}