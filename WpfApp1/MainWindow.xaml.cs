using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> zametki_nov;
        public MainWindow()
           
        {
            InitializeComponent();
            zametki_nov = new ObservableCollection<string>() { };
            
            
           
        }
       

         
            
       
    

        private void Button_Click_2(object sender, EventArgs e)
        {






        }

        private void Listt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = Listt.SelectedItem as string;
            string selected_1 = Listt.SelectedItem as string;

            Nazvanie.Text = selected;
            Opisane.Text = selected_1;
            switch (selected)
            {
                case "Сходить в Трон Приливов":
                    Opisane.Text = "Ретри паладин никому не нужен";
                    break;
                case "поделать че-нмть по дому":
                    Opisane.Text = "Пропылесосить, загрузить посуду в посудомоичною машину, разгрузить посудомоичную машину, вытереть пыль";
                    break;
                case " ":
                    Opisane.Text = Opisane.Text;
                    break;
                case "Поделать че нить":
                    Opisane.Text ="Поиграй во че-нить там вов или ск2 или ваху";
                    break;
                case "Заняться делом":
                    Opisane.Text = "Там куча практических на неделю задали, их бы сделать";
                    break;
                case "Сходить на пары":
                      Opisane.Text= " Основы алгоритмизации и программирования и Информационные технологии на 3 и 4 пары";
                    break;



            }

        }  






        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string zametka = Nazvanie.Text;
            zametki_nov.Add(zametka);

            
                
           

        
                

           
        }

        private void Nazvanie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Opisane_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private  void Dataa_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(Dataa.Text);

            DateTime date_1 = new DateTime(2024, 02, 12);
            DateTime date_2 = new DateTime(2024, 02, 13);
            DateTime date_3 = new DateTime(2024, 02, 14);
            if (date == date_1)
            {
                zametki_nov = new ObservableCollection<string>() { "Сходить в Трон Приливов", "поделать че-нмть по дому" };
                Listt.ItemsSource = zametki_nov;
                string json = JsonConvert.SerializeObject(zametki_nov);
                File.WriteAllText("D:\\Рабочий стол\\R3.json", json);







            }
            else if (date == date_2)
            {
                zametki_nov = new ObservableCollection<string>() { "Поделать че нить"  , "Заняться делом"};
                Listt.ItemsSource = zametki_nov;
                string json = JsonConvert.SerializeObject(zametki_nov);
                File.WriteAllText("D:\\Рабочий стол\\R2.json", json);
            }
            else if (date == date_3)
            {
                zametki_nov = new ObservableCollection<string>() { "Сходить на пары" ,  };
                Listt.ItemsSource = zametki_nov;
                string json = JsonConvert.SerializeObject(zametki_nov);
                File.WriteAllText("D:\\Рабочий стол\\R1.json", json);
            }



        }

        private void Dlzamet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Listt.Items.Clear();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(zametki_nov);
            File.WriteAllText("D:\\Рабочий стол\\R.json", json);
        }
    }
}


