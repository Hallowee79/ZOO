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


    public partial class RegAnimalWindow : Window
    {
        List<string> ListVid = new List<string>()
        {
            "Лев","Тигр","Слон","Жираф","Панда","Медведь","Змея","Рыба","Крокодил","Коала","Кенгуру","Пингвин","Волк","Белка","Лисица","Олень","Заяц","Бобер","Тюлень","Кит","Дельфин","Морж","Лемур","Муравьед","Норка","Осел","Пума","Слоновая сурок","Тукан","Уж","Фенек","Хорёк","Цесарка","Черепаха","Шимпанзе","Эму","Южноамериканский лось","Ягуар","Антилопа","Бобр","Гиппопотам","Енот","Жаба","Зубр","Индюк","Крыса","Анаконда","Баран", "Вомбат","Горилла","Дикобраз","Енотовидная собака","Индейка"
        };
        List<string> ListCorm = new List<string>()
        {
            "Мясо","Рыба","Сено","Бамбук","Фрукты"
        };
        List<string> ListValier = new List<string>()
        {
            "Африканская саванна","Лесной вольер","Экваториальный лес","Саванна","Горный вольер"
        };
        public RegAnimalWindow()
        {
            InitializeComponent();
            CmbVal.ItemsSource = ListValier;
            CmbVal.SelectedIndex = 0;
            TBPhone.ItemsSource = ListVid;
            TBPhone.SelectedIndex = 0;
            CmbKorm.ItemsSource = ListCorm;
            CmbKorm.SelectedIndex = 0;
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

            Animals AddAnimal = new Animals();
            AddAnimal.Name = TBLastName.Text;
            string a= TBPhone.Text;
            string c = CmbVal.Text;
            string d = CmbKorm.Text;
            AddAnimal.Age = Convert.ToInt32(TBAge.Text);
            if (R1.IsChecked == true)
            {
                AddAnimal.GenderID = 1;
            }
            else
            {
                AddAnimal.GenderID = 2;
            }
            var b = Context.Species.ToList().Where(i => i.Name == a).FirstOrDefault();
            var bb = Context.Habitats.ToList().Where(i => i.Name == c).FirstOrDefault();
            var bbb = Context.Feeds.ToList().Where(i => i.Type == d).FirstOrDefault();
            int bbbb = b.ID;
            int bbbbb = bb.ID;
            int bbbbbb = bbb.ID;
            AddAnimal.SpiciesID = bbbb;
            AddAnimal.HabitatID = bbbbb;
              AddAnimal.FeedsID = bbbbbb;
            ClassHelper.EfClass.Context.Animals.Add(AddAnimal);
            ClassHelper.EfClass.Context.SaveChanges();
            MessageBox.Show("Животное успешно добавлен");
        }

        private void NewRegistation_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow window1 = new DirectorWindow();
            window1.Show();
            this.Hide();
        }
    }
    
}
