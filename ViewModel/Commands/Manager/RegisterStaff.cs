using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollegeMS.ViewModel.Commands.Manager
{
    public class RegisterStaff : ICommand
    {
        public event EventHandler CanExecuteChanged;

        ManagerViewModel ManagerViewModel { get; set; }
        public RegisterStaff(ManagerViewModel managerViewModel)
        {
            ManagerViewModel = managerViewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var x = ManagerViewModel.staff;
            if (x.Name == null || x.Email == null || x.Name == null || x.BirthDate == null || x.Password == null)
            {
                return;
            }
            new CollegeMS.Model.Handlers.StaffDBHandler().Create(x);
            ManagerViewModel.staff = new Model.Data.Staff();
        }
    }
}
