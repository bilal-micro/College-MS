using CollegeMS.Model;
using CollegeMS.Model.Data;
using CollegeMS.ViewModel.Commands;
using CollegeMS.ViewModel.Commands.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMS.ViewModel
{
    public class ManagerViewModel : ObservableObject
    {
    
        public NavigationComand navigationComand { get; set; } = new NavigationComand();

        public List<Staff> Staffs { get; set; }
        public Staff staff { get; set; }
        public RegisterStaff RegisterStaff { get; set; }
        public ManagerViewModel()
        {
            _Staff = new CollegeMS.Model.Handlers.StaffDBHandler().ReadAll();
            RegisterStaff = new RegisterStaff(this);
            staff = new Staff();
        }

        public List<Staff> _Staff
        {
            get
            {
                return Staffs;
            }
            set
            {
                Staffs = value;
                OnPropertyChanged(nameof(Staffs));
            }
        }
    }
}
