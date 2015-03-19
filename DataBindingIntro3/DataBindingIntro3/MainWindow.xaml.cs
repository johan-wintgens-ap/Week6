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

namespace DataBindingIntro3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student S1 = new Student();
        private Student S2 = new Student();

        public ObservableCollection<Student> Studentenlijst { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            S1.Leeftijd = 20;
            S1.Naam = "Fritske";

            S2.Leeftijd = 21;
            S2.Naam = "Bobke";

            Studentenlijst = new ObservableCollection<Student>();
            Studentenlijst.Add(S1);
            Studentenlijst.Add(S2);

            lbStudenten.ItemsSource = Studentenlijst;
        }

        private void btnVoegStudentToe_Click(object sender, RoutedEventArgs e)
        {
            Studentenlijst.Add(new Student());
        }

        private void LbStudenten_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbStudenten.SelectedIndex >= 0)
            {
                (lbStudenten.SelectedItem as Student).Leeftijd++;
            }
        }

        private void buttonBase_Click(object sender, RoutedEventArgs e)
        {
            var stud = ((sender as FrameworkElement).DataContext as Student);
            stud.Leeftijd++;

        }
    }
}
