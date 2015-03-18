using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingIntro2
{
    class Student
    {
        public Student()
        {
            deComputer.Merk = "Pear";
            deComputer.Opslag = 500;
        }

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Computer deComputer { get; set; }

        public void ToonInfo()
        {
            MessageBox.Show(Naam + " " + Leeftijd);
        }
    }

    class Computer
    {
        public string Merk { get; set; }
        public int Opslag { get; set; }
    }
}
