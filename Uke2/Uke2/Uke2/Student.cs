using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uke2
{
    internal class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string[] Kurs { get; set; }


        public Student(string navn, int alder, string[] kurs) {
            Navn = navn;
            Alder = alder;
            Kurs = kurs;
        }
    }
}
