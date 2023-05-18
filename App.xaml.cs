using Microsoft.EntityFrameworkCore.Infrastructure;
using SI_SQL55.Model;
using System.Windows;

namespace SI_SQL55
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();
            DatabaseFacade facade = new DatabaseFacade(new ModelContext());


            facade.EnsureCreated();
        }
    }
}
