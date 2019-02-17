using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Test_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // List<string> autosalon;
        
        ObservableCollection<Car> carslist = new ObservableCollection<Car>();
        Car testCar;
        public MainWindow()
        {
            InitializeComponent();// привязка вводимых данных к таблице(грид)
            Autosalon.ItemsSource = carslist;

            testCar = null;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Car car1 = new Car();


            car1.Brand = Brand.Text;
            car1.Model = Model.Text;
            car1.Color = Color.Text;

            int res1; int res2; 
            bool isNumber1 = Int32.TryParse(Doors.Text, out res1);
            if (isNumber1)
            { car1.Doors = res1; }
            
            bool isNumber2 = Int32.TryParse(Power.Text, out res2);
            if (isNumber2)
            { car1.Power = res2; }
                       

            bool? Airbag = AirBag.IsChecked;
            bool? SportCar = Sport.IsChecked;
            bool? FamilyCar = Family.IsChecked;
           

            if (isNumber1 == true && isNumber2 == true )
            {
                carslist.Add(car1);
            }

            Brand.Text = "";
            Model.Text = "";
            Color.Text = "";
            Doors.Text = "";
            Power.Text ="";
            AirBag.IsChecked = true;
            Sport.IsChecked = true;
            Family.IsChecked = true;

        }

        

        

        

       

        private void Autosalon_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Autosalon.SelectedItem is Car carN)// переносит выбранные данные из грида в поля ввода
            {
                Brand.Text = carN.Brand;
                Model.Text = carN.Model;
                Color.Text = carN.Color;
                Doors.Text = carN.Doors.ToString();
                Power.Text = carN.Power.ToString();
                AirBag.IsChecked = carN.AirBag;
                Sport.IsChecked = carN.Sport;
                Family.IsChecked = carN.Family;
                testCar = carN;
            }
        }



        private void AirBag_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
        }

        private void Sport_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
        }

        private void Family_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Autosalon.SelectedItem is Car carN)
            {

                carslist.Remove(carN);
                Autosalon.SelectedItem = null;

                Brand.Text = "";
                Model.Text = "";
                Color.Text = "";
                Doors.Text = "";
                Power.Text = "";
                AirBag.IsChecked = false;
                Sport.IsChecked = false;
                Family.IsChecked = false;

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
    
