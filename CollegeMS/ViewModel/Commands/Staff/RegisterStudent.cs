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
    public class RegisterStudent : ICommand
    {
        public event EventHandler CanExecuteChanged;
        StaffViewModel StaffViewModel { get; set; }
        public RegisterStudent(StaffViewModel staffViewModel)
        {
            StaffViewModel = staffViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try { 
                var x = StaffViewModel.Student;
                if (x.Name == null || x.Email == null || x.ParentPhone == null || x.BirthDate == null || x.Password == null)
                {
                    MessageBoxShow.show("Null Data");
                    return;
                }

                new CollegeMS.Model.Handlers.StudentDBHandler().CreateStudent(x);
                StaffViewModel._Student = new Model.Data.Student();
                StaffViewModel.getStudents();
                MessageBoxShow.show("Studnet Registerd");
            }
            catch (Exception ex)
            {
                MessageBoxShow.show("Error");
                Logger.SaveLogger(ex.Message, "Student-Register");
            }
}
    }
}
