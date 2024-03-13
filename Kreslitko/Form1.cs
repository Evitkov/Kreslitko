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

        //nástroj pro kreslení
        enum enTools { Line, Box, Circle};
        enTools menActualTool;
        bool mblImDrawing=false;
        //barvy kreslení
        Color mobjForeColor;
        Color mobjBackColor;

        //souradnice kresleneho objektu
        Point mobjDrawingCoordsStart;
        Point mobjDrawingCoordsEnd;
        public Form1()
        {
            InitializeComponent();

            //nastavení proměnných
            menActualTool = enTools.Line;
            mobjForeColor = Color.Black; 
            mobjBackColor = Color.White;   
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

        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //test na levé tlačítko
                if (e.Button == MouseButtons.Left)
                {
                    //zaznamenat souřadnice
                    mobjDrawingCoordsStart.X = e.X;
                    mobjDrawingCoordsStart.Y = e.Y;

                    //kreslím
                    mblImDrawing = true;
                }
               
            }
            catch (Exception ex)
            {
                mblImDrawing = false;
            }
        }

        private void pbPlatno_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                //test na levé tlačítko
                if (e.Button == MouseButtons.Left)
                {
                    //zaznamenat souřadnice
                    mobjDrawingCoordsEnd.X = e.X;
                    mobjDrawingCoordsEnd.Y = e.Y;

                    //Nakresli
                    NakresliObjekt();

                    //kreslím
                    mblImDrawing = true;
                }

            }
            catch (Exception ex)
            {
                mblImDrawing = false;
            }
        }
        private void NakresliObjekt()
        {
            try
            {
                Pen lobjPero;
                //vybrat co kreslím
                switch(menActualTool)
                {
                    case enTools.Line:
                        //nastavit pero
                        lobjPero = new Pen(mobjForeColor);
                        //nakresli čáru
                        mobjGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void pnColor_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Panel lobjPanel;

                //nastavit kdo ,i to posílá
                lobjPanel = (Panel)sender;

                //nastavit správnou barvu
                if (e.Button == MouseButtons.Left)
                {
                    //zobrazit
                    pnForeColor.BackColor = lobjPanel.BackColor;
                    //zapsat
                    mobjForeColor = lobjPanel.BackColor;
                }

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
