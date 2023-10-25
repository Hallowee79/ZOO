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
using static Zoo.ClassHelper.EfClass;
using static Zoo.ClassHelper.Class;
using static Zoo.ClassHelper.Class1;
namespace Zoo
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            if (b == 5)
            {
                Btn1.Content = "Время Кормления";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (b == 5)
            {
                MyPredWindow myPredWindow = new MyPredWindow();
                myPredWindow.Show();
                this.Hide();
            }
            else
            {
                MyDataWindow myDataWindow = new MyDataWindow();
                myDataWindow.Show();
                this.Hide();
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MyHistoryWindow myHistoryWindow = new MyHistoryWindow();
            myHistoryWindow.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyRegYslWindow myRegYslWindow = new MyRegYslWindow();
            myRegYslWindow.Show();
            this.Hide();
        }

        private void Btnpred_Click(object sender, RoutedEventArgs e)
        {
            if (b ==5)
            {
                DirectorWindow directorWindow = new DirectorWindow();
                directorWindow.Show();
                this.Hide();
            }
            else
            {
                MyPredWindow myPredWindow = new MyPredWindow();
                myPredWindow.Show();
                this.Hide();
            }
        }
    }
}
