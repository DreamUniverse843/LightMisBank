using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Settings.ViewModel
{
    public class Settings_SubItem
    {
        public Settings_SubItem(string name,string clickActionEvent)
        {
            ActionEvent = clickActionEvent;//对应控件的点击事件传递
            Name = name;
            UserControl Screen = new UserControl();
            Screen.Name = Name;
        }
        public string Name
        { 
            get; 
            private set;
        }
        public UserControl Screen
        { 
            get;
            private set; 
        }
        public string ActionEvent
        {
            get;
            private set;
        }
    }
}