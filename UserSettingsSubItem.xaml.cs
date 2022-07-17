using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Settings.ViewModel;
using Settings.MenuItem;
using Settings;

namespace LightMisBank
{
    /// <summary>
    /// UserControlMenuItem.xaml 的交互逻辑
    /// </summary>
    public partial class UserSettingsSubItem : UserControl
    {
        UserSettings _context;
        public UserSettingsSubItem(Settings_ItemMenu itemMenu, UserSettings context)
        {
            InitializeComponent();
            _context = context;
            if (itemMenu.SubItems == null)
            {
                ExpanderMenu.Visibility = Visibility.Collapsed;
                ListViewItemMenu.Visibility = Visibility.Visible;
            }
            else
            {
                ExpanderMenu.Visibility = Visibility.Visible;
                ListViewItemMenu.Visibility = Visibility.Collapsed;
            }
            this.DataContext = itemMenu;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.SwitchScreen(((Settings_SubItem)((ListView)sender).SelectedItem).Screen);
            MessageBox.Show("Selection Changed", "Info", MessageBoxButton.OK);
        }
    }
}
