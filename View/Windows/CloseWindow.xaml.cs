using System.Windows;

namespace SI_SQL55.View.Windows
{
    public partial class CloseWindow : Window
    {
        public CloseWindow()
        {
            InitializeComponent();
        }

        private void YES_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NO_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
