using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Settings.ViewModel;

namespace Settings.MenuItem
{
    public class Settings_ItemMenu
    {
        public Settings_ItemMenu(string header, List<Settings_SubItem> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
        }

        public string Header { get; private set; }
        public PackIconKind Icon { get; private set; }
        public List<Settings_SubItem> SubItems { get; private set; }
        public UserControl Screen { get; private set; }
    }
}