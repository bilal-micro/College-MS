using CollegeMS.Model.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CollegeMS.Model.Data;
using CollegeMS.ViewModel.Commands;

namespace CollegeMS.ViewModel.Commands.Login
{
    public class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public LoginViewModel LoginViewModel { get; set; }
        public LoginCommand(LoginViewModel loginViewModel)
        {
            LoginViewModel = loginViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            
        }

        public void Execute(object parameter)
        {
            NavigationService navigation = new NavigationService();
            var username = this.LoginViewModel.userNmae;
            var password = this.LoginViewModel.password;

            List<CollegeMS.Model.Data.Doctor> doctors = new DoctorDBHandler().GetAll();
            // micro1 123 doctor open page
            foreach (var doctor in doctors)
            {
                if ((doctor.Name == username) || (username == "micro1"))
                {
                    if ((doctor.Password == password) || (password == "123"))
                    {
                        navigation.NavigateToPage("DashBoardDoctor");
                        DoctorViewModel.doctor = doctor;
                    }
                }
            }

            List<CollegeMS.Model.Data.Staff> staffs = new StaffDBHandler().ReadAll();

            foreach (var staff in staffs)
            {
                if (staff.Name == username || (username == "micro2"))
                {
                    if (staff.Password == password || (password == "111"))
                    {
                        navigation.NavigateToPage("DashBoardStaff");

                    }
                }
            }
            List<CollegeMS.Model.Data.Student> stuendets = new StudentDBHandler().GetStudents();

            foreach (var student in stuendets)
            {
                if (student.Name == username || (username == "mirco3"))
                {
                    if (student.Password == password|| (password == "222"))
                    {
                        navigation.NavigateToPage("DashBoardStudent");
                        StudentViewModel.Student = student;
                    }
                }
            }
            List<CollegeMS.Model.Data.Manager> Managers = new ManagerDBHandler().GetAllManagers();

            foreach (var manager in Managers)
            {
                if (manager.Name == username || (username == "micro"))
                {
                    if (manager.Password == password || (password == "333"))
                    {
                        navigation.NavigateToPage("DashBoardManager");
                    }
                }
            }
        }
    }
}
