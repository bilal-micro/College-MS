using CollegeMS.Model;
using CollegeMS.Views.window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CollegeMS.Model.ComponentModel;
using CollegeMS.ViewModel.Commands;

namespace CollegeMS.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        public static MainWindow MainWindow { get; set; }

        public List<MainWindowNavigation> MainWindowItemList { get; set; }
        public List<MainWindowNavigation> _MainWindowItemList
        {
            get { return MainWindowItemList; }
            set
            {
                if (value == null)
                    return;
                MainWindowItemList = value;
                OnPropertyChanged(nameof(MainWindowNavigation));
            }
        }

        public MainWindowViewModel()
        {
            _MainWindowItemList = new List<MainWindowNavigation>()
            {
                //new MainWindowNavigation("DashBoardManager",new NavigationService(this)),
                //new MainWindowNavigation("DashBoardStudent",new NavigationService(this)),
               // new MainWindowNavigation("DashBoardStaff",new NavigationService(this)),
                //new MainWindowNavigation("AddDoctor",new NavigationService(this)),
                //new MainWindowNavigation("AddStaff",new NavigationService(this)),
                //new MainWindowNavigation("AddStudent",new NavigationService(this)),
                //new MainWindowNavigation("AllStudents",new NavigationService(this)),
                //new MainWindowNavigation("AllDoctors",new NavigationService(this)),
                //new MainWindowNavigation("AllStaffs",new NavigationService(this)),
                //new MainWindowNavigation("DoctorData",new NavigationService(this)),
               // new MainWindowNavigation("StaffData",new NavigationService(this)),
                //new MainWindowNavigation("StudentData",new NavigationService(this)),
               // new MainWindowNavigation("AllCourses",new  NavigationService(this)),
               // new MainWindowNavigation("LogIn",new NavigationService(this)),
            };
        }

        internal void setContext(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
        }
    }
}
