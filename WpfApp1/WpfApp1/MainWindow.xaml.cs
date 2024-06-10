using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
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
        int steps = 0;
        int points = 0;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(radio1.IsChecked == true)
            {

            }
            switch (steps)
            {
                case 0:
                    label1.Content = "Jakie zwierze powinno być na siłowni:";
                    radio1.Content = "Pies";
                    radio2.Content = "Małpka";
                    radio3.Content = "Kot";
                    steps++;
                    break;
                    
                case 1:
                    if (radio2.IsChecked == true)
                    {
                        points++;
                    }
                    break;
                    
                case 2:
                    if (radio2.IsChecked == true) 
                    {
                        points++;
                    }
                    break;
                    

            }
            steps++;
            //if(kfd.IsChecked == true && psy.IsChecked == true && koty.IsChecked == false && iguany.IsChecked == false && malpka.IsChecked == true && takWoda.IsChecked == true && pPTak.IsChecked == true && nogiNie.IsChecked == true) {
            //    MessageBox.Show("Brawo wszystkie odpowiedzi są poprawne");
            //}
            //else
            //{
            //    MessageBox.Show("NIEPOPRAWNIE UDZIELIŁEŚ ODPOWIEDZI -.-");
            //}

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void malpka_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}