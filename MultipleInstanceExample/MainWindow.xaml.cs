using System.Windows;

namespace MultipleInstanceExample
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel vm)
        {
            DataContext = vm;

            InitializeComponent();
        }
    }
}
