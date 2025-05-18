using CollegeMS.Model.Data;
using CollegeMS.Model.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollegeMS.ViewModel.Commands.Student
{
    internal class GetMyCourses : ICommand
    {
        public event EventHandler CanExecuteChanged;
        StudentViewModel StudentViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            List<CollegeMS.Model.Data.Course> courses1 = new CourseDBHandler().GetAll();

            StudentViewModel._Courses = courses1;
        }
    }
}
