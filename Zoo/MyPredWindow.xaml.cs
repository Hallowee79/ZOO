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
using static Zoo.ClassHelper.Class;
using static Zoo.ClassHelper.Class1;
namespace Zoo
{
    /// <summary>
    /// Логика взаимодействия для MyPredWindow.xaml
    /// </summary>
    public partial class MyPredWindow : Window
    {
        Entities entities = new Entities();
        public MyPredWindow()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (b != 5)
            {
                var query =
                 from timF in entities.Time_Feeds
                join feed in entities.Feeds on timF.FeedID equals feed.ID
                 join hab in entities.Habitats on timF.HabitatsID equals hab.ID
                 join habS in entities.Habitats_Staff on hab.ID equals habS.HabitatsID
                 join staff in entities.Staff on habS.StaffID equals staff.ID
                 where staff.ID == a
                 orderby hab.Name
                select new { Время_Кормления = timF.Time, Вальер = hab.Name, Еда = feed.Type };

                DataGrid.ItemsSource = query.ToList();
            }
            else
            {
                var query =
                from timF in entities.Time_Feeds
                join feed in entities.Feeds on timF.FeedID equals feed.ID
                join hab in entities.Habitats on timF.HabitatsID equals hab.ID
                join habS in entities.Habitats_Staff on hab.ID equals habS.HabitatsID
                join staff in entities.Staff on habS.StaffID equals staff.ID
                orderby hab.Name
                select new { Время_Кормления = timF.Time, Вальер = hab.Name, Еда = feed.Type,Ответственный_За_Вальер = staff.FIO };

                DataGrid.ItemsSource = query.ToList();
            }

        }
    }
}
