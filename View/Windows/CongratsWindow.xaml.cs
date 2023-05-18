using System.Windows;

namespace SI_SQL55.View.Windows
{
    public partial class CongratsWindow : Window
    {
        public CongratsWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
