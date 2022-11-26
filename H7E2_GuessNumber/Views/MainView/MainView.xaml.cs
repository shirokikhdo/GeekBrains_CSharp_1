using System;
using System.Windows;

namespace H7E2_GuessNumber.Views.MainView
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            DataContext = vm;
            vm.Exit += _exit;
        }

        private void _exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
