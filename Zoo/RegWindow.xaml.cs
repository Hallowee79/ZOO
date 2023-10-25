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

namespace Zoo
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        List<string> listFilter = new List<string>()
        {
            "Ветеринар","Кормильщик","Зоолог","Охранник","Директор"
        };
        public RegWindow()
        {
            InitializeComponent();
            Cmb.ItemsSource = listFilter;
            Cmb.SelectedIndex = 0;
        }

        private void Authbutton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPhone.Text))
            {
                MessageBox.Show("Поле Телефон не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBEmail.Text))
            {
                MessageBox.Show("Поле Почта не заполнено");
            }
            if (string.IsNullOrWhiteSpace(TBLogin.Text))
            {
                MessageBox.Show("Заполните логин");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                MessageBox.Show("Заполните пароль");
                return;
            }

            Staff RegNewStaff = new Staff();
            RegNewStaff.Login = TBLogin.Text;
            RegNewStaff.Password = TBPassword.Text;
            RegNewStaff.FIO = TBLastName.Text;
            RegNewStaff.Phone = TBPhone.Text;
            if (R1.IsChecked == true)
            {
                RegNewStaff.GenderID = 1;
            }
            else
            {
                RegNewStaff.GenderID = 2;
            }
            RegNewStaff.Email = TBEmail.Text;
            RegNewStaff.BirthDay = Convert.ToDateTime(Data.Text);
            string a = Cmb.Text.ToString();
            var bb = Context.Position.ToList().Where(i => i.Title == a).FirstOrDefault();
            RegNewStaff.PositionID = bb.ID;
            RegNewStaff.Salary = Convert.ToInt32(Zp.Text);
            ClassHelper.EfClass.Context.Staff.Add(RegNewStaff);
            ClassHelper.EfClass.Context.SaveChanges();
            MessageBox.Show("Сотрудник успешно добавлен (Вальер в базе добавлять)");
        }

        private void NewRegistation_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }
    }
}
