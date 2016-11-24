using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplotDwochFunkcji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<TextBox> AWektor = new List<TextBox>();
        List<TextBox> XWektor = new List<TextBox>();
        List<TextBox> YWektor = new List<TextBox>();
        int sizeWektorA, sizeWektorX, sizeWektorY;
        int K, N;
        Wektor Wektor = new Wektor();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            myPanel.AutoScroll = false;
            myPanel.HorizontalScroll.Enabled = false;
            myPanel.HorizontalScroll.Visible = false;
            myPanel.HorizontalScroll.Maximum = 0;
            myPanel.AutoScroll = true;
            N_TB.Text = "3";
            K_TB.Text = "5";

        }


        #region tab1
        private void Filltab1(object sender, EventArgs e)
        {
            try
            {
                //sizeWektorA = Convert.ToInt32(N.Text);
                //sizeWektorX = Convert.ToInt32(N.Text);
                //sizeWektorY = Convert.ToInt32(K.Text);
                N = Convert.ToInt32(N_TB.Text);
                K = Convert.ToInt32(K_TB.Text);
                sizeWektorA = N;
                sizeWektorX = K;
                sizeWektorY = K;

                if (sizeWektorA >= 2 && sizeWektorX >= 2)//wektor min
                                                         //if (sizeWektorY >= sizeWektorAX + 2)
                    if (sizeWektorA < sizeWektorX)
                    {
                        UsunTextboxy();
                        StworzTextBoxy(sizeWektorA, sizeWektorX, sizeWektorY);
                        WyswietlTextboxy();
                    }
                    else throw new Exception("K<=N");
                else throw new Exception("wartości nie spełniają minimalnych wartości by utworzyc macierz");
            }
            catch (FormatException)
            {
                MessageBox.Show("Wartości wpisane jako K i N są błędne(błąd konwersji)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LiczEvent(object sender, EventArgs e)
        {
            bool x = true;
            for (int i = 0; i < AWektor.Count; i++)
            {
                if (AWektor[i].BackColor != Color.LightGreen)
                {
                    x = false;
                    break;
                }
            }
            for (int i = 0; i < XWektor.Count; i++)
            {
                if (XWektor[i].BackColor != Color.LightGreen)
                {
                    x = false;
                    break;
                }
            }

            if (x == false)
                MessageBox.Show("Dane nie są poprawne");
            else
            {
                Wektor.a.Clear();
                Wektor.x.Clear();
                Wektor.y.Clear();
                for (int i = 0; i < AWektor.Count; i++)
                    Wektor.a.Add(Convert.ToDouble(AWektor[i].Text));
                for (int i = 0; i < XWektor.Count; i++)
                    Wektor.x.Add(Convert.ToDouble(XWektor[i].Text));

                Wektor.Licz_SplotFunkcji(K, N);
                for (int i = 0; i < sizeWektorY; i++)
                {
                    YWektor[i].Text = Wektor.y[i].ToString();
                }
                FillListViewPolaczen();
            }
        }

        private void UsunTextboxy()
        {
            for (int i = 0; i < AWektor.Count; i++) AWektor[i].Dispose();
            for (int i = 0; i < XWektor.Count; i++) XWektor[i].Dispose();
            for (int i = 0; i < YWektor.Count; i++) YWektor[i].Dispose();
        }
        private void StworzTextBoxy(int countA, int countX, int countY)
        {
            for (int i = 0; i < countA; i++)
            {
                TextBox WektorA = new TextBox();
                WektorA.Name = "A" + i.ToString();
                WektorA.Text = WektorA.Name;
                WektorA.Size = new Size(30, 30);
                WektorA.Location = new Point(0, K_TB.Location.Y + K_TB.Height + i * 22);
                WektorA.TextChanged += Wektor_TextChanged;
                AWektor.Add(WektorA);
            }
            for (int i = 0; i < countX; i++)
            {
                TextBox WektorX = new TextBox();
                WektorX.Name = "X" + i.ToString();
                WektorX.Text = WektorX.Name;
                WektorX.Size = new Size(30, 30);
                WektorX.Location = new Point(myPanel.Width / 3 - 20, K_TB.Location.Y + K_TB.Height + i * 22);
                WektorX.TextChanged += Wektor_TextChanged;
                XWektor.Add(WektorX);
            }

            for (int i = 0; i < countY; i++)
            {
                TextBox WektorY = new TextBox();
                WektorY.Name = "Y" + i.ToString();
                WektorY.Text = WektorY.Name;
                WektorY.Size = new Size(30, 30);
                WektorY.Location = new Point(myPanel.Width / 3 * 2 - 20, K_TB.Location.Y + K_TB.Height + i * 22);
                YWektor.Add(WektorY);
            }
        }
        private void WyswietlTextboxy()
        {
            for (int i = 0; i < AWektor.Count; i++)
                myPanel.Controls.Add(AWektor[i]);
            for (int i = 0; i < XWektor.Count; i++)
                myPanel.Controls.Add(XWektor[i]);
            for (int i = 0; i < YWektor.Count; i++)
                myPanel.Controls.Add(YWektor[i]);
        }

        private void Wektor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble((sender as TextBox).Text);
                (sender as TextBox).BackColor = Color.LightGreen;
            }
            catch
            {
                (sender as TextBox).BackColor = Color.Red;
            }
        }
        #endregion
        public void FillListViewPolaczen()
        {
            textBox1.Visible = true;
            textBox1.Text = "";
            for (int i = 0; i < Wektor.y.Count; i++)
            {
                textBox1.Text += i + " " + Wektor.y[i].ToString() + Environment.NewLine;
            }
        }
    }
}
