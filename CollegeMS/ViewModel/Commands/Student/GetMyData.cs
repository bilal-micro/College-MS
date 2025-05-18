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
    internal class GetMyDataStudent : ICommand
    {
        public event EventHandler CanExecuteChanged;
        StudentViewModel StudentViewModel { get; set; }
        public GetMyDataStudent(StudentViewModel studentViewModel)
        {
            StudentViewModel = studentViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CollegeMS.Model.Data.Student st = new StudentDBHandler().GetStudentById(StudentViewModel.Student.id);

        }
    }
}
