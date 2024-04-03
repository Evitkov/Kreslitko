using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        // kreslící objekt v paměti
        Bitmap mobjBitmap;
        Graphics mobjGrafikaVRam;
        //nástroj pro kreslení
        enum enTools { Line, Rectangle, Elipse, Pen};
        enTools menActualTool;
        bool mblImDrawing=false;
        //barvy kreslení
        Color mobjForeColor;
        Color mobjBackColor;

        //souradnice kresleneho objektu
        Point mobjDrawingCoordsStart;
        Point mobjDrawingCoordsEnd;
        Point mobjDrawingCoords1;
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
            //vytvoření grafiky na oozadí
            mobjBitmap= new Bitmap (pbPlatno.Width, pbPlatno.Height);
            mobjGrafikaVRam = Graphics.FromImage(mobjBitmap);
            mobjGrafikaVRam.Clear(Color.White);
        }
        //
        // testovací tlačítko
        //
        private void btVymazat_Click(object sender, EventArgs e)
        {
            pbPlatno.Image = null;
            mobjBitmap = null;
        }
        //
        // pohyb myši nad pictureboxem
        //
        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            Pen lobjPero;
            lobjPero = new Pen(mobjForeColor);
            try
            {
                //souřadnice myši do statusu
                tsMysSouradnice.Text = "x:" + e.X.ToString() + "y:" + e.Y.ToString();
                if (e.Button == MouseButtons.Left)
                {
                    //zaznamenat souřadnice
                    mobjDrawingCoordsEnd.X = e.X;
                    mobjDrawingCoordsEnd.Y = e.Y;

                    //nakopírovat na picturebox
                    mobjGrafika.DrawImage(mobjBitmap, 0, 0);
                    //Nakresli
                    NakresliObjekt(mobjGrafika);

       

   

                }
            }
            catch (Exception ex)
            { 
            
            }
            if (menActualTool == enTools.Pen)
            {
                if (mblImDrawing == true)
                {
                    mobjGrafika.DrawRectangle(lobjPero, e.X, e.Y, 1, 1);
                }
                    
            }
        }

        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
            Pen lobjPero;
            lobjPero = new Pen(mobjForeColor);
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
                    NakresliObjekt(mobjGrafikaVRam);

                    //nakopírovat na picturebox
                    mobjGrafika.DrawImage(mobjBitmap,0,0);  

                    //kreslím
                    mblImDrawing = false;
                    
                }

            }
            catch (Exception ex)
            {
                mblImDrawing = false;
            }
        }
        private void NakresliObjekt(Graphics objGrafika)
        {
            try
            {
                Pen lobjPero;
                Brush lobjBrush;
                lobjPero = new Pen(mobjForeColor);
                lobjBrush = new SolidBrush(mobjBackColor);
                //vybrat co kreslím
                switch (menActualTool)
                {
                    case enTools.Line:
                        //nakresli čáru
                        objGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;
                    case enTools.Rectangle:
                        //nastavit pero
                        lobjPero = new Pen(mobjForeColor);
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X > 0)
                        {
                            mobjDrawingCoords1.X = mobjDrawingCoordsEnd.X;
                        }
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X < 0)
                        {
                            mobjDrawingCoords1.X = mobjDrawingCoordsStart.X;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y > 0)
                        {
                            mobjDrawingCoords1.Y = mobjDrawingCoordsEnd.Y;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y < 0)
                        {
                            mobjDrawingCoords1.Y = mobjDrawingCoordsStart.Y;
                        }
                        //nakresli čáru
                        if (mobjBackColor != Color.White) 
                        {
                            objGrafika.FillRectangle(lobjBrush,
                            mobjDrawingCoords1.X, mobjDrawingCoords1.Y,
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                        }
                        else if (mobjBackColor == Color.White) 
                        {
                            objGrafika.DrawRectangle(lobjPero,
                            mobjDrawingCoords1.X, mobjDrawingCoords1.Y, 
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                            }
                        break;
                    case enTools.Elipse:
                        //nastavit pero
                        lobjPero = new Pen(mobjForeColor);
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X > 0)
                        {
                            mobjDrawingCoords1.X = mobjDrawingCoordsEnd.X;
                        }
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X < 0)
                        {
                            mobjDrawingCoords1.X = mobjDrawingCoordsStart.X;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y > 0)
                        {
                            mobjDrawingCoords1.Y = mobjDrawingCoordsEnd.Y;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y < 0)
                        {
                            mobjDrawingCoords1.Y = mobjDrawingCoordsStart.Y;
                        }
                        //nakresli čáru
                        if (mobjBackColor != Color.White)
                        {
                            objGrafika.FillEllipse(lobjBrush,
                            mobjDrawingCoords1.X, mobjDrawingCoords1.Y,
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                        }
                        else if (mobjBackColor == Color.White)
                        {
                            objGrafika.DrawEllipse(lobjPero,
                            mobjDrawingCoords1.X, mobjDrawingCoords1.Y,
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                        }
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
                if (e.Button == MouseButtons.Right)
                {
                    //zobrazit
                    pnBackColor.BackColor = lobjPanel.BackColor;
                    //zapsat
                    mobjBackColor = lobjPanel.BackColor;
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        //
        // výběr nástroje
        //
        private void rbTool_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton lobjTool;
                lobjTool = (RadioButton)sender; 

                //výběr nástroje

                    switch (lobjTool.Text) 
                    {
                    case "Pero":
                        menActualTool = enTools.Pen;
                        break;
                    case "Čára":
                            menActualTool = enTools.Line;
                            break;
                    case "Obdelník":
                        menActualTool = enTools.Rectangle;
                        break;
                    case "Kružnice":
                        menActualTool = enTools.Elipse;
                        break;
                }
            }
            catch (Exception ex)
            {
                menActualTool = enTools.Line;
                rbLine.Checked = true;
            }
        }
        //
        // ukončit program
        //
        private void tsmiKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //uložit obrázek
        //
        private void tsmiUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
               //mobjBitmap.Save("c:\\temp\\obrazek.jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
