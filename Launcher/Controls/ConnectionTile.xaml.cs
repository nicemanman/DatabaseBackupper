using Launcher.Models;
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

namespace Launcher.Controls
{
    /// <summary>
    /// Interaction logic for ConnectionTile.xaml
    /// </summary>
    public partial class ConnectionTile : UserControl
    {
        /// <summary>
        /// Заголовок подключения
        /// </summary>
        public string ConnectionTitle
        {
            get { return (string)GetValue(ConnectionTitleProperty); }
            set { SetValue(ConnectionTitleProperty, value); }
        }

        public static readonly DependencyProperty ConnectionTitleProperty =
            DependencyProperty.Register("ConnectionTitle", typeof(string), typeof(ConnectionTile));

        /// <summary>
        /// Имя пользователя в подключении
        /// </summary>
        public string ConnectionUserName
        {
            get { return (string)GetValue(ConnectionUserNameProperty); }
            set { SetValue(ConnectionUserNameProperty, value); }
        }

        
        public static readonly DependencyProperty ConnectionUserNameProperty =
            DependencyProperty.Register("ConnectionUserName", typeof(string), typeof(ConnectionTile));

        /// <summary>
        /// Адрес подключения
        /// </summary>
        public string ConnectionAddress
        {
            get { return (string)GetValue(ConnectionAddressProperty); }
            set { SetValue(ConnectionAddressProperty, value); }
        }

       
        public static readonly DependencyProperty ConnectionAddressProperty =
            DependencyProperty.Register("ConnectionAddress", typeof(string), typeof(ConnectionTile));


        public ConnectionTile(ConnectionModel connection)
        {
            InitializeComponent();
            ConnectionTitle = connection.Title;
            ConnectionUserName = connection.UserName;
            ConnectionAddress = connection.Address;
        }
    }
}
