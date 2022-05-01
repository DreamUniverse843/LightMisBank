using System;
using System.Data.SQLite;
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
using BroadcastEvents;
using Base64space;
using DBUtility.SQLite;

namespace Base64space//密码传入数据库时的 Base64 加密空间
{
    public class Base64
    {
        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="codeName">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string EncodeBase64(Encoding encode, string source)
        {
            byte[] bytes = encode.GetBytes(source);
            string res = string.Empty;
            try
            {
                res = Convert.ToBase64String(bytes);
            }
            catch
            {
                res = source;
            }
            return res;
        }

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string EncodeBase64(string source)
        {
            return EncodeBase64(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(Encoding encode, string result)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(string result)
        {
            return DecodeBase64(Encoding.UTF8, result);
        }
    }
}
namespace BroadcastEvents
{
    using static LightMisBank.Config;
    public delegate void EventDelegate(string msg);//初始化事件委托
    public class EventSend ///所有操作事件的发送方
    {
        public event EventDelegate DoUserLoginFinished;//用户登录完成时的委托事件
        //
        public void OnDoUserLoginFinished(string msg)//用户登录完成时的处理方法
        {
            if (DoUserLoginFinished != null)
                DoUserLoginFinished(msg);
        }
        public void DoUserLogin(string username, string passwd)//用户登录传入操作的处理方法，请求交给数据库获取用户信息
        {
            MessageBoxResult result = MessageBox.Show("input username is " + username + "\n password is " + passwd,"Info",MessageBoxButton.OKCancel);//调试用，获取用户名密码信息
            SQLiteConnection sql = new SQLiteConnection(SQLPath);//实例化数据库连接器，SQLPath 在 Config.cs 里
            sql.Open();//连接数据库
            SQLiteCommand LoginQueryCommand = sql.CreateCommand();//实例化数据库查询命令
            LoginQueryCommand.CommandText = new string("SELECT * FROM 'main'.'Users' WHERE Username='"+username+"' and Password='"+passwd+"';");//查询对应的用户名密码组合是否存在

            if (0 == Convert.ToInt32(LoginQueryCommand.ExecuteScalar()))//取返回值首列，如非零则存在，反之不存在。
            {
                //table - 表返回不存在
                MessageBox.Show("input username " + username + " don't exist.", "Info", MessageBoxButton.OK);

            }
            else
            {
                //table - 表返回存在
                MessageBox.Show("input username " + username + " exist.", "Info", MessageBoxButton.OK);
            }

        }
        public void DoVerifyUserExist(string username)//验证用户名是否存在（用于注册时验证)
        {

        }
    }
    public class EventReceive//所有操作事件的接收方
    {
        public static void Send_DoUserLoginFinished(string msg)
        {
            Console.WriteLine("UserLogin Finished");
        }
    }
}
namespace LightMisBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(userNameInput.Text != String.Empty)
            {
                UsernameNoNullLabel.Visibility = Visibility.Collapsed;
            }
            else
            {
                UsernameNoNullLabel.Visibility = Visibility.Visible;
            }
        }

        
        private void userLoginButton_Click(object sender, RoutedEventArgs e)//登录按钮的操作事件
        {
            if (userNameInput.Text == String.Empty)
            {
                UsernameNoNullLabel.Visibility = Visibility.Collapsed;
                MessageBoxResult result = MessageBox.Show("用户名不能为空。", "提示", MessageBoxButton.OK);
            }
            else if (userPasswordInput.Password == String.Empty)
            {
                UsernameNoNullLabel.Visibility = Visibility.Collapsed;
                MessageBoxResult result = MessageBox.Show("密码不能为空。", "提示", MessageBoxButton.OK);
            }
            else
            {
                EventSend Send = new EventSend();//创建事件发送的实例
                Send.DoUserLoginFinished += new EventDelegate(EventReceive.Send_DoUserLoginFinished);//将
                Send.DoUserLogin(userNameInput.Text, Base64.EncodeBase64(userPasswordInput.Password));
            }
        }
        private void userRegisterButton_Click(object sender, RoutedEventArgs e)//注册按钮的操作事件
        {
            if (userNameInput.Text == String.Empty)
            {
                UsernameNoNullLabel.Visibility = Visibility.Collapsed;
                MessageBoxResult result = MessageBox.Show("用户名不能为空。", "提示", MessageBoxButton.OK);
            }
            else if (userPasswordInput.Password == String.Empty)
            {
                UsernameNoNullLabel.Visibility = Visibility.Collapsed;
                MessageBoxResult result = MessageBox.Show("密码不能为空。", "提示", MessageBoxButton.OK);
            }
            else
            {
                
            }
            
        }
        private void SystemSettingsButton_Click(object sender, RoutedEventArgs e)//设置按钮的操作事件
        {
            UserSettings settings = new UserSettings();
            settings.ShowDialog();
        }
    }
}
