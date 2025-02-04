using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Emberek
    {
        Random rnd = new Random();

        private List<Ember> emberek = new List<Ember>();

        public void EmberekLetrehoz(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Ember ember = new Ember(rnd.Next(50,100), rnd.Next(160, 190));
                emberek.Add(ember);
            }
        }

        public override string ToString()
        {
            string fejlec = string.Format("{0,-15}{1,-18}{2,-10}{3,-12}\n",
                                          "Testsúly(kg)", "Testmagasság(cm)", "TTI", "Testalkat");
            string elvalaszto = new string('-', 55) + "\n";
            string result = fejlec + elvalaszto;

            foreach (Ember ember in emberek)
            {
                result += string.Format("{0,-15:F1}{1,-18}{2,-10:F2}{3,-12}\n",
                                        ember.testSuly, ember.testMagassag, ember.TestTomegIndex(), ember.NormalTTI());
            }

            return result;
        }


        public double AvgSuly()
        {
            double avgSuly = 0;
            foreach (Ember ember in emberek)
            {
                avgSuly += ember.testSuly;
            }
            return avgSuly / emberek.Count;
        }

        public double AvgMagassag()
        {
            double avgMagassag = 0;
            foreach (Ember ember in emberek)
            {
                avgMagassag += ember.testMagassag;
            }
            return avgMagassag / emberek.Count;
        }
    }
}
