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
    /// Логика взаимодействия для MyDataWindow.xaml
    /// </summary>
    public partial class MyDataWindow : Window
    {
        public MyDataWindow()
        {
            InitializeComponent();
            GetListService();
        }
        private void GetListService()
        {
            var sta = Context.Staff.ToList();
            var sotr = sta.FirstOrDefault(i => (i.ID == a));
            FIO.Text = sotr.FIO;
            Birthday.Text = sotr.BirthDay.ToString();
            Phone.Text = sotr.Phone.ToString();
            if (sotr.GenderID == 1)
            {
                Gender.Text = "Мужчина";
            }
            else
            {
                Gender.Text = "Женщина";
            }
            var pp = Context.Habitats_Staff.ToList().Where(i => i.StaffID == a).FirstOrDefault();
            int d = pp.HabitatsID;
            var gg = Context.Habitats.ToList().Where(i => i.ID == d).FirstOrDefault();
            Addres.Text = gg.Name.ToString();
            EMail.Text = sotr.Email.ToString();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Hide();
        }
    }
}
