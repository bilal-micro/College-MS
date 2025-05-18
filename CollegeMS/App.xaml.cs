using CollegeMS.Views.window;
using CollegeMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CollegeMS.Model.Handlers;

namespace CollegeMS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);
            /*
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            if (principal.IsInRole(WindowsBuiltInRole.Administrator) == false && principal.IsInRole(WindowsBuiltInRole.User) == true)
            {
                ProcessStartInfo objProcessInfo = new ProcessStartInfo();
                objProcessInfo.UseShellExecute = true;
                objProcessInfo.FileName = Assembly.GetEntryAssembly().CodeBase;
                objProcessInfo.UseShellExecute = true;
                objProcessInfo.Verb = "runas";
                try
                {
                    Process proc = Process.Start(objProcessInfo);
                    Application.Current.Shutdown();
                }
                catch (Exception ex)
                {
                }
            }*/
            CollegeMS.Views.window.MainWindow mainWindow = new CollegeMS.Views.window.MainWindow();
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindow.DataContext = mainWindowViewModel;
            mainWindowViewModel.setContext(mainWindow);
            var login = new CollegeMS.View.Pages.Login();
            mainWindow.Frame.NavigationService.Navigate(login);

            new DoctorDBHandler();
            new StaffDBHandler();
            new StudentDBHandler();
            new ManagerDBHandler();

            mainWindow.Show();
        }
    }
}
