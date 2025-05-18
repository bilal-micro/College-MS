using CollegeMS.Model;
using CollegeMS.Model.Data;
using CollegeMS.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMS.ViewModel
{
    public class StudentViewModel : ObservableObject
    {
        public static Student Student { get; set; }
        public List<Course> Courses { get; set; }
        public NavigationComand navigationComand { get; set; } = new NavigationComand();    
        public StudentViewModel()
        {
            Student = new Student()
            {
                id = 10,
                Name = "Belal",
                BirthDate = DateTime.Now,
                F_GPA = 3,
                ParentPhone = "01000",
                Email = "r.@gmai.com",
                Level = 1
            };
            _Courses.Add(new Course()
            {
                Name = "Test",
                CreditHour = 10
            });
        }
        public List<Course> _Courses
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
