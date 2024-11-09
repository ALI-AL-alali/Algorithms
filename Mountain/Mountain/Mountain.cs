using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountain
{

    class Mountains
    {
        public double Hight { get; set; }
        public string Name { get; set; }
        public string Countre { get; set; }
        public Mountains() { }
        public Mountains(double hight)
        {
            Hight = hight;
        }
        public Mountains(string name)
        {
            Name = name;
        }
        public Mountains(string name, string countre, double hight)
        {
            Name = name;
            Countre = countre;
            Hight = hight;
        }
    } 

}
