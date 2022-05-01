using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Settings.MenuItem;
using Settings.ViewModel;

namespace LightMisBank
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserSettings : Window
    {
        public UserSettings()
        {
            InitializeComponent();

            var menuGeneral = new List<Settings_SubItem>();
            menuGeneral.Add(new Settings_SubItem("系统"));
            menuGeneral.Add(new Settings_SubItem("学科"));
            menuGeneral.Add(new Settings_SubItem("题库"));
            var item1 = new Settings_ItemMenu("基本", menuGeneral, PackIconKind.Register);

            var menuEnvironment = new List<Settings_SubItem>();
            menuEnvironment.Add(new Settings_SubItem("数据库"));
            menuEnvironment.Add(new Settings_SubItem("运行时"));
            menuEnvironment.Add(new Settings_SubItem("依赖库"));
            var item2 = new Settings_ItemMenu("环境", menuEnvironment, PackIconKind.Schedule);

            var menuAbout = new List<Settings_SubItem>();
            menuAbout.Add(new Settings_SubItem("开发信息"));
            menuAbout.Add(new Settings_SubItem("依赖组件"));
            menuAbout.Add(new Settings_SubItem("版本信息"));
            var item3 = new Settings_ItemMenu("关于", menuAbout, PackIconKind.FileReport);

            var menuSupport = new List<Settings_SubItem>();
            menuSupport.Add(new Settings_SubItem("技术支持"));
            menuSupport.Add(new Settings_SubItem("推动开发"));
            menuSupport.Add(new Settings_SubItem("为我捐赠"));
            var item4 = new Settings_ItemMenu("支持", menuSupport, PackIconKind.ShoppingBasket);

            Menu.Children.Add(new UserSettingsSubItem(item1, this));
            Menu.Children.Add(new UserSettingsSubItem(item2, this));
            Menu.Children.Add(new UserSettingsSubItem(item3, this));
            Menu.Children.Add(new UserSettingsSubItem(item4, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }
        private void SystemAboutButton_Click(object sender, RoutedEventArgs e)//设置按钮的操作事件
        {
            MessageBoxResult result = MessageBox.Show("LightMisBank v0.0.1-beta,for Windows\n基于 Microsoft .NET + SQLite 构建的轻量化错题管理软件\n目前软件未开发完成，还有很多工作要做！qwq", "关于系统", MessageBoxButton.OK);
        }
    }
}
