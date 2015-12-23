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

namespace _01DataBind
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Person pers = new Person();
        public MainWindow()
        {
            InitializeComponent();
        }

        //  在xaml文件中，在想要绑定数据的控件添加属性绑定，如 Text{Binding Name}  表示将当前控件的Text属性值与绑定的数据上下文的Name属性关联，即 Text=Name
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {           
            pers.Name = "赵四";
            pers.Age = 43;

            //  DataContexts属性表示绑定的数据上下文
            txtName.DataContext = pers;
            txtAge.DataContext = pers;

        }

        private void ageAddButton_Click(object sender, RoutedEventArgs e)
        {
            pers.Age++;
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pers.Age.ToString());
        }
    }
}
