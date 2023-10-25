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
    /// Логика взаимодействия для RegHabitatsWindow.xaml
    /// </summary>
    public partial class RegHabitatsWindow : Window
    {
        List<string> listFilter = new List<string>()
        {
            "Открытый вольер","Закрытый вольер"
        };
        public RegHabitatsWindow()
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
            Habitats NewHabitat = new Habitats();
            NewHabitat.Name = TBLastName.Text;
            NewHabitat.Type = Cmb.Text;
            ClassHelper.EfClass.Context.Habitats.Add(NewHabitat);
            ClassHelper.EfClass.Context.SaveChanges();
            MessageBox.Show("Вальер успешно добавлен");
        }

        private void NewRegistation_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow window1 = new DirectorWindow();
            window1.Show();
            this.Hide();
        }
    }
}
