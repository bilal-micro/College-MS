using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMS.Model.ComponentModel
{
    public class MainWindowNavigation
    {
        public string Content { get; set; }
        public object Command { get; set; }
        public MainWindowNavigation(string content, object command)
        {
            Content = content;
            Command = command;
        }
    }
}
