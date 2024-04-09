using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        Point mobjDrawingCoordsLowest;
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
        //--------------------------------------
        // tlačítko smazat
        //----------------------------------------
        private void btVymazat_Click(object sender, EventArgs e)
        {
            // Vymazání bitmapy
            mobjBitmap = new Bitmap(pbPlatno.Width, pbPlatno.Height);
            mobjGrafikaVRam = Graphics.FromImage(mobjBitmap);
            mobjGrafikaVRam.Clear(Color.White);

            // Update PictureBoxu
            pbPlatno.Image = mobjBitmap;
        }
        //---------------------------------------
        // pohyb myši nad pictureboxem
        //-------------------------------------
        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            //deklarace proměnné
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

                    //kreslení pomocí pera
                    if (menActualTool == enTools.Pen)
                    {
                        if (mblImDrawing == true)  
                            {
                                //kreslení přímky mezi 2 po sobě jdoucími body
                                mobjGrafikaVRam.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                            }
                        //přepis nového bodu
                        mobjDrawingCoordsStart = mobjDrawingCoordsEnd;
                    }



                }
            }
            catch (Exception ex)
            { 
            
            }
        }
        //---------------------------------------
        // stisknutí myši nad pictureboxem
        //-------------------------------------
        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
            //deklarace proměnné
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
        //---------------------------------------
        // uvolnění  myši nad pictureboxem
        //-------------------------------------
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
        //---------------------------------------
        // kreslení jedlotlivých útvarů
        //-------------------------------------
        private void NakresliObjekt(Graphics objGrafika)
        {
            try
            {
                //deklarace proměnných
                Pen lobjPero;
                Brush lobjBrush;
                lobjPero = new Pen(mobjForeColor);
                lobjBrush = new SolidBrush(mobjBackColor);
                //vybrat co kreslím
                switch (menActualTool)
                {
                    case enTools.Line:
                        //nakresli přímku
                        objGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;
                    case enTools.Rectangle:
                        //nastavit pero
                        lobjPero = new Pen(mobjForeColor);
                        //řešení problému kreslení ve všech směrech
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X > 0)
                        {
                            mobjDrawingCoordsLowest.X = mobjDrawingCoordsEnd.X;
                        }
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X < 0)
                        {
                            mobjDrawingCoordsLowest.X = mobjDrawingCoordsStart.X;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y > 0)
                        {
                            mobjDrawingCoordsLowest.Y = mobjDrawingCoordsEnd.Y;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y < 0)
                        {
                            mobjDrawingCoordsLowest.Y = mobjDrawingCoordsStart.Y;
                        }
                        //nakresli vyplněný obdelník
                        if (mobjBackColor != Color.White) 
                        {
                            objGrafika.FillRectangle(lobjBrush,
                            mobjDrawingCoordsLowest.X, mobjDrawingCoordsLowest.Y,
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                        }
                        //nakresli obdelník
                        else if (mobjBackColor == Color.White) 
                        {
                            objGrafika.DrawRectangle(lobjPero,
                            mobjDrawingCoordsLowest.X, mobjDrawingCoordsLowest.Y, 
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                            }
                        break;
                    case enTools.Elipse:
                        //nastavit pero
                        lobjPero = new Pen(mobjForeColor);
                        //řešení problému kreslení ve všech směrech
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X > 0)
                        {
                            mobjDrawingCoordsLowest.X = mobjDrawingCoordsEnd.X;
                        }
                        if (mobjDrawingCoordsStart.X - mobjDrawingCoordsEnd.X < 0)
                        {
                            mobjDrawingCoordsLowest.X = mobjDrawingCoordsStart.X;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y > 0)
                        {
                            mobjDrawingCoordsLowest.Y = mobjDrawingCoordsEnd.Y;
                        }
                        if (mobjDrawingCoordsStart.Y - mobjDrawingCoordsEnd.Y < 0)
                        {
                            mobjDrawingCoordsLowest.Y = mobjDrawingCoordsStart.Y;
                        }
                        //nakresli vyplněnou elipsu
                        if (mobjBackColor != Color.White)
                        {
                            objGrafika.FillEllipse(lobjBrush,
                            mobjDrawingCoordsLowest.X, mobjDrawingCoordsLowest.Y,
                            Math.Abs(mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X),
                            Math.Abs(mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y));
                        }
                        //nakresli elipsu
                        else if (mobjBackColor == Color.White)
                        {
                            objGrafika.DrawEllipse(lobjPero,
                            mobjDrawingCoordsLowest.X, mobjDrawingCoordsLowest.Y,
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
        //--------------------------------------
        // tlačítko barev
        //----------------------------------------
        private void pnColor_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Panel lobjPanel;

                //nastavit kdo to posílá
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

        //--------------------------
        // výběr nástroje
        //------------------------
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
        //---------------------------------
        // menu strip ukončit program
        //------------------------------
        private void tsmiKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-----------------------------------
        //menu strip uložit obrázek
        //----------------------------------
        private void tsmiUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                //výběr formátů
                saveFileDialog.Filter = "PNG|*.png;|JPEG|*.jpeg;|BMP|*.bmp;|GIF|*.gif;";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // zjišťuje jaká cesta byla vybrána
                    string selectedFilePath = saveFileDialog.FileName;

                    // jaký formát byl vybrán
                    ImageFormat format;
                    switch (Path.GetExtension(selectedFilePath).ToLower())
                    {
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".jpg":
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".gif":
                            format = ImageFormat.Gif;
                            break;
                        default:
                            format = ImageFormat.Png;
                            return;
                    }

                    // uložení obrázku
                    if (mobjBitmap != null)
                    {
                        mobjBitmap.Save(selectedFilePath, format);
                        MessageBox.Show("Obrázek se podařilo uložit");
                    }
                    else
                    {
                        MessageBox.Show("Žádný obrázek k uložení");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba");
            }
        }
        //-----------------------------------
        //menu strip otevřít obrázek
        //----------------------------------
        private void tsmiOtevrit_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //zkopírování otevřeného obrázku na bitmapu a picturebox
                    mobjBitmap = new Bitmap(openFileDialog.FileName);
                    mobjGrafikaVRam = Graphics.FromImage(mobjBitmap);
                    pbPlatno.Image = mobjBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba");
            }
        }
    }
}

