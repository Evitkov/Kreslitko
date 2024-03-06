using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreslitko
{
    public partial class Form1 : Form
    {
        // kreslící objekt Grafiky
        Graphics mobjGrafika;
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------
        // nahrání okna do paměti
        //---------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //vytvoření grafiky 
            mobjGrafika = pbPlatno.CreateGraphics();
        }
        //
        // testovací tlačítko
        //
        private void button1_Click(object sender, EventArgs e)
        {
            mobjGrafika.DrawLine(Pens.Black, 10, 10, 100, 100);
            // 80,80 - počátek ; 20 šířka obrysového obdelníku; 30 výška obrys obdelníku
            mobjGrafika.FillEllipse(Brushes.Cyan, 80, 80, 20, 30);
        }
        //
        // pohyb myši nad pictureboxem
        //
        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //souřadnice myši do statusu
                tsMysSouradnice.Text = "x:" + e.X.ToString() + "y:" + e.Y.ToString();
            }
            catch (Exception ex)
            { 
            
            }

        }

    }
}
