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
namespace Zoo
{
    /// <summary>
    /// Логика взаимодействия для MyHistoryWindow.xaml
    /// </summary>
    public partial class MyHistoryWindow : Window
    {
        Entities entities = new Entities();

        public MyHistoryWindow()
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
            var query =
            from animal in entities.Animals join feed in entities.Feeds on animal.FeedsID equals feed.ID join spec in entities.Species on animal.SpiciesID equals spec.ID
            orderby animal.Name
            select new { Имя = animal.Name, Возраст = animal.Age, Корм = feed.Type, Animal = spec.Name,Вид=spec.Description };

            DataGrid.ItemsSource = query.ToList();
        }
    }
}
