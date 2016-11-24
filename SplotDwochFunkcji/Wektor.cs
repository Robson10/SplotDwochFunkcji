using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplotDwochFunkcji
{
    class Wektor
    {
        public List<double> a = new List<double>();
        public List<double> x = new List<double>();
        public List<double> y = new List<double>();
        public StringBuilder polaczenia = new StringBuilder();

        public Wektor() { }
        public void Licz_SplotFunkcji(int K, int N)
        {

            for (int i = 0; i < K; i++)
            {
                y.Add(0.0);
            }
            for (int h = 0; h < K; h++)
            {
                y[h] = 0;
                for (int j = 0; j < N; j++)
                {
                    if (h - j >= 0)
                    {
                        y[h] += a[j] * x[h - j];


                    }
                }
                MessageBox.Show(polaczenia.ToString());
                polaczenia.Clear();
            }
        }


    }
}
