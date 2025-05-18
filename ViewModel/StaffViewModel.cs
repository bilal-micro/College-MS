using CollegeMS.Model;
using CollegeMS.Model.Data;
using CollegeMS.ViewModel.Commands;
using CollegeMS.ViewModel.Commands.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMS.ViewModel
{
    public class StaffViewModel : ObservableObject
    {
        public List<Doctor> Doctors { get; set; }
        public List<Student> students { get; set; }
        public RegisterDoctor RegisterDoctor { get ; set; }
        public RegisterStudent RegisterStudent  { get ; set; }
        public NavigationComand navigationComand { get; set; } = new NavigationComand();
        public AddCourse AddCourse {  get; set; }
        public Course course {  get; set; }
        public StaffViewModel()
        {
            _Doctors = new CollegeMS.Model.Handlers.DoctorDBHandler().GetAll();
            _Students = new CollegeMS.Model.Handlers.StudentDBHandler().GetStudents();
            RegisterDoctor = new RegisterDoctor(this);
            RegisterStudent = new RegisterStudent(this);
            AddCourse = new AddCourse(this);
            doctor = new Doctor();
            Student = new Student();
            course = new Course();
        }
        public Doctor doctor { get; set; }
        public Student Student { get; set; }
        public List<Doctor> _Doctors
        {
            get
            {
                return Doctors;
            }
            set
            {
                Doctors = value;
                OnPropertyChanged(nameof(Doctors));
            }
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
