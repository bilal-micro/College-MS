using CollegeMS.Model.ComponentModel;
using CollegeMS.Model.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollegeMS.ViewModel.Commands.Staff
{
    public class RegisterDoctor : ICommand
    {
        public event EventHandler CanExecuteChanged;

        StaffViewModel StaffViewModel { get; set; }
        public RegisterDoctor(StaffViewModel staffViewModel)
        {
            StaffViewModel = staffViewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                var x = StaffViewModel.doctor;
                if (x.Course == null || x.Email == null || x.Name == null || x.BirthDate == null || x.Password == null)
                {
                    MessageBoxShow.show("Null Data");
                    return;
                }
                new CollegeMS.Model.Handlers.DoctorDBHandler().Create(x);
                StaffViewModel._doctor = new Model.Data.Doctor();
                StaffViewModel.getDoctors();
                MessageBoxShow.show("Doctor Registerd");
            }
            catch (Exception ex)
            {
                MessageBoxShow.show("Error");
                Logger.SaveLogger(ex.Message, "Doctor-Register");
            }

        }
    }
}
