using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingIntro3
{
    public class Student
    {
        public Student()
        {
            DeComputer = new List<Computer>();
            DeComputer.Add(new Computer(){Merk = "apple", Opslag = 10});
            DeComputer.Add(new Computer(){Merk = "PC", Opslag = 12});
        }

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        List<Computer> DeComputer { get; set; }

        public string LogoUrl { get { return "http://cdn-img.easyicon.net/png/5008/500805.png"; } }

        public void ToonInfo()
        {
            MessageBox.Show(Naam + " " + Leeftijd);
        }
    }

    public class Computer
    {
        public string Merk { get; set; }
        public int Opslag { get; set; }
    }
}
