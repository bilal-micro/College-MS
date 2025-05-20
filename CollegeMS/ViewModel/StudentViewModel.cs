using CollegeMS.Model;
using CollegeMS.Model.ComponentModel;
using CollegeMS.Model.Data;
using CollegeMS.Model.Handlers;
using CollegeMS.ViewModel.Commands;
using CollegeMS.ViewModel.Commands.Student;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMS.ViewModel
{
    public class StudentViewModel : ObservableObject
    {
        public static Student Student { get; set; }
        public ObservableCollection<Course> Courses { get; set; }
        public ObservableCollection<GPATableCalculation> GPATables { get; set; }
        public NavigationComand navigationComand { get; set; } = new NavigationComand();    
        public CalculateGPA CalculateGPA { get; set; }
        public StudentViewModel()
        {
            this.CalculateGPA = new CalculateGPA(this);
            getMyLevelCourses();
        }
        public void getMyLevelCourses()
        {
            _Courses = new ObservableCollection<Course>(new CourseDBHandler().GetByLevel(Student.Level));
        }
        public ObservableCollection<GPATableCalculation> _GPATables
        {
            get
            {
                return GPATables;
            }
            set
            {
                GPATables = value;
                OnPropertyChanged(nameof(GPATables));
            }
        }
        public ObservableCollection<Course> _Courses
        {
            get { return Courses; }
            set
            {
                Courses = value;
                OnPropertyChanged(nameof(Courses));
            }
        }
    }
}
