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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingIntro2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student S1 = new Student();
        private Student S2 = new Student();

        public MainWindow()
        {
            InitializeComponent();

            S1.Leeftijd = 20;
            S1.Naam = "Fritske";

            S2.Leeftijd = 21;
            S2.Naam = "Bobke";

            //VOLGENDE REGEL LINKT EEN OBJECT AAN DE TEXTBOX! Anders weet deze niet welk object, klasse, ... aan hem gebind moet worden
            txbStudentInfo.DataContext = S1;
            txbStudentInfo.DataContext = S2;
        }

        private void btnSwap_Click(object sender, RoutedEventArgs e)
        {
            txbStudentInfo.DataContext = S2;
        }

        private void btnToonInfo_Click(object sender, RoutedEventArgs e)
        {
            S1.ToonInfo();
            S2.ToonInfo();
        }
    }
}
