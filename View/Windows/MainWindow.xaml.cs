using SI_SQL55.Core;
using SI_SQL55.View.Pages;
using System.Windows;

namespace SI_SQL55
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Core1.MyCore = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
