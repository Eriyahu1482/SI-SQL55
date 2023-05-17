using SI_SQL55.Core;
using SI_SQL55.Model;
using SI_SQL55.View.Windows;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SI_SQL55.View.Pages
{
    public partial class MainPage : Page
    {
        private DataContext? _db = null;
        public MainPage()
        {
            InitializeComponent();
            _db = new DataContext();
        }
        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            User? userModel = _db?.Users.FirstOrDefault(predicate: x => x.Login == TbLogin.Text && x.Password == TbPass.Password);

            if (userModel != null)
            {
                switch (userModel.Role.RoleID) 
                {

                }
            }
            else
            {
                new ErrorWindow().ShowDialog();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new CloseWindow().ShowDialog();
        }

        private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Core1.MyCore.Navigate(new SingupPage());
        }
    }
}
