using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Ember
    {
        public double testSuly { get; set; }
        public int testMagassag {  get; set; }

        public Ember(double Suly, int Magassag)
        {
            testSuly = Suly;
            testMagassag = Magassag;    
        }

        public override string ToString()
        {
            return $"{testSuly}kg\t {testMagassag}cm";
        }

        public double TestTomegIndex()
        {
            return Math.Round(testSuly / ((testMagassag / 100) ^ 2), 2);
        }

        public bool NormalTTI()
        {
            return TestTomegIndex() < 25 && TestTomegIndex() >= 18.5;
        }

    }
}
