using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    enum PastryTypes
    {
        puff,
        flaky,
        choux,
        filo
    }
    enum CreamTypes
    {
        coffee,
        whipping,
        clotted,
        chantilly
    }
    class Cakes
    {
        public string name;
        public PastryTypes pastry;
        public CreamTypes cream;

        public string Name { get; set; }
        public PastryTypes Pastry { get; set; }
        public CreamTypes Cream { get; set; }
        public Cakes(string name, PastryTypes pastry, CreamTypes cream)
        {
            this.name = name;
            this.pastry = pastry;
            this.cream = cream;
        }
    }
}
