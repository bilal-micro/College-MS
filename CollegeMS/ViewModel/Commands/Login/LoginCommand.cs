using CollegeMS.Model.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CollegeMS.Model.Data;
using CollegeMS.ViewModel.Commands;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;

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

            if (isAdmin(navigation, username, password))
            {
                return;
            }

            List<CollegeMS.Model.Data.Doctor> doctors = new DoctorDBHandler().GetAll();
            // micro1 123 doctor open page
            foreach (var doctor in doctors)
            {
                if ((doctor.Name == username))
                {
                    if ((doctor.Password == password))
                    {
                        navigation.NavigateToPage("DashBoardDoctor");
                        DoctorViewModel.doctor = doctor;
                    }
                }
            }

            List<CollegeMS.Model.Data.Staff> staffs = new StaffDBHandler().ReadAll();

            foreach (var staff in staffs)
            {
                if (staff.Name == username)
                {
                    if (staff.Password == password)
                    {
                        navigation.NavigateToPage("DashBoardStaff");

                    }
                }
            }
            List<CollegeMS.Model.Data.Student> stuendets = new StudentDBHandler().GetStudents();

            foreach (var student in stuendets)
            {
                if (student.Name == username)
                {
                    if (student.Password == password)
                    {
                        navigation.NavigateToPage("DashBoardStudent");
                        StudentViewModel.Student = student;
                    }
                }
            }
            List<CollegeMS.Model.Data.Manager> Managers = new ManagerDBHandler().GetAllManagers();

            foreach (var manager in Managers)
            {
                if (manager.Name == username)
                {
                    if (manager.Password == password)
                    {
                        navigation.NavigateToPage("DashBoardManager");
                    }
                }
            }
        }
    
        private bool isAdmin(NavigationService navigation, string username, string password)
        {
            if(username == "micro1" && password == "123")
            {
                DoctorViewModel.doctor = new Doctor()
                {
                    Name = username,
                    Password = password
                };
                navigation.NavigateToPage("DashBoardDoctor");
            }
            else if(username == "micro2" && password == "111")
            {
                navigation.NavigateToPage("DashBoardStaff");
            }
            else if(username == "micro3" && password == "222")
            {
                StudentViewModel.Student = new Model.Data.Student()
                {
                    Name = username,
                    Password = password
                };
                navigation.NavigateToPage("DashBoardStudent");
            }
            else if(username == "micro" && password == "333")
            {
                navigation.NavigateToPage("DashBoardManager");
            }
            else { return false; }
            return true;
        }
         
    }
}
