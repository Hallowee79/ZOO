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

namespace Zoo
{
   
    public partial class MyRegYslWindow : Window
    {
        Entities entities = new Entities();
        public MyRegYslWindow()
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
            from hid in entities.Habitats
            join hibs in entities.Animals on hid.ID equals hibs.HabitatID join staff in entities.Species on hibs.SpiciesID equals staff.ID
            orderby staff.Name
            select new {Вальер = hid.Name,Тип_Вальера = hid.Type,Животное=staff.Name };
            DataGrid.ItemsSource = query.ToList();
        }
    }
}
