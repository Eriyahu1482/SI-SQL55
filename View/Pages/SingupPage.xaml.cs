using SI_SQL55.Core;
using SI_SQL55.Model;
using SI_SQL55.View.Windows;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SI_SQL55.View.Pages
{
    public partial class SingupPage : Page
    {
        private ModelContext? _db = null;
        private User _user = new User();
        public SingupPage()
        {
            InitializeComponent();
            _db = new ModelContext();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text) || string.IsNullOrEmpty(TbPass.Password))
            {
                new ErrorWindow().ShowDialog();
            }
            else
            {
                try
                {
                    _user.Login = TbLogin.Text;
                    _user.Password = TbPass.Password;
                    _user.RoleID = 2;

                    new CongratsWindow().ShowDialog();

                    _db?.Users.Add(_user);
                    _db?.SaveChanges();

                    Core1.MyCore.Navigate(new MainPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Core1.MyCore.Navigate(new MainPage());
        }
    }
}
