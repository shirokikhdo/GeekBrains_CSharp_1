using System.Windows.Controls;

namespace H8E3_BelieveNotBelieve.Views.Controls
{
    /// <summary>
    /// Логика взаимодействия для NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDownView : UserControl
    {
        public NumericUpDownView()
        {
            InitializeComponent();
            DataContext = new NumericUpDownViewModel();
        }

        public NumericUpDownViewModel GetDataContext() => DataContext as NumericUpDownViewModel;
    }
}