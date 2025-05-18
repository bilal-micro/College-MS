using CollegeMS.Model;
using CollegeMS.Model.Data;
using CollegeMS.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMS.ViewModel
{
    public class DoctorViewModel : ObservableObject
    {
        public static Doctor doctor { get; set; }
        public NavigationComand navigationComand { get; set; } = new NavigationComand();
        public List<Student> students { get; set; }

        public DoctorViewModel()
        {
            _Students = new CollegeMS.Model.Handlers.StudentDBHandler().GetStudents();
        }
        public List<Student> _Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
                OnPropertyChanged(nameof(students));
            }
        }
    }
}
