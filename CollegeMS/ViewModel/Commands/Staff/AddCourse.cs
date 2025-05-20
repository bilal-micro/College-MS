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
    public class AddCourse : ICommand
    {
        public event EventHandler CanExecuteChanged;

        StaffViewModel StaffViewModel { get; set; }
        public AddCourse(StaffViewModel staffViewModel)
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
                var x = StaffViewModel.course;
                if (x.Name == null || x.CreditHour == 0)
                {
                    return;
                }
                new CollegeMS.Model.Handlers.CourseDBHandler().Create(x);
                StaffViewModel._course = new Model.Data.Course();
                StaffViewModel.getCourses();
                MessageBoxShow.show("Course Created");
            }
            catch (Exception ex)
            {
                MessageBoxShow.show("Error");
                Logger.SaveLogger(ex.Message, "Course-Register");
            }
        }
    }
}
